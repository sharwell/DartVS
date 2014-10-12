namespace DanTup.DartVS.OptionsPages
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using DialogPage = Microsoft.VisualStudio.Shell.DialogPage;
    using IWin32Window = System.Windows.Forms.IWin32Window;
    using Point = System.Drawing.Point;

    [Guid("E9C1CB8F-C3CA-4B6C-BD80-050C3785725A")]
    public class AdvancedOptions : DialogPage
    {
        public AdvancedOptions()
        {
            UnderlineErrorsInEditor = true;
            ShowLiveErrors = true;
            AvoidHardTabsWithinText = true;
            SupportsDotDotOperator = false;
        }

        private AdvancedOptionsControl OptionsControl
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
                OptionsControl = new AdvancedOptionsControl(this);
                OptionsControl.Location = new Point(0, 0);
                return OptionsControl;
            }
        }

        [DefaultValue(true)]
        public bool UnderlineErrorsInEditor
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool ShowLiveErrors
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool AvoidHardTabsWithinText
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SupportsDotDotOperator
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
