namespace SpeakYourMind.UI
{
    partial class AddTwitterAccount
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
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblVerificationString = new System.Windows.Forms.Label();
            this.txtTwitterAccountName = new System.Windows.Forms.TextBox();
            this.txtTwitterVerificationString = new System.Windows.Forms.TextBox();
            this.btnSaveTwitterAccount = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(13, 90);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(78, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account Name";
            // 
            // lblVerificationString
            // 
            this.lblVerificationString.AutoSize = true;
            this.lblVerificationString.Location = new System.Drawing.Point(13, 121);
            this.lblVerificationString.Name = "lblVerificationString";
            this.lblVerificationString.Size = new System.Drawing.Size(89, 13);
            this.lblVerificationString.TabIndex = 1;
            this.lblVerificationString.Text = "Verification String";
            // 
            // txtTwitterAccountName
            // 
            this.txtTwitterAccountName.Location = new System.Drawing.Point(125, 90);
            this.txtTwitterAccountName.Name = "txtTwitterAccountName";
            this.txtTwitterAccountName.Size = new System.Drawing.Size(171, 20);
            this.txtTwitterAccountName.TabIndex = 2;
            this.txtTwitterAccountName.TextChanged += new System.EventHandler(this.txtTwitterAccountName_TextChanged);
            // 
            // txtTwitterVerificationString
            // 
            this.txtTwitterVerificationString.Location = new System.Drawing.Point(125, 121);
            this.txtTwitterVerificationString.Name = "txtTwitterVerificationString";
            this.txtTwitterVerificationString.Size = new System.Drawing.Size(171, 20);
            this.txtTwitterVerificationString.TabIndex = 3;
            this.txtTwitterVerificationString.TextChanged += new System.EventHandler(this.txtTwitterVerificationString_TextChanged);
            // 
            // btnSaveTwitterAccount
            // 
            this.btnSaveTwitterAccount.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveTwitterAccount.Location = new System.Drawing.Point(140, 157);
            this.btnSaveTwitterAccount.Name = "btnSaveTwitterAccount";
            this.btnSaveTwitterAccount.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTwitterAccount.TabIndex = 4;
            this.btnSaveTwitterAccount.Text = "Save";
            this.btnSaveTwitterAccount.UseVisualStyleBackColor = true;
            this.btnSaveTwitterAccount.Click += new System.EventHandler(this.btnSaveTwitterAccount_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(280, 61);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Specify an account name to identify the account. You will now be redirected to Tw" +
                "itter\'s authorization Page. Login using your account and copy the 7 digit Verifi" +
                "cation String to the below text box.";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(221, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddTwitterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 202);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaveTwitterAccount);
            this.Controls.Add(this.txtTwitterVerificationString);
            this.Controls.Add(this.txtTwitterAccountName);
            this.Controls.Add(this.lblVerificationString);
            this.Controls.Add(this.lblAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTwitterAccount";
            this.Text = "AddTwitterAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblVerificationString;
        private System.Windows.Forms.TextBox txtTwitterAccountName;
        private System.Windows.Forms.TextBox txtTwitterVerificationString;
        private System.Windows.Forms.Button btnSaveTwitterAccount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}