namespace DanTup.DartVS.OptionsPages
{
    partial class AdvancedOptionsControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLiveErrors = new System.Windows.Forms.CheckBox();
            this.chkUnderlineErrors = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAvoidBadTabs = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSupportsDotDotOperator = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkLiveErrors);
            this.groupBox1.Controls.Add(this.chkUnderlineErrors);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editor Help";
            // 
            // chkLiveErrors
            // 
            this.chkLiveErrors.AutoSize = true;
            this.chkLiveErrors.Location = new System.Drawing.Point(23, 42);
            this.chkLiveErrors.Name = "chkLiveErrors";
            this.chkLiveErrors.Size = new System.Drawing.Size(146, 17);
            this.chkLiveErrors.TabIndex = 1;
            this.chkLiveErrors.Text = "Show &live semantic errors";
            this.chkLiveErrors.UseVisualStyleBackColor = true;
            // 
            // chkUnderlineErrors
            // 
            this.chkUnderlineErrors.AutoSize = true;
            this.chkUnderlineErrors.Location = new System.Drawing.Point(23, 19);
            this.chkUnderlineErrors.Name = "chkUnderlineErrors";
            this.chkUnderlineErrors.Size = new System.Drawing.Size(158, 17);
            this.chkUnderlineErrors.TabIndex = 0;
            this.chkUnderlineErrors.Text = "&Underline errors in the editor";
            this.chkUnderlineErrors.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAvoidBadTabs);
            this.groupBox2.Location = new System.Drawing.Point(3, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced Indentation";
            // 
            // chkAvoidBadTabs
            // 
            this.chkAvoidBadTabs.AutoSize = true;
            this.chkAvoidBadTabs.Location = new System.Drawing.Point(23, 20);
            this.chkAvoidBadTabs.Name = "chkAvoidBadTabs";
            this.chkAvoidBadTabs.Size = new System.Drawing.Size(226, 17);
            this.chkAvoidBadTabs.TabIndex = 0;
            this.chkAvoidBadTabs.Text = "Avoid hard tabs within text (recommended)";
            this.chkAvoidBadTabs.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSupportsDotDotOperator);
            this.groupBox3.Location = new System.Drawing.Point(3, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Advanced Operators";
            // 
            // chkSupportsDotDotOperator
            // 
            this.chkSupportsDotDotOperator.AutoSize = true;
            this.chkSupportsDotDotOperator.Location = new System.Drawing.Point(23, 20);
            this.chkSupportsDotDotOperator.Name = "chkSupportsDotDotOperator";
            this.chkSupportsDotDotOperator.Size = new System.Drawing.Size(215, 17);
            this.chkSupportsDotDotOperator.TabIndex = 0;
            this.chkSupportsDotDotOperator.Text = "Engine supports \'..\' for member selection";
            this.chkSupportsDotDotOperator.UseVisualStyleBackColor = true;
            // 
            // AdvancedOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdvancedOptionsControl";
            this.Size = new System.Drawing.Size(300, 268);
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
        private System.Windows.Forms.CheckBox chkLiveErrors;
        private System.Windows.Forms.CheckBox chkUnderlineErrors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAvoidBadTabs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSupportsDotDotOperator;
    }
}
