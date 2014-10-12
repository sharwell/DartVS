namespace DanTup.DartVS.OptionsPages
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using DialogPage = Microsoft.VisualStudio.Shell.DialogPage;
    using IWin32Window = System.Windows.Forms.IWin32Window;
    using Point = System.Drawing.Point;

    [Guid("1F8F2F4E-DC9E-4EFA-A2E8-9B592C436B7C")]
    public class FormattingWrappingOptions : DialogPage
    {
        public FormattingWrappingOptions()
        {
            // initialize to default values
            LeaveBlockOnSingleLine = false;
            LeaveStatementsOnSameLine = false;
        }

        private FormattingWrappingOptionsControl OptionsControl
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
                OptionsControl = new FormattingWrappingOptionsControl(this);
                OptionsControl.Location = new Point(0, 0);
                return OptionsControl;
            }
        }

        [DefaultValue(false)]
        public bool LeaveBlockOnSingleLine
        {
            get;
            set;
        }
        [DefaultValue(false)]
        public bool LeaveStatementsOnSameLine
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
