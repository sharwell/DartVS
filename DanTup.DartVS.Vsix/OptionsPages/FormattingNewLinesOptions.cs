namespace DanTup.DartVS.OptionsPages
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using DialogPage = Microsoft.VisualStudio.Shell.DialogPage;
    using IWin32Window = System.Windows.Forms.IWin32Window;
    using Point = System.Drawing.Point;

    [Guid("469C8CE7-E69E-4CCA-B78F-A7F1C356DD54")]
    public class FormattingNewLinesOptions : DialogPage
    {
        public FormattingNewLinesOptions()
        {
            OpenBraceOnNewLineTypes = true;
            OpenBraceOnNewLineMethods = true;
            OpenBraceOnNewLineControlBlocks = true;

            ElseOnNewLine = true;
        }

        private FormattingNewLinesOptionsControl OptionsControl
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
                OptionsControl = new FormattingNewLinesOptionsControl(this);
                OptionsControl.Location = new Point(0, 0);
                return OptionsControl;
            }
        }

        [DefaultValue(true)]
        public bool OpenBraceOnNewLineTypes
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool OpenBraceOnNewLineMethods
        {
            get;
            set;
        }

        //public bool OpenBraceOnNewLineAnonymousMethods
        //{
        //    get;
        //    set;
        //}

        [DefaultValue(true)]
        public bool OpenBraceOnNewLineControlBlocks
        {
            get;
            set;
        }

        //public bool OpenBraceOnNewLineAnonymousTypes
        //{
        //    get;
        //    set;
        //}

        //public bool OpenBraceOnNewLineObjectInitializers
        //{
        //    get;
        //    set;
        //}

        //public bool OpenBraceOnNewLineLambdaExpressions
        //{
        //    get;
        //    set;
        //}

        [DefaultValue(true)]
        public bool ElseOnNewLine
        {
            get;
            set;
        }

        //public bool CatchOnNewLine
        //{
        //    get;
        //    set;
        //}

        //public bool FinallyOnNewLine
        //{
        //    get;
        //    set;
        //}

        public override void SaveSettingsToStorage()
        {
            if (OptionsControl != null)
                OptionsControl.ApplyChanges();

            base.SaveSettingsToStorage();
        }
    }
}
