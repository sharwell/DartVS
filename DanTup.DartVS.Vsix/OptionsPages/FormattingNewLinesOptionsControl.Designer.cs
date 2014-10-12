namespace DanTup.DartVS.OptionsPages
{
    partial class FormattingNewLinesOptionsControl
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode( "Place open brace on new line for types" );
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode( "Place open brace on new line for methods" );
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode( "Place open brace on new line for control blocks" );
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode( "New line options for braces", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3} );
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode( "Place \"else\" on new line" );
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode( "New line options for keywords", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode5} );
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.optionsTreeView1 = new DanTup.DartVS.OptionsPages.OptionsTreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size( 328, 264 );
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // optionsTreeView1
            // 
            this.optionsTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsTreeView1.ImageIndex = 0;
            this.optionsTreeView1.Location = new System.Drawing.Point( 0, 0 );
            this.optionsTreeView1.Name = "optionsTreeView1";
            treeNode1.Name = "chkOpenBraceOnNewLineTypes";
            treeNode1.Text = "Place open brace on new line for types";
            treeNode2.Name = "chkOpenBraceOnNewLineMethods";
            treeNode2.Text = "Place open brace on new line for methods";
            treeNode3.Name = "chkOpenBraceOnNewLineControlBlocks";
            treeNode3.Text = "Place open brace on new line for control blocks";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "New line options for braces";
            treeNode5.Name = "chkElseOnNewLine";
            treeNode5.Text = "Place \"else\" on new line";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "Node1";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Text = "New line options for keywords";
            this.optionsTreeView1.Nodes.AddRange( new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6} );
            this.optionsTreeView1.SelectedImageIndex = 0;
            this.optionsTreeView1.Size = new System.Drawing.Size( 328, 132 );
            this.optionsTreeView1.TabIndex = 0;
            this.optionsTreeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler( this.optionsTreeView1_AfterCheck );
            this.optionsTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.optionsTreeView1_AfterSelect );
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font( "Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.textBox1.Location = new System.Drawing.Point( 0, 0 );
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size( 328, 128 );
            this.textBox1.TabIndex = 1;
            // 
            // FormattingNewLinesOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.splitContainer1 );
            this.Name = "FormattingNewLinesOptionsControl";
            this.Size = new System.Drawing.Size( 328, 264 );
            this.Resize += new System.EventHandler( this.FormattingNewLinesOptionsControl_Resize );
            this.splitContainer1.Panel1.ResumeLayout( false );
            this.splitContainer1.Panel2.ResumeLayout( false );
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private OptionsTreeView optionsTreeView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
