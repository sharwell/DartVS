namespace DanTup.DartVS.OptionsPages
{
    using System;
    using System.Windows.Forms;

    public partial class AdvancedOptionsControl : UserControl
    {
        public AdvancedOptionsControl(AdvancedOptions optionsPage)
        {
            if (optionsPage == null)
                throw new ArgumentNullException("optionsPage");

            InitializeComponent();

            OptionsPage = optionsPage;
            ReloadOptions();
        }

        private AdvancedOptions OptionsPage
        {
            get;
            set;
        }

        public void ReloadOptions()
        {
            chkUnderlineErrors.Checked = OptionsPage.UnderlineErrorsInEditor;
            chkLiveErrors.Checked = OptionsPage.ShowLiveErrors;
            chkAvoidBadTabs.Checked = OptionsPage.AvoidHardTabsWithinText;
            chkSupportsDotDotOperator.Checked = OptionsPage.SupportsDotDotOperator;
        }

        public void ApplyChanges()
        {
            OptionsPage.UnderlineErrorsInEditor = chkUnderlineErrors.Checked;
            OptionsPage.ShowLiveErrors = chkLiveErrors.Checked;
            OptionsPage.AvoidHardTabsWithinText = chkAvoidBadTabs.Checked;
            OptionsPage.SupportsDotDotOperator = chkSupportsDotDotOperator.Checked;
        }
    }
}
