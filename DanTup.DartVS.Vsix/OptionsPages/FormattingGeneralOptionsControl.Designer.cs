namespace DanTup.DartVS.OptionsPages
{
    partial class FormattingGeneralOptionsControl
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
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFormatOnPaste = new System.Windows.Forms.CheckBox();
            this.chkFormatOnCloseBrace = new System.Windows.Forms.CheckBox();
            this.chkFormatOnSemi = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkOutlineRegions = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkFormatOnPaste);
            this.groupBox1.Controls.Add(this.chkFormatOnCloseBrace);
            this.groupBox1.Controls.Add(this.chkFormatOnSemi);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // chkFormatOnPaste
            // 
            this.chkFormatOnPaste.AutoSize = true;
            this.chkFormatOnPaste.Location = new System.Drawing.Point(27, 66);
            this.chkFormatOnPaste.Name = "chkFormatOnPaste";
            this.chkFormatOnPaste.Size = new System.Drawing.Size(164, 17);
            this.chkFormatOnPaste.TabIndex = 2;
            this.chkFormatOnPaste.Text = "Automatically format on &paste";
            this.chkFormatOnPaste.UseVisualStyleBackColor = true;
            // 
            // chkFormatOnCloseBrace
            // 
            this.chkFormatOnCloseBrace.AutoSize = true;
            this.chkFormatOnCloseBrace.Location = new System.Drawing.Point(27, 42);
            this.chkFormatOnCloseBrace.Name = "chkFormatOnCloseBrace";
            this.chkFormatOnCloseBrace.Size = new System.Drawing.Size(223, 17);
            this.chkFormatOnCloseBrace.TabIndex = 1;
            this.chkFormatOnCloseBrace.Text = "Automatically format completed &block on }";
            this.chkFormatOnCloseBrace.UseVisualStyleBackColor = true;
            // 
            // chkFormatOnSemi
            // 
            this.chkFormatOnSemi.AutoSize = true;
            this.chkFormatOnSemi.Location = new System.Drawing.Point(27, 19);
            this.chkFormatOnSemi.Name = "chkFormatOnSemi";
            this.chkFormatOnSemi.Size = new System.Drawing.Size(242, 17);
            this.chkFormatOnSemi.TabIndex = 0;
            this.chkFormatOnSemi.Text = "Automatically format completed &statement on ;";
            this.chkFormatOnSemi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.chkOutlineRegions);
            this.groupBox2.Location = new System.Drawing.Point(3, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Experimental";
            // 
            // chkOutlineRegions
            // 
            this.chkOutlineRegions.AutoSize = true;
            this.chkOutlineRegions.Location = new System.Drawing.Point(27, 19);
            this.chkOutlineRegions.Name = "chkOutlineRegions";
            this.chkOutlineRegions.Size = new System.Drawing.Size(146, 17);
            this.chkOutlineRegions.TabIndex = 0;
            this.chkOutlineRegions.Text = "Show auto-format regions";
            this.chkOutlineRegions.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(43, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(243, 33);
            label1.TabIndex = 1;
            label1.Text = "Enables an experimental mode for alpha testing of auto-format region detection.";
            // 
            // FormattingGeneralOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormattingGeneralOptionsControl";
            this.Size = new System.Drawing.Size(298, 199);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFormatOnPaste;
        private System.Windows.Forms.CheckBox chkFormatOnCloseBrace;
        private System.Windows.Forms.CheckBox chkFormatOnSemi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkOutlineRegions;
    }
}
