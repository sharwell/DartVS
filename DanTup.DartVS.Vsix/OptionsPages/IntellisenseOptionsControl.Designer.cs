﻿namespace DanTup.DartVS.OptionsPages
{
    partial class IntellisenseOptionsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCodeSnippetsInCompletion = new System.Windows.Forms.CheckBox();
            this.chkKeywordsInCompletion = new System.Windows.Forms.CheckBox();
            this.chkShowCompletionAfterTypedChar = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNewLineAfterEnter = new System.Windows.Forms.CheckBox();
            this.chkCommitOnSpace = new System.Windows.Forms.CheckBox();
            this.txtCompletionChars = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkRecentCompletions = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkCodeSnippetsInCompletion);
            this.groupBox1.Controls.Add(this.chkKeywordsInCompletion);
            this.groupBox1.Controls.Add(this.chkShowCompletionAfterTypedChar);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Completion Lists";
            // 
            // chkCodeSnippetsInCompletion
            // 
            this.chkCodeSnippetsInCompletion.AutoSize = true;
            this.chkCodeSnippetsInCompletion.Location = new System.Drawing.Point(41, 67);
            this.chkCodeSnippetsInCompletion.Name = "chkCodeSnippetsInCompletion";
            this.chkCodeSnippetsInCompletion.Size = new System.Drawing.Size(207, 17);
            this.chkCodeSnippetsInCompletion.TabIndex = 2;
            this.chkCodeSnippetsInCompletion.Text = "Place code snippets in completion lists";
            this.chkCodeSnippetsInCompletion.UseVisualStyleBackColor = true;
            // 
            // chkKeywordsInCompletion
            // 
            this.chkKeywordsInCompletion.AutoSize = true;
            this.chkKeywordsInCompletion.Location = new System.Drawing.Point(41, 42);
            this.chkKeywordsInCompletion.Name = "chkKeywordsInCompletion";
            this.chkKeywordsInCompletion.Size = new System.Drawing.Size(186, 17);
            this.chkKeywordsInCompletion.TabIndex = 1;
            this.chkKeywordsInCompletion.Text = "Place keywords in completion lists";
            this.chkKeywordsInCompletion.UseVisualStyleBackColor = true;
            // 
            // chkShowCompletionAfterTypedChar
            // 
            this.chkShowCompletionAfterTypedChar.AutoSize = true;
            this.chkShowCompletionAfterTypedChar.Location = new System.Drawing.Point(26, 19);
            this.chkShowCompletionAfterTypedChar.Name = "chkShowCompletionAfterTypedChar";
            this.chkShowCompletionAfterTypedChar.Size = new System.Drawing.Size(242, 17);
            this.chkShowCompletionAfterTypedChar.TabIndex = 0;
            this.chkShowCompletionAfterTypedChar.Text = "Show completion list after a character is typed";
            this.chkShowCompletionAfterTypedChar.UseVisualStyleBackColor = true;
            this.chkShowCompletionAfterTypedChar.CheckedChanged += new System.EventHandler(this.chkShowCompletionAfterTypedChar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkNewLineAfterEnter);
            this.groupBox2.Controls.Add(this.chkCommitOnSpace);
            this.groupBox2.Controls.Add(this.txtCompletionChars);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection In Completion List";
            // 
            // chkNewLineAfterEnter
            // 
            this.chkNewLineAfterEnter.AutoSize = true;
            this.chkNewLineAfterEnter.BackColor = System.Drawing.Color.Transparent;
            this.chkNewLineAfterEnter.Location = new System.Drawing.Point(26, 88);
            this.chkNewLineAfterEnter.Name = "chkNewLineAfterEnter";
            this.chkNewLineAfterEnter.Size = new System.Drawing.Size(308, 17);
            this.chkNewLineAfterEnter.TabIndex = 3;
            this.chkNewLineAfterEnter.Text = "Add new line on commit with enter at end of fully typed word";
            this.chkNewLineAfterEnter.UseVisualStyleBackColor = false;
            // 
            // chkCommitOnSpace
            // 
            this.chkCommitOnSpace.AutoSize = true;
            this.chkCommitOnSpace.Location = new System.Drawing.Point(26, 64);
            this.chkCommitOnSpace.Name = "chkCommitOnSpace";
            this.chkCommitOnSpace.Size = new System.Drawing.Size(199, 17);
            this.chkCommitOnSpace.TabIndex = 2;
            this.chkCommitOnSpace.Text = "Committed by pressing the space bar";
            this.chkCommitOnSpace.UseVisualStyleBackColor = true;
            // 
            // txtCompletionChars
            // 
            this.txtCompletionChars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompletionChars.Location = new System.Drawing.Point(26, 37);
            this.txtCompletionChars.Name = "txtCompletionChars";
            this.txtCompletionChars.Size = new System.Drawing.Size(319, 20);
            this.txtCompletionChars.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Committed by typing the following characters:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chkRecentCompletions);
            this.groupBox3.Location = new System.Drawing.Point(3, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IntelliSense Member Selection";
            // 
            // chkRecentCompletions
            // 
            this.chkRecentCompletions.AutoSize = true;
            this.chkRecentCompletions.Location = new System.Drawing.Point(26, 20);
            this.chkRecentCompletions.Name = "chkRecentCompletions";
            this.chkRecentCompletions.Size = new System.Drawing.Size(270, 17);
            this.chkRecentCompletions.TabIndex = 0;
            this.chkRecentCompletions.Text = "IntelliSense pre-selects most recently used members";
            this.chkRecentCompletions.UseVisualStyleBackColor = true;
            // 
            // AntlrIntellisenseOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(338, 292);
            this.Name = "AntlrIntellisenseOptionsControl";
            this.Size = new System.Drawing.Size(357, 332);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCodeSnippetsInCompletion;
        private System.Windows.Forms.CheckBox chkKeywordsInCompletion;
        private System.Windows.Forms.CheckBox chkShowCompletionAfterTypedChar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkNewLineAfterEnter;
        private System.Windows.Forms.CheckBox chkCommitOnSpace;
        private System.Windows.Forms.TextBox txtCompletionChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRecentCompletions;
    }
}
