using System;
using System.Windows.Forms;

namespace DanTup.DartVS.OptionsPages
{
    public partial class FormattingWrappingOptionsControl : UserControl
    {
        public FormattingWrappingOptionsControl( FormattingWrappingOptions optionsPage )
        {
            InitializeComponent();
            OptionsPage = optionsPage;
            ReloadSettings();
            optionsTreeView1.ExpandAll();
        }

        FormattingWrappingOptions OptionsPage
        {
            get;
            set;
        }

        TreeNode chkLeaveBlockOnSingleLine
        {
            get
            {
                return optionsTreeView1.Nodes["chkLeaveBlockOnSingleLine"];
            }
        }
        TreeNode chkLeaveStatementsOnSameLine
        {
            get
            {
                return optionsTreeView1.Nodes["chkLeaveStatementsOnSameLine"];
            }
        }

        public void ReloadSettings()
        {
            chkLeaveBlockOnSingleLine.Checked = OptionsPage.LeaveBlockOnSingleLine;
            chkLeaveStatementsOnSameLine.Checked = OptionsPage.LeaveStatementsOnSameLine;
        }

        public void ApplyChanges()
        {
            OptionsPage.LeaveBlockOnSingleLine = chkLeaveBlockOnSingleLine.Checked;
            OptionsPage.LeaveStatementsOnSameLine = chkLeaveStatementsOnSameLine.Checked;
        }

        private void FormattingWrappingOptionsControl_Resize( object sender, EventArgs e )
        {
            splitContainer1.SplitterDistance = Height / 2;
        }

        void UpdatePreviewText()
        {
            if ( chkLeaveBlockOnSingleLine.IsSelected )
            {
                if ( chkLeaveBlockOnSingleLine.Checked )
                    textBox1.Text = "public int Age { get { return age; } }";
                else
                    textBox1.Text = "public int Age\r\n{\r\n    get\r\n    {\r\n        return age;\r\n    }\r\n}";
            }
            else if ( chkLeaveStatementsOnSameLine.IsSelected )
            {
                if ( chkLeaveStatementsOnSameLine.Checked )
                    textBox1.Text = "i = 0; name = \"John\";";
                else
                    textBox1.Text = "i = 0;\r\nname = \"John\";";
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
