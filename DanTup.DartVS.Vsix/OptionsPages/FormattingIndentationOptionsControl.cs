using System.Windows.Forms;

namespace DanTup.DartVS.OptionsPages
{
    public partial class FormattingIndentationOptionsControl : UserControl
    {
        public FormattingIndentationOptionsControl( FormattingIndentationOptions optionsPage )
        {
            InitializeComponent();
            OptionsPage = optionsPage;
            ReloadSettings();
            optionsTreeView1.ExpandAll();
        }

        FormattingIndentationOptions OptionsPage
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

        TreeNode chkIndentBlockContents
        {
            get
            {
                return FindTreeNode( "chkIndentBlockContents" );
            }
        }
        TreeNode chkIndentOpenAndCloseBraces
        {
            get
            {
                return FindTreeNode( "chkIndentOpenAndCloseBraces" );
            }
        }
        TreeNode chkIndentCaseContents
        {
            get
            {
                return FindTreeNode( "chkIndentCaseContents" );
            }
        }
        TreeNode chkIndentCaseLabels
        {
            get
            {
                return FindTreeNode( "chkIndentCaseLabels" );
            }
        }

        TreeNode radLabelsLeftmost
        {
            get
            {
                return FindTreeNode( "radLabelsLeftmost" );
            }
        }
        TreeNode radLabelsOneLeft
        {
            get
            {
                return FindTreeNode( "radLabelsOneLeft" );
            }
        }
        TreeNode radLabelsNormal
        {
            get
            {
                return FindTreeNode( "radLabelsNormal" );
            }
        }

        public void ReloadSettings()
        {
            chkIndentBlockContents.Checked = OptionsPage.IndentBlockContents;
            chkIndentOpenAndCloseBraces.Checked = OptionsPage.IndentOpenAndCloseBraces;
            chkIndentCaseContents.Checked = OptionsPage.IndentCaseContents;
            chkIndentCaseLabels.Checked = OptionsPage.IndentCaseLabels;

            radLabelsLeftmost.Checked = ( OptionsPage.LabelIndentation == LabelIndentationMode.LeftmostColumn );
            radLabelsOneLeft.Checked = ( OptionsPage.LabelIndentation == LabelIndentationMode.OneIndentLess );
            radLabelsNormal.Checked = ( OptionsPage.LabelIndentation == LabelIndentationMode.IndentNormally );
        }

        public void ApplyChanges()
        {
            OptionsPage.IndentBlockContents = chkIndentBlockContents.Checked;
            OptionsPage.IndentOpenAndCloseBraces = chkIndentOpenAndCloseBraces.Checked;
            OptionsPage.IndentCaseContents = chkIndentCaseContents.Checked;
            OptionsPage.IndentCaseLabels = chkIndentCaseLabels.Checked;

            if ( radLabelsLeftmost.Checked )
                OptionsPage.LabelIndentation = LabelIndentationMode.LeftmostColumn;
            else if ( radLabelsOneLeft.Checked )
                OptionsPage.LabelIndentation = LabelIndentationMode.OneIndentLess;
            else if ( radLabelsNormal.Checked )
                OptionsPage.LabelIndentation = LabelIndentationMode.IndentNormally;
        }

        void UpdatePreviewText()
        {
            if ( chkIndentBlockContents.IsSelected )
            {
                if ( chkIndentBlockContents.Checked )
                    textBox1.Text = "function int Method()\r\n{\r\n    return 3;\r\n}";
                else
                    textBox1.Text = "function int Method()\r\n{\r\nreturn 3;\r\n}";
            }
            else if ( chkIndentOpenAndCloseBraces.IsSelected )
            {
                if ( chkIndentOpenAndCloseBraces.Checked )
                    textBox1.Text = "function int Method()\r\n    {\r\n    return 3;\r\n    }";
                else
                    textBox1.Text = "function int Method()\r\n{\r\n    return 3;\r\n}";
            }
            else if ( chkIndentCaseContents.IsSelected )
            {
                if ( chkIndentCaseContents.Checked )
                    textBox1.Text = "switch ( name )\r\n{\r\ncase 'Something':\r\n    break;\r\n}";
                else
                    textBox1.Text = "switch ( name )\r\n{\r\ncase 'Something':\r\nbreak;\r\n}";
            }
            else if ( chkIndentCaseLabels.IsSelected )
            {
                if ( chkIndentCaseLabels.Checked )
                    textBox1.Text = "switch ( name )\r\n{\r\n    case 'Something':\r\n        break;\r\n}";
                else
                    textBox1.Text = "switch ( name )\r\n{\r\ncase 'Something':\r\n    break;\r\n}";
            }
            else if ( radLabelsLeftmost.IsSelected )
            {
                textBox1.Text = "state MyState\r\n{\r\nBegin:\r\n    Foo();\r\n}";
            }
            else if ( radLabelsOneLeft.IsSelected )
            {
                textBox1.Text = "state MyState\r\n{\r\nBegin:\r\n    Foo();\r\n}";
            }
            else if ( radLabelsNormal.IsSelected )
            {
                textBox1.Text = "state MyState\r\n{\r\n    Begin:\r\n    Foo();\r\n}";
            }
        }

        void optionsTreeView1_AfterSelect( object sender, TreeViewEventArgs e )
        {
            UpdatePreviewText();
        }

        void optionsTreeView1_AfterCheck( object sender, TreeViewEventArgs e )
        {
            UpdatePreviewText();
        }
    }
}
