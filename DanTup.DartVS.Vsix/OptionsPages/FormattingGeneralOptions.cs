namespace DanTup.DartVS.OptionsPages
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using DialogPage = Microsoft.VisualStudio.Shell.DialogPage;
    using IWin32Window = System.Windows.Forms.IWin32Window;
    using Point = System.Drawing.Point;

    [Guid("DFDA91A1-46DF-45C3-908A-755A0D81C75F")]
    public class FormattingGeneralOptions : DialogPage
    {
        public FormattingGeneralOptions()
        {
            AutoFormatOnSemi = true;
            AutoFormatOnCloseBrace = true;
            AutoFormatOnPaste = true;
            Experimental = false;
        }

        private FormattingGeneralOptionsControl OptionsControl
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
                OptionsControl = new FormattingGeneralOptionsControl(this);
                OptionsControl.Location = new Point(0, 0);
                return OptionsControl;
            }
        }

        [DefaultValue(true)]
        public bool AutoFormatOnSemi
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool AutoFormatOnCloseBrace
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool AutoFormatOnPaste
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool Experimental
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
