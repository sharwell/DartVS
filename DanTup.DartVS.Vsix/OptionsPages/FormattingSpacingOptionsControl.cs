using System;
using System.Windows.Forms;

namespace DanTup.DartVS.OptionsPages
{
    public partial class FormattingSpacingOptionsControl : UserControl
    {
        public FormattingSpacingOptionsControl( FormattingSpacingOptions optionsPage )
        {
            InitializeComponent();

            OptionsPage = optionsPage;
            ReloadSettings();
            optionsTreeView1.ExpandAll();
        }

        FormattingSpacingOptions OptionsPage
        {
            get;
            set;
        }

        TreeNode FindTreeNode( string name )
        {
            if ( string.IsNullOrEmpty( name ) )
                return null;

            foreach ( TreeNode child in optionsTreeView1.Nodes )
            {
                TreeNode node = FindTreeNode( child, name );
                if ( node != null )
                    return node;
            }

            return null;
        }
        static TreeNode FindTreeNode( TreeNode node, string name )
        {
            if ( node == null )
                return null;

            if ( node.Name == name )
                return node;

            foreach ( TreeNode child in node.Nodes )
            {
                TreeNode found = FindTreeNode( child, name );
                if ( found != null )
                    return found;
            }

            return null;
        }

        // method declarations
        TreeNode chkSpaceInMethodDeclarationNameParenthesis
        {
            get
            {
                return FindTreeNode( "chkSpaceInMethodDeclarationNameParenthesis" );
            }
        }
        TreeNode chkSpaceInDeclarationArgumentListParentheses
        {
            get
            {
                return FindTreeNode( "chkSpaceInDeclarationArgumentListParentheses" );
            }
        }
        TreeNode chkSpaceInDeclarationEmptyArgumentList
        {
            get
            {
                return FindTreeNode( "chkSpaceInDeclarationEmptyArgumentList" );
            }
        }

        // method calls
        TreeNode chkSpaceInMethodCallNameParenthesis
        {
            get
            {
                return FindTreeNode( "chkSpaceInMethodCallNameParenthesis" );
            }
        }
        TreeNode chkSpaceInCallArgumentListParentheses
        {
            get
            {
                return FindTreeNode( "chkSpaceInCallArgumentListParentheses" );
            }
        }
        TreeNode chkSpaceInCallEmptyArgumentList
        {
            get
            {
                return FindTreeNode( "chkSpaceInCallEmptyArgumentList" );
            }
        }

        // other spacing options
        TreeNode chkSpaceAfterKeywordsInControlFlow
        {
            get
            {
                return FindTreeNode( "chkSpaceAfterKeywordsInControlFlow" );
            }
        }
        TreeNode chkSpaceInExpressionParentheses
        {
            get
            {
                return FindTreeNode( "chkSpaceInExpressionParentheses" );
            }
        }
        TreeNode chkSpaceInTypeCastParentheses
        {
            get
            {
                return FindTreeNode( "chkSpaceInTypeCastParentheses" );
            }
        }
        TreeNode chkSpaceInControlFlowParentheses
        {
            get
            {
                return FindTreeNode( "chkSpaceInControlFlowParentheses" );
            }
        }
        TreeNode chkSpaceAfterCast
        {
            get
            {
                return FindTreeNode( "chkSpaceAfterCast" );
            }
        }
        TreeNode chkIgnoreSpaceInDeclarations
        {
            get
            {
                return FindTreeNode( "chkIgnoreSpaceInDeclarations" );
            }
        }

        // spacing for brackets
        TreeNode chkSpaceBeforeOpenBracket
        {
            get
            {
                return FindTreeNode( "chkSpaceBeforeOpenBracket" );
            }
        }
        TreeNode chkSpaceInEmptyBrackets
        {
            get
            {
                return FindTreeNode( "chkSpaceInEmptyBrackets" );
            }
        }
        TreeNode chkSpaceInBrackets
        {
            get
            {
                return FindTreeNode( "chkSpaceInBrackets" );
            }
        }

        // spacing for delimiters
        TreeNode chkSpaceAfterColonInTypeDeclaration
        {
            get
            {
                return FindTreeNode( "chkSpaceAfterColonInTypeDeclaration" );
            }
        }
        TreeNode chkSpaceAfterComma
        {
            get
            {
                return FindTreeNode( "chkSpaceAfterComma" );
            }
        }
        TreeNode chkSpaceAfterDot
        {
            get
            {
                return FindTreeNode( "chkSpaceAfterDot" );
            }
        }
        TreeNode chkSpaceAfterSemiInForStatement
        {
            get
            {
                return FindTreeNode( "chkSpaceAfterSemiInForStatement" );
            }
        }
        TreeNode chkSpaceBeforeColonInTypeDeclaration
        {
            get
            {
                return FindTreeNode( "chkSpaceBeforeColonInTypeDeclaration" );
            }
        }
        TreeNode chkSpaceBeforeComma
        {
            get
            {
                return FindTreeNode( "chkSpaceBeforeComma" );
            }
        }
        TreeNode chkSpaceBeforeDot
        {
            get
            {
                return FindTreeNode( "chkSpaceBeforeDot" );
            }
        }
        TreeNode chkSpaceBeforeSemiInForStatement
        {
            get
            {
                return FindTreeNode( "chkSpaceBeforeSemiInForStatement" );
            }
        }

        // spacing for operators
        TreeNode radOperatorInsertSpace
        {
            get
            {
                return FindTreeNode( "radOperatorInsertSpace" );
            }
        }
        TreeNode radOperatorIgnoreSpace
        {
            get
            {
                return FindTreeNode( "radOperatorIgnoreSpace" );
            }
        }
        TreeNode radOperatorRemoveSpace
        {
            get
            {
                return FindTreeNode( "radOperatorRemoveSpace" );
            }
        }


        public void ReloadSettings()
        {
            // method declarations
            chkSpaceInMethodDeclarationNameParenthesis.Checked = OptionsPage.SpaceInMethodDeclarationNameParenthesis;
            chkSpaceInDeclarationArgumentListParentheses.Checked = OptionsPage.SpaceInDeclarationArgumentListParentheses;
            chkSpaceInDeclarationEmptyArgumentList.Checked = OptionsPage.SpaceInDeclarationEmptyArgumentList;

            // method calls
            chkSpaceInMethodCallNameParenthesis.Checked = OptionsPage.SpaceInMethodCallNameParenthesis;
            chkSpaceInCallArgumentListParentheses.Checked = OptionsPage.SpaceInCallArgumentListParentheses;
            chkSpaceInCallEmptyArgumentList.Checked = OptionsPage.SpaceInCallEmptyArgumentList;

            // other spacing options
            chkSpaceAfterKeywordsInControlFlow.Checked = OptionsPage.SpaceAfterKeywordsInControlFlow;
            chkSpaceInExpressionParentheses.Checked = OptionsPage.SpaceInExpressionParentheses;
            chkSpaceInTypeCastParentheses.Checked = OptionsPage.SpaceInTypeCastParentheses;
            chkSpaceInControlFlowParentheses.Checked = OptionsPage.SpaceInControlFlowParentheses;
            chkSpaceAfterCast.Checked = OptionsPage.SpaceAfterCast;
            chkIgnoreSpaceInDeclarations.Checked = OptionsPage.IgnoreSpaceInDeclarations;

            // spacing for brackets
            chkSpaceBeforeOpenBracket.Checked = OptionsPage.SpaceBeforeOpenBracket;
            chkSpaceInEmptyBrackets.Checked = OptionsPage.SpaceInEmptyBrackets;
            chkSpaceInBrackets.Checked = OptionsPage.SpaceInBrackets;

            // spacing for delimiters
            chkSpaceAfterColonInTypeDeclaration.Checked = OptionsPage.SpaceAfterColonInTypeDeclaration;
            chkSpaceAfterComma.Checked = OptionsPage.SpaceAfterComma;
            chkSpaceAfterDot.Checked = OptionsPage.SpaceAfterDot;
            chkSpaceAfterSemiInForStatement.Checked = OptionsPage.SpaceAfterSemiInForStatement;
            chkSpaceBeforeColonInTypeDeclaration.Checked = OptionsPage.SpaceBeforeColonInTypeDeclaration;
            chkSpaceBeforeComma.Checked = OptionsPage.SpaceBeforeComma;
            chkSpaceBeforeDot.Checked = OptionsPage.SpaceBeforeDot;
            chkSpaceBeforeSemiInForStatement.Checked = OptionsPage.SpaceBeforeSemiInForStatement;

            // spacing for operators
            radOperatorInsertSpace.Checked = ( OptionsPage.OperatorSpacing == OperatorSpacingMode.Insert );
            radOperatorIgnoreSpace.Checked = ( OptionsPage.OperatorSpacing == OperatorSpacingMode.Ignore );
            radOperatorRemoveSpace.Checked = ( OptionsPage.OperatorSpacing == OperatorSpacingMode.Remove );
        }

        public void ApplyChanges()
        {
            // method declarations
            OptionsPage.SpaceInMethodDeclarationNameParenthesis = chkSpaceInMethodDeclarationNameParenthesis.Checked;
            OptionsPage.SpaceInDeclarationArgumentListParentheses = chkSpaceInDeclarationArgumentListParentheses.Checked;
            OptionsPage.SpaceInDeclarationEmptyArgumentList = chkSpaceInDeclarationEmptyArgumentList.Checked;

            // method calls
            OptionsPage.SpaceInMethodCallNameParenthesis = chkSpaceInMethodCallNameParenthesis.Checked;
            OptionsPage.SpaceInCallArgumentListParentheses = chkSpaceInCallArgumentListParentheses.Checked;
            OptionsPage.SpaceInCallEmptyArgumentList = chkSpaceInCallEmptyArgumentList.Checked;

            // other spacing options
            OptionsPage.SpaceAfterKeywordsInControlFlow = chkSpaceAfterKeywordsInControlFlow.Checked;
            OptionsPage.SpaceInExpressionParentheses = chkSpaceInExpressionParentheses.Checked;
            OptionsPage.SpaceInTypeCastParentheses = chkSpaceInTypeCastParentheses.Checked;
            OptionsPage.SpaceInControlFlowParentheses = chkSpaceInControlFlowParentheses.Checked;
            OptionsPage.SpaceAfterCast = chkSpaceAfterCast.Checked;
            OptionsPage.IgnoreSpaceInDeclarations = chkIgnoreSpaceInDeclarations.Checked;

            // spacing for brackets
            OptionsPage.SpaceBeforeOpenBracket = chkSpaceBeforeOpenBracket.Checked;
            OptionsPage.SpaceInEmptyBrackets = chkSpaceInEmptyBrackets.Checked;
            OptionsPage.SpaceInBrackets = chkSpaceInBrackets.Checked;

            // spacing for delimiters
            OptionsPage.SpaceAfterColonInTypeDeclaration = chkSpaceAfterColonInTypeDeclaration.Checked;
            OptionsPage.SpaceAfterComma = chkSpaceAfterComma.Checked;
            OptionsPage.SpaceAfterDot = chkSpaceAfterDot.Checked;
            OptionsPage.SpaceAfterSemiInForStatement = chkSpaceAfterSemiInForStatement.Checked;
            OptionsPage.SpaceBeforeColonInTypeDeclaration = chkSpaceBeforeColonInTypeDeclaration.Checked;
            OptionsPage.SpaceBeforeComma = chkSpaceBeforeComma.Checked;
            OptionsPage.SpaceBeforeDot = chkSpaceBeforeDot.Checked;
            OptionsPage.SpaceBeforeSemiInForStatement = chkSpaceBeforeSemiInForStatement.Checked;

            if ( radOperatorInsertSpace.Checked )
                OptionsPage.OperatorSpacing = OperatorSpacingMode.Insert;
            else if ( radOperatorIgnoreSpace.Checked )
                OptionsPage.OperatorSpacing = OperatorSpacingMode.Ignore;
            else if ( radOperatorRemoveSpace.Checked )
                OptionsPage.OperatorSpacing = OperatorSpacingMode.Remove;
        }

        private void FormattingSpacingOptionsControl_Resize( object sender, EventArgs e )
        {
            splitContainer1.SplitterDistance = Height / 2;
        }

        void UpdatePreviewText()
        {
            if ( chkSpaceInMethodDeclarationNameParenthesis.IsSelected )
            {
                if ( chkSpaceInMethodDeclarationNameParenthesis.Checked )
                    textBox1.Text = "function int Method ()\r\n{\r\n    return 3;\r\n}";
                else
                    textBox1.Text = "function int Method()\r\n{\r\n    return 3;\r\n}";
            }
            else if ( chkSpaceInDeclarationArgumentListParentheses.IsSelected )
            {
                if ( chkSpaceInDeclarationArgumentListParentheses.Checked )
                    textBox1.Text = "function int Method( int a )\r\n{\r\n    return a;\r\n}";
                else
                    textBox1.Text = "function int Method(int a)\r\n{\r\n    return a;\r\n}";
            }
            else if ( chkSpaceInDeclarationEmptyArgumentList.IsSelected )
            {
                if ( chkSpaceInDeclarationEmptyArgumentList.Checked )
                    textBox1.Text = "function int Method( )\r\n{\r\n    return 3;\r\n}";
                else
                    textBox1.Text = "function int Method()\r\n{\r\n    return 3;\r\n}";
            }
            else if ( chkSpaceInMethodCallNameParenthesis.IsSelected )
            {
                if ( chkSpaceInMethodCallNameParenthesis.Checked )
                    textBox1.Text = "function int Method()\r\n{\r\n    return Abs (3);\r\n}";
                else
                    textBox1.Text = "function int Method()\r\n{\r\n    return Abs(3);\r\n}";
            }
            else if ( chkSpaceInCallArgumentListParentheses.IsSelected )
            {
                if ( chkSpaceInCallArgumentListParentheses.Checked )
                    textBox1.Text = "function int Method()\r\n{\r\n    return Abs( 3 );\r\n}";
                else
                    textBox1.Text = "function int Method()\r\n{\r\n    return Abs(3);\r\n}";
            }
            else if ( chkSpaceInCallEmptyArgumentList.IsSelected )
            {
                if ( chkSpaceInCallEmptyArgumentList.Checked )
                    textBox1.Text = "function double Method()\r\n{\r\n    return FRand( );\r\n}";
                else
                    textBox1.Text = "function double Method()\r\n{\r\n    return FRand();\r\n}";
            }
            else if ( chkSpaceAfterKeywordsInControlFlow.IsSelected )
            {
                if ( chkSpaceAfterKeywordsInControlFlow.Checked )
                    textBox1.Text = "function int Method()\r\n{\r\n    if (a > b)\r\n        return 0;\r\n    return 3;\r\n}";
                else
                    textBox1.Text = "function int Method()\r\n{\r\n    if(a > b)\r\n        return 0;\r\n    return 3;\r\n}";
            }
            else if ( chkSpaceInExpressionParentheses.IsSelected )
            {
                if ( chkSpaceInExpressionParentheses.Checked )
                    textBox1.Text = "function double Method(double a, double b)\r\n{\r\n    return a * ( b - a );\r\n}";
                else
                    textBox1.Text = "function double Method(double a, double b)\r\n{\r\n    return a * (b - a);\r\n}";
            }
            else if ( chkSpaceInTypeCastParentheses.IsSelected )
            {
                System.Diagnostics.Debug.Fail( "need preview text." );
                if ( chkSpaceInTypeCastParentheses.Checked )
                    textBox1.Text = "";
                else
                    textBox1.Text = "";
            }
            else if ( chkSpaceInControlFlowParentheses.IsSelected )
            {
                if ( chkSpaceInControlFlowParentheses.Checked )
                    textBox1.Text = "function int Method()\r\n{\r\n    if ( a > b )\r\n        return 0;\r\n    return 3;\r\n}";
                else
                    textBox1.Text = "function int Method()\r\n{\r\n    if (a > b)\r\n        return 0;\r\n    return 3;\r\n}";
            }
            else if ( chkSpaceAfterCast.IsSelected )
            {
                System.Diagnostics.Debug.Fail( "need preview text." );
                if ( chkSpaceAfterCast.Checked )
                    textBox1.Text = "";
                else
                    textBox1.Text = "";
            }
            else if ( chkIgnoreSpaceInDeclarations.IsSelected )
            {
                if ( chkIgnoreSpaceInDeclarations.Checked )
                    textBox1.Text = "var int    index;\r\nvar string text ;\r\n\r\nfunction Method()\r\n{\r\n    local int    i;\r\n    local string s;\r\n}";
                else
                    textBox1.Text = "var int index;\r\nvar string text;\r\n\r\nfunction Method()\r\n{\r\n    local int i;\r\n    local string s;\r\n}";
            }
            else if ( chkSpaceBeforeOpenBracket.IsSelected )
            {
                if ( chkSpaceBeforeOpenBracket.Checked )
                    textBox1.Text = "function int Method( array<int> list )\r\n{\r\n    return list [0];\r\n}";
                else
                    textBox1.Text = "function int Method( array<int> list )\r\n{\r\n    return list[0];\r\n}";
            }
            else if ( chkSpaceInEmptyBrackets.IsSelected )
            {
                System.Diagnostics.Debug.Fail( "need preview text." );
                if ( chkSpaceInEmptyBrackets.Checked )
                    textBox1.Text = "";
                else
                    textBox1.Text = "";
            }
            else if ( chkSpaceInBrackets.IsSelected )
            {
                System.Diagnostics.Debug.Fail( "need preview text." );
                if ( chkSpaceInBrackets.Checked )
                    textBox1.Text = "function int Method( array<int> list )\r\n{\r\n    return list[ 0 ];\r\n}";
                else
                    textBox1.Text = "function int Method( array<int> list )\r\n{\r\n    return list[0];\r\n}";
            }
            else if ( chkSpaceAfterColonInTypeDeclaration.IsSelected )
            {
                System.Diagnostics.Debug.Fail( "need preview text." );
                if ( chkSpaceAfterColonInTypeDeclaration.Checked )
                    textBox1.Text = "";
                else
                    textBox1.Text = "";
            }
            else if ( chkSpaceAfterComma.IsSelected )
            {
                if ( chkSpaceAfterComma.Checked )
                    textBox1.Text = "function int Sum(int a, int b)\r\n{\r\n    return a + b;\r\n}";
                else
                    textBox1.Text = "function int Sum(int a,int b)\r\n{\r\n    return a + b;\r\n}";
            }
            else if ( chkSpaceAfterDot.IsSelected )
            {
                System.Diagnostics.Debug.Fail( "need preview text." );
                if ( chkSpaceAfterDot.Checked )
                    textBox1.Text = "";
                else
                    textBox1.Text = "";
            }
            else if ( chkSpaceAfterSemiInForStatement.IsSelected )
            {
                if ( chkSpaceAfterSemiInForStatement.Checked )
                    textBox1.Text = "function Method()\r\n{\r\n    local int i;\r\n    for ( i = 0; i < 10; i++ )\r\n        OtherMethod();\r\n}";
                else
                    textBox1.Text = "function Method()\r\n{\r\n    local int i;\r\n    for ( i = 0;i < 10;i++ )\r\n        OtherMethod();\r\n}";
            }
            else if ( chkSpaceBeforeColonInTypeDeclaration.IsSelected )
            {
                System.Diagnostics.Debug.Fail( "need preview text." );
                if ( chkSpaceBeforeColonInTypeDeclaration.Checked )
                    textBox1.Text = "";
                else
                    textBox1.Text = "";
            }
            else if ( chkSpaceBeforeComma.IsSelected )
            {
                if ( chkSpaceBeforeComma.Checked )
                    textBox1.Text = "function int Sum(int a , int b)\r\n{\r\n    return a + b;\r\n}";
                else
                    textBox1.Text = "function int Sum(int a, int b)\r\n{\r\n    return a + b;\r\n}";
            }
            else if ( chkSpaceBeforeDot.IsSelected )
            {
                System.Diagnostics.Debug.Fail( "need preview text." );
                if ( chkSpaceBeforeDot.Checked )
                    textBox1.Text = "";
                else
                    textBox1.Text = "";
            }
            else if ( chkSpaceBeforeSemiInForStatement.IsSelected )
            {
                if ( chkSpaceBeforeSemiInForStatement.Checked )
                    textBox1.Text = "function Method()\r\n{\r\n    local int i;\r\n    for ( i = 0 ; i < 10 ; i++ )\r\n        OtherMethod();\r\n}";
                else
                    textBox1.Text = "function Method()\r\n{\r\n    local int i;\r\n    for ( i = 0; i < 10; i++ )\r\n        OtherMethod();\r\n}";
            }
            else if ( radOperatorInsertSpace.IsSelected )
            {
                textBox1.Text = "function int Method()\r\n{\r\n    return 1 + 2 * 3;\r\n}";
            }
            else if ( radOperatorIgnoreSpace.IsSelected )
            {
                textBox1.Text = "function int Method()\r\n{\r\n    return 1  +  2*3;\r\n}";
            }
            else if ( radOperatorRemoveSpace.IsSelected )
            {
                textBox1.Text = "function int Method()\r\n{\r\n    return 1+2*3;\r\n}";
            }
        }

        private void optionsTreeView1_AfterCheck( object sender, TreeViewEventArgs e )
        {
            UpdatePreviewText();
        }

        private void optionsTreeView1_AfterSelect( object sender, TreeViewEventArgs e )
        {
            UpdatePreviewText();
        }
    }
}
