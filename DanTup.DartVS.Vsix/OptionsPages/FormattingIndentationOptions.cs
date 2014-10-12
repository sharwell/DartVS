namespace DanTup.DartVS.OptionsPages
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using DialogPage = Microsoft.VisualStudio.Shell.DialogPage;
    using IWin32Window = System.Windows.Forms.IWin32Window;
    using Point = System.Drawing.Point;

    [Guid("FE73A8AC-A7CF-4C7B-88B6-9F700902ED3A")]
    public class FormattingIndentationOptions : DialogPage
    {
        public FormattingIndentationOptions()
        {
            IndentBlockContents = true;
            IndentOpenAndCloseBraces = false;
            IndentCaseContents = true;
            IndentCaseLabels = false;

            LabelIndentation = LabelIndentationMode.OneIndentLess;
        }

        private FormattingIndentationOptionsControl OptionsControl
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
                OptionsControl = new FormattingIndentationOptionsControl(this);
                OptionsControl.Location = new Point(0, 0);
                return OptionsControl;
            }
        }

        [DefaultValue(true)]
        public bool IndentBlockContents
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool IndentOpenAndCloseBraces
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool IndentCaseContents
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool IndentCaseLabels
        {
            get;
            set;
        }

        [DefaultValue(LabelIndentationMode.OneIndentLess)]
        public LabelIndentationMode LabelIndentation
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
