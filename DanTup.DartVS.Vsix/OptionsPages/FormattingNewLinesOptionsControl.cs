using System;
using System.Windows.Forms;

namespace DanTup.DartVS.OptionsPages
{
    public partial class FormattingNewLinesOptionsControl : UserControl
    {
        public FormattingNewLinesOptionsControl( FormattingNewLinesOptions optionsPage )
        {
            InitializeComponent();

            OptionsPage = optionsPage;
            ReloadSettings();
            optionsTreeView1.ExpandAll();
        }

        FormattingNewLinesOptions OptionsPage
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

        TreeNode chkOpenBraceOnNewLineTypes
        {
            get
            {
                return FindTreeNode( "chkOpenBraceOnNewLineTypes" );
            }
        }
        TreeNode chkOpenBraceOnNewLineMethods
        {
            get
            {
                return FindTreeNode( "chkOpenBraceOnNewLineMethods" );
            }
        }
        TreeNode chkOpenBraceOnNewLineControlBlocks
        {
            get
            {
                return FindTreeNode( "chkOpenBraceOnNewLineControlBlocks" );
            }
        }

        TreeNode chkElseOnNewLine
        {
            get
            {
                return FindTreeNode( "chkElseOnNewLine" );
            }
        }

        public void ReloadSettings()
        {
            // options for braces
            chkOpenBraceOnNewLineTypes.Checked = OptionsPage.OpenBraceOnNewLineTypes;
            chkOpenBraceOnNewLineMethods.Checked = OptionsPage.OpenBraceOnNewLineMethods;
            chkOpenBraceOnNewLineControlBlocks.Checked = OptionsPage.OpenBraceOnNewLineControlBlocks;

            // new line options for keywords
            chkElseOnNewLine.Checked = OptionsPage.ElseOnNewLine;
        }

        public void ApplyChanges()
        {
            // options for braces
            OptionsPage.OpenBraceOnNewLineTypes = chkOpenBraceOnNewLineTypes.Checked;
            OptionsPage.OpenBraceOnNewLineMethods = chkOpenBraceOnNewLineMethods.Checked;
            OptionsPage.OpenBraceOnNewLineControlBlocks = chkOpenBraceOnNewLineControlBlocks.Checked;

            // new line options for keywords
            OptionsPage.ElseOnNewLine = chkElseOnNewLine.Checked;
        }

        void FormattingNewLinesOptionsControl_Resize( object sender, EventArgs e )
        {
            splitContainer1.SplitterDistance = Height / 2;
        }

        void UpdatePreviewText()
        {
            if ( chkOpenBraceOnNewLineTypes.IsSelected )
            {
                if ( chkOpenBraceOnNewLineTypes.Checked )
                    textBox1.Text = "struct MyStruct\r\n{\r\n    // ...\r\n}";
                else
                    textBox1.Text = "struct MyStruct {\r\n    // ...\r\n}";
            }
            else if ( chkOpenBraceOnNewLineMethods.IsSelected )
            {
                if ( chkOpenBraceOnNewLineMethods.Checked )
                    textBox1.Text = "function int foo()\r\n{\r\n    return 3;\r\n}";
                else
                    textBox1.Text = "function int foo() {\r\n    return 3;\r\n}";
            }
            else if ( chkOpenBraceOnNewLineControlBlocks.IsSelected )
            {
                if ( chkOpenBraceOnNewLineControlBlocks.Checked )
                    textBox1.Text = "function int foo()\r\n{\r\n    if ( a > b )\r\n    {\r\n        return 0;\r\n    }\r\n    return 3;\r\n}";
                else
                    textBox1.Text = "function int foo()\r\n{\r\n    if ( a > b ) {\r\n        return 0;\r\n    }\r\n    return 3;\r\n}";
            }
            else if ( chkElseOnNewLine.IsSelected )
            {
                if ( chkElseOnNewLine.Checked )
                    textBox1.Text = "if ( a > b )\r\n{\r\n    return 0;\r\n}\r\nelse\r\n{\r\n    return 3;\r\n}";
                else
                    textBox1.Text = "if ( a > b )\r\n{\r\n    return 0;\r\n} else\r\n{\r\n    return 3;\r\n}";
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
