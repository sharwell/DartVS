using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using DanTup.DartAnalysis;
using DanTup.DartVS.OptionsPages;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text;

namespace DanTup.DartVS
{
	[InstalledProductRegistration("DanTup's DartVS: Visual Studio support for Google's Dart", @"Some support for coding Dart in Visual Studio.", AssemblyInfo.InstalledProductVersion)]
	[ProvideAutoLoad(VSConstants.UICONTEXT.SolutionExists_string)]
	[ProvideLanguageService(typeof(DartLanguageInfo), DartConstants.LanguageName, 100)]
	[ProvideLanguageExtension(typeof(DartLanguageInfo), DartConstants.FileExtension)]

	[ProvideLanguageEditorOptionPage(typeof(AdvancedOptions), DartConstants.LanguageName, "", "Advanced", "#203")]
	[ProvideLanguageEditorOptionPage(typeof(IntellisenseOptions), DartConstants.LanguageName, "", "IntelliSense", "#204")]

	[ProvideLanguageEditorToolsOptionCategory(DartConstants.LanguageName, "Formatting", "#210")]
	[ProvideLanguageEditorOptionPage(typeof(FormattingGeneralOptions), DartConstants.LanguageName, "Formatting", "General", "#211")]
	[ProvideLanguageEditorOptionPage(typeof(FormattingIndentationOptions), DartConstants.LanguageName, "Formatting", "Indentation", "#212")]
	[ProvideLanguageEditorOptionPage(typeof(FormattingNewLinesOptions), DartConstants.LanguageName, "Formatting", "NewLines", "#213")]
	[ProvideLanguageEditorOptionPage(typeof(FormattingSpacingOptions), DartConstants.LanguageName, "Formatting", "Spacing", "#214")]
	[ProvideLanguageEditorOptionPage(typeof(FormattingWrappingOptions), DartConstants.LanguageName, "Formatting", "Wrapping", "#215")]

	public sealed class DartPackage : Package
	{
		[Import]
		DartAnalysisServiceFactory analysisServiceFactory = null;

		[Import]
		ITextDocumentFactoryService textDocumentFactory = null;

		[Import]
		IVsEditorAdaptersFactoryService editorAdapterFactory = null;

		DartErrorListProvider errorProvider;
		Task<IDisposable> errorsSubscription;

		// TODO: Handle file renames properly (errors stick around)
		// TODO: Handle closing projects/solutions (errors stick around)

		protected override void Initialize()
		{
			base.Initialize();

			// Force initialisation of [Imports] on this class.
			var componentModel = GetService(typeof(SComponentModel)) as IComponentModel;
			componentModel.DefaultCompositionService.SatisfyImportsOnce(this);

			// Wire up the Error Provider to the notifications from the service.
			errorProvider = new DartErrorListProvider(this);
			errorsSubscription = SubscribeAsync(errorProvider);

			// Register icons so they show in the solution explorer nicely.
			IconRegistration.RegisterIcons();

			((IServiceContainer)this).AddService(typeof(DartLanguageInfo), new DartLanguageInfo(textDocumentFactory, editorAdapterFactory, analysisServiceFactory), true);
		}

		private async Task<IDisposable> SubscribeAsync(DartErrorListProvider errorProvider)
		{
			DartAnalysisService analysisService = await analysisServiceFactory.GetAnalysisServiceAsync().ConfigureAwait(false);
			return analysisService.AnalysisErrorsNotification.Subscribe(errorProvider.UpdateErrors);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				Task<IDisposable> errorsSubscriptionTask = errorsSubscription;
				if (errorsSubscriptionTask != null)
					errorsSubscriptionTask.ContinueWith(task => task.Result.Dispose(), TaskContinuationOptions.OnlyOnRanToCompletion);
			}
		}

		public static T GetGlobalService<T>(Type type = null) where T : class
		{
			return Package.GetGlobalService(type ?? typeof(T)) as T;
		}
	}
}
