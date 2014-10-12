namespace DanTup.DartVS.OptionsPages
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using DialogPage = Microsoft.VisualStudio.Shell.DialogPage;
    using IWin32Window = System.Windows.Forms.IWin32Window;
    using Point = System.Drawing.Point;

    [Guid("BDFE01A0-E1BB-48DF-A86A-3B40BDFC73FF")]
    public class IntellisenseOptions : DialogPage
    {
        public const string DefaultCommitCharacters = "{}[]()<>.,:;+-*/%&|^!~=?@#'\"\\";

        public IntellisenseOptions()
        {
            // initialize to default values
            ShowCompletionAfterTypedChar = false;
            KeywordsInCompletionLists = true;
            CodeSnippetsInCompletionLists = true;

            CommitCharacters = DefaultCommitCharacters;
            CommitOnSpace = true;
            NewLineAfterEnterCompletion = false;

            RecentCompletions = true;
        }

        private IntellisenseOptionsControl OptionsControl
        {
            get;
            set;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected override IWin32Window Window
        {
            get
            {
                OptionsControl = new IntellisenseOptionsControl(this);
                OptionsControl.Location = new Point(0, 0);
                return OptionsControl;
            }
        }

        [DefaultValue(false)]
        public bool ShowCompletionAfterTypedChar
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool KeywordsInCompletionLists
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool CodeSnippetsInCompletionLists
        {
            get;
            set;
        }

        [DefaultValue(DefaultCommitCharacters)]
        public string CommitCharacters
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool CommitOnSpace
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool NewLineAfterEnterCompletion
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool RecentCompletions
        {
            get;
            set;
        }

        public override void SaveSettingsToStorage()
        {
            if (OptionsControl != null)
                OptionsControl.ApplyChanges();

            base.SaveSettingsToStorage();
        }
    }
}
