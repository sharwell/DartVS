namespace DanTup.DartVS.OptionsPages
{
    partial class FormattingWrappingOptionsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode( "Leave block on single line", 3, 3 );
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode( "Leave statements and member declarations on the same line", 3, 3 );
            this.optionsTreeView1 = new DanTup.DartVS.OptionsPages.OptionsTreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsTreeView1
            // 
            this.optionsTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsTreeView1.ImageIndex = 0;
            this.optionsTreeView1.Location = new System.Drawing.Point( 0, 0 );
            this.optionsTreeView1.Name = "optionsTreeView1";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "chkLeaveBlockOnSingleLine";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Leave block on single line";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "chkLeaveStatementsOnSameLine";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "Leave statements and member declarations on the same line";
            this.optionsTreeView1.Nodes.AddRange( new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2} );
            this.optionsTreeView1.SelectedImageIndex = 0;
            this.optionsTreeView1.Size = new System.Drawing.Size( 289, 108 );
            this.optionsTreeView1.TabIndex = 1;
            this.optionsTreeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler( this.optionsTreeView1_AfterCheck );
            this.optionsTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.optionsTreeView1_AfterSelect );
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point( 0, 0 );
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add( this.optionsTreeView1 );
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add( this.textBox1 );
            this.splitContainer1.Size = new System.Drawing.Size( 289, 219 );
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font( "Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.textBox1.Location = new System.Drawing.Point( 0, 0 );
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size( 289, 107 );
            this.textBox1.TabIndex = 1;
            // 
            // FormattingWrappingOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.splitContainer1 );
            this.Name = "FormattingWrappingOptionsControl";
            this.Size = new System.Drawing.Size( 289, 219 );
            this.Resize += new System.EventHandler( this.FormattingWrappingOptionsControl_Resize );
            this.splitContainer1.Panel1.ResumeLayout( false );
            this.splitContainer1.Panel2.ResumeLayout( false );
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private OptionsTreeView optionsTreeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
