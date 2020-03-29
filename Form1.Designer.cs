namespace PalindromeChecker
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtPalindromeInput = new System.Windows.Forms.TextBox();
            this.BtnPalindromeCheck = new System.Windows.Forms.Button();
            this.LblPalindromeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPalindromeInput
            // 
            this.TxtPalindromeInput.Location = new System.Drawing.Point(13, 13);
            this.TxtPalindromeInput.Name = "TxtPalindromeInput";
            this.TxtPalindromeInput.Size = new System.Drawing.Size(413, 20);
            this.TxtPalindromeInput.TabIndex = 0;
            // 
            // BtnPalindromeCheck
            // 
            this.BtnPalindromeCheck.Location = new System.Drawing.Point(12, 39);
            this.BtnPalindromeCheck.Name = "BtnPalindromeCheck";
            this.BtnPalindromeCheck.Size = new System.Drawing.Size(413, 23);
            this.BtnPalindromeCheck.TabIndex = 1;
            this.BtnPalindromeCheck.Text = "Check";
            this.BtnPalindromeCheck.UseVisualStyleBackColor = true;
            this.BtnPalindromeCheck.Click += new System.EventHandler(this.BtnPalindromeCheck_Click);
            // 
            // LblPalindromeOutput
            // 
            this.LblPalindromeOutput.Location = new System.Drawing.Point(12, 76);
            this.LblPalindromeOutput.Name = "LblPalindromeOutput";
            this.LblPalindromeOutput.Size = new System.Drawing.Size(414, 731);
            this.LblPalindromeOutput.TabIndex = 2;
            this.LblPalindromeOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 816);
            this.Controls.Add(this.LblPalindromeOutput);
            this.Controls.Add(this.BtnPalindromeCheck);
            this.Controls.Add(this.TxtPalindromeInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPalindromeInput;
        private System.Windows.Forms.Button BtnPalindromeCheck;
        private System.Windows.Forms.Label LblPalindromeOutput;
    }
}

