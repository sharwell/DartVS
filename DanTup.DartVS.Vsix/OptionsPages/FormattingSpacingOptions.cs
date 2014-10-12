namespace DanTup.DartVS.OptionsPages
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using DialogPage = Microsoft.VisualStudio.Shell.DialogPage;
    using IWin32Window = System.Windows.Forms.IWin32Window;
    using Point = System.Drawing.Point;

    [Guid("933BA48B-79FA-4AB4-A2FE-F17C77CAFA57")]
    public class FormattingSpacingOptions : DialogPage
    {
        public FormattingSpacingOptions()
        {
            // initialize to default values
            SpaceInMethodDeclarationNameParenthesis = false;
            SpaceInDeclarationArgumentListParentheses = false;
            SpaceInDeclarationEmptyArgumentList = false;

            SpaceInMethodCallNameParenthesis = false;
            SpaceInCallArgumentListParentheses = false;
            SpaceInCallEmptyArgumentList = false;

            SpaceAfterKeywordsInControlFlow = true;
            SpaceInExpressionParentheses = false;
            SpaceInTypeCastParentheses = false;
            SpaceInControlFlowParentheses = false;
            SpaceAfterCast = false;
            IgnoreSpaceInDeclarations = false;

            SpaceBeforeOpenBracket = false;
            SpaceInEmptyBrackets = false;
            SpaceInBrackets = false;

            SpaceAfterColonInTypeDeclaration = true;
            SpaceAfterComma = true;
            SpaceAfterDot = false;
            SpaceAfterSemiInForStatement = true;
            SpaceBeforeColonInTypeDeclaration = true;
            SpaceBeforeComma = false;
            SpaceBeforeDot = false;
            SpaceBeforeSemiInForStatement = false;

            OperatorSpacing = OperatorSpacingMode.Insert;
        }

        private FormattingSpacingOptionsControl OptionsControl
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
                OptionsControl = new FormattingSpacingOptionsControl(this);
                OptionsControl.Location = new Point(0, 0);
                return OptionsControl;
            }
        }

        // insert space between method name and its opening parenthesis
        [DefaultValue(false)]
        public bool SpaceInMethodDeclarationNameParenthesis
        {
            get;
            set;
        }

        // insert space within argument list parenthesis
        [DefaultValue(false)]
        public bool SpaceInDeclarationArgumentListParentheses
        {
            get;
            set;
        }

        // insert space within empty argument list parentheses
        [DefaultValue(false)]
        public bool SpaceInDeclarationEmptyArgumentList
        {
            get;
            set;
        }

        // insert space between method name and its opening parenthesis
        [DefaultValue(false)]
        public bool SpaceInMethodCallNameParenthesis
        {
            get;
            set;
        }

        // insert space within argument list parenthesis
        [DefaultValue(false)]
        public bool SpaceInCallArgumentListParentheses
        {
            get;
            set;
        }

        // insert space within empty argument list parentheses
        [DefaultValue(false)]
        public bool SpaceInCallEmptyArgumentList
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool SpaceAfterKeywordsInControlFlow
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceInExpressionParentheses
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceInTypeCastParentheses
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceInControlFlowParentheses
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceAfterCast
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool IgnoreSpaceInDeclarations
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceBeforeOpenBracket
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceInEmptyBrackets
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceInBrackets
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool SpaceAfterColonInTypeDeclaration
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool SpaceAfterComma
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceAfterDot
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool SpaceAfterSemiInForStatement
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool SpaceBeforeColonInTypeDeclaration
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceBeforeComma
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceBeforeDot
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool SpaceBeforeSemiInForStatement
        {
            get;
            set;
        }

        [DefaultValue(OperatorSpacingMode.Insert)]
        public OperatorSpacingMode OperatorSpacing
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
