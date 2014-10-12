namespace DanTup.DartVS.OptionsPages
{
    partial class FormattingIndentationOptionsControl
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode( "Indent block contents", 3, 3 );
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode( "Indent open and close braces", 3, 3 );
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode( "Indent case contents", 3, 3 );
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode( "Indent case labels", 3, 3 );
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode( "Place goto labels in leftmost column" );
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode( "Place goto labels one indent less than current" );
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode( "Indent labels normally" );
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode( "Label indentation", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7} );
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.optionsTreeView1 = new DanTup.DartVS.OptionsPages.OptionsTreeView();
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
            this.splitContainer1.Size = new System.Drawing.Size( 391, 251 );
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font( "Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.textBox1.Location = new System.Drawing.Point( 0, 0 );
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size( 391, 117 );
            this.textBox1.TabIndex = 0;
            // 
            // optionsTreeView1
            // 
            this.optionsTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsTreeView1.ImageIndex = 0;
            this.optionsTreeView1.Location = new System.Drawing.Point( 0, 0 );
            this.optionsTreeView1.Name = "optionsTreeView1";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "chkIndentBlockContents";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Indent block contents";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "chkIndentOpenAndCloseBraces";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "Indent open and close braces";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "chkIndentCaseContents";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "Indent case contents";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "chkIndentCaseLabels";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Indent case labels";
            treeNode5.ImageIndex = 8;
            treeNode5.Name = "radLabelsLeftmost";
            treeNode5.Text = "Place goto labels in leftmost column";
            treeNode6.ImageIndex = 8;
            treeNode6.Name = "radLabelsOneLeft";
            treeNode6.Text = "Place goto labels one indent less than current";
            treeNode7.ImageIndex = 8;
            treeNode7.Name = "radLabelsNormal";
            treeNode7.Text = "Indent labels normally";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "Node4";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Label indentation";
            this.optionsTreeView1.Nodes.AddRange( new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode8} );
            this.optionsTreeView1.SelectedImageIndex = 0;
            this.optionsTreeView1.Size = new System.Drawing.Size( 391, 130 );
            this.optionsTreeView1.TabIndex = 0;
            this.optionsTreeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler( this.optionsTreeView1_AfterCheck );
            this.optionsTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.optionsTreeView1_AfterSelect );
            // 
            // FormattingIndentationOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.splitContainer1 );
            this.Name = "FormattingIndentationOptionsControl";
            this.Size = new System.Drawing.Size( 391, 251 );
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
