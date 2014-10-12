namespace DanTup.DartVS.OptionsPages
{
    partial class FormattingSpacingOptionsControl
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode( "Insert space between method name and its opening parentheses" );
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode( "Insert space within argument list parentheses" );
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode( "Insert space within empty argument list parentheses" );
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode( "Set spacing for method declarations", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3} );
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode( "Insert space between method name and its opening parentheses" );
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode( "Insert space within argument list parentheses" );
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode( "Insert space within empty argument list parentheses" );
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode( "Set spacing for method calls", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7} );
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode( "Insert space after keywords in control flow statements" );
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode( "Insert space within parentheses of expressions" );
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode( "Insert space within parentheses of type casts" );
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode( "Insert spaces inside parentheses for control flow statements" );
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode( "Insert space after cast" );
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode( "Ignore spaces in declaration statements" );
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode( "Set other spacing options", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14} );
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode( "Insert space before open square bracket", 3, 3 );
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode( "Insert space within empty square brackets", 3, 3 );
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode( "Insert spaces within square brackets", 3, 3 );
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode( "Set spacing for brackets", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18} );
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode( "Insert space after colon for base or interface in type declaration" );
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode( "Insert space after comma" );
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode( "Insert space after dot" );
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode( "Insert space after semicolon in \"for\" statement" );
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode( "Insert space before colon for base or interface in type declaration" );
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode( "Insert space before comma" );
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode( "Insert space before dot" );
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode( "Insert space before semicolon in \"for\" statement" );
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode( "Set spacing for delimiters", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27} );
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode( "Insert space before and after binary operators" );
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode( "Ignore spaces around binary operators" );
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode( "Remove spaces before and after binary operators" );
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode( "Set spacing for operators", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31} );
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
            this.splitContainer1.Size = new System.Drawing.Size( 241, 221 );
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 0;
            // 
            // optionsTreeView1
            // 
            this.optionsTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsTreeView1.ImageIndex = 0;
            this.optionsTreeView1.Location = new System.Drawing.Point( 0, 0 );
            this.optionsTreeView1.Name = "optionsTreeView1";
            treeNode1.Name = "chkSpaceInMethodDeclarationNameParenthesis";
            treeNode1.Text = "Insert space between method name and its opening parentheses";
            treeNode2.Name = "chkSpaceInDeclarationArgumentListParentheses";
            treeNode2.Text = "Insert space within argument list parentheses";
            treeNode3.Name = "chkSpaceInDeclarationEmptyArgumentList";
            treeNode3.Text = "Insert space within empty argument list parentheses";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Set spacing for method declarations";
            treeNode5.Name = "chkSpaceInMethodCallNameParenthesis";
            treeNode5.Text = "Insert space between method name and its opening parentheses";
            treeNode6.Name = "chkSpaceInCallArgumentListParentheses";
            treeNode6.Text = "Insert space within argument list parentheses";
            treeNode7.Name = "chkSpaceInCallEmptyArgumentList";
            treeNode7.Text = "Insert space within empty argument list parentheses";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "Node1";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Set spacing for method calls";
            treeNode9.Name = "chkSpaceAfterKeywordsInControlFlow";
            treeNode9.Text = "Insert space after keywords in control flow statements";
            treeNode10.Name = "chkSpaceInExpressionParentheses";
            treeNode10.Text = "Insert space within parentheses of expressions";
            treeNode11.Name = "chkSpaceInTypeCastParentheses";
            treeNode11.Text = "Insert space within parentheses of type casts";
            treeNode12.Name = "chkSpaceInControlFlowParentheses";
            treeNode12.Text = "Insert spaces inside parentheses for control flow statements";
            treeNode13.Name = "chkSpaceAfterCast";
            treeNode13.Text = "Insert space after cast";
            treeNode14.Name = "chkIgnoreSpaceInDeclarations";
            treeNode14.Text = "Ignore spaces in declaration statements";
            treeNode15.ImageIndex = 0;
            treeNode15.Name = "Node2";
            treeNode15.SelectedImageIndex = 0;
            treeNode15.Text = "Set other spacing options";
            treeNode16.ImageIndex = 3;
            treeNode16.Name = "chkSpaceBeforeOpenBracket";
            treeNode16.SelectedImageIndex = 3;
            treeNode16.Text = "Insert space before open square bracket";
            treeNode17.ImageIndex = 3;
            treeNode17.Name = "chkSpaceInEmptyBrackets";
            treeNode17.SelectedImageIndex = 3;
            treeNode17.Text = "Insert space within empty square brackets";
            treeNode18.ImageIndex = 3;
            treeNode18.Name = "chkSpaceInBrackets";
            treeNode18.SelectedImageIndex = 3;
            treeNode18.Text = "Insert spaces within square brackets";
            treeNode19.ImageIndex = 0;
            treeNode19.Name = "Node3";
            treeNode19.SelectedImageIndex = 0;
            treeNode19.Text = "Set spacing for brackets";
            treeNode20.Name = "chkSpaceAfterColonInTypeDeclaration";
            treeNode20.Text = "Insert space after colon for base or interface in type declaration";
            treeNode21.Name = "chkSpaceAfterComma";
            treeNode21.Text = "Insert space after comma";
            treeNode22.Name = "chkSpaceAfterDot";
            treeNode22.Text = "Insert space after dot";
            treeNode23.Name = "chkSpaceAfterSemiInForStatement";
            treeNode23.Text = "Insert space after semicolon in \"for\" statement";
            treeNode24.Name = "chkSpaceBeforeColonInTypeDeclaration";
            treeNode24.Text = "Insert space before colon for base or interface in type declaration";
            treeNode25.Name = "chkSpaceBeforeComma";
            treeNode25.Text = "Insert space before comma";
            treeNode26.Name = "chkSpaceBeforeDot";
            treeNode26.Text = "Insert space before dot";
            treeNode27.Name = "chkSpaceBeforeSemiInForStatement";
            treeNode27.Text = "Insert space before semicolon in \"for\" statement";
            treeNode28.ImageIndex = 0;
            treeNode28.Name = "Node4";
            treeNode28.SelectedImageIndex = 0;
            treeNode28.Text = "Set spacing for delimiters";
            treeNode29.ImageIndex = 8;
            treeNode29.Name = "radOperatorInsertSpace";
            treeNode29.Text = "Insert space before and after binary operators";
            treeNode30.ImageIndex = 8;
            treeNode30.Name = "radOperatorIgnoreSpace";
            treeNode30.Text = "Ignore spaces around binary operators";
            treeNode31.ImageIndex = 8;
            treeNode31.Name = "radOperatorRemoveSpace";
            treeNode31.Text = "Remove spaces before and after binary operators";
            treeNode32.ImageIndex = 0;
            treeNode32.Name = "Node5";
            treeNode32.SelectedImageIndex = 0;
            treeNode32.Text = "Set spacing for operators";
            this.optionsTreeView1.Nodes.AddRange( new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode15,
            treeNode19,
            treeNode28,
            treeNode32} );
            this.optionsTreeView1.SelectedImageIndex = 0;
            this.optionsTreeView1.Size = new System.Drawing.Size( 241, 109 );
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
            this.textBox1.Size = new System.Drawing.Size( 241, 108 );
            this.textBox1.TabIndex = 0;
            // 
            // FormattingSpacingOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.splitContainer1 );
            this.Name = "FormattingSpacingOptionsControl";
            this.Size = new System.Drawing.Size( 241, 221 );
            this.Resize += new System.EventHandler( this.FormattingSpacingOptionsControl_Resize );
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
