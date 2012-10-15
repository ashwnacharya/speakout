namespace SpeakYourMind.UI
{
    partial class PostForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbTwitter = new System.Windows.Forms.TabPage();
            this.btnDeleteTwitterAccount = new System.Windows.Forms.Button();
            this.btnAddTwitterAccount = new System.Windows.Forms.Button();
            this.lbxTwitterAccounts = new System.Windows.Forms.ListBox();
            this.tbPost = new System.Windows.Forms.TabPage();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblImgurStatus = new System.Windows.Forms.Label();
            this.tbTwitter.SuspendLayout();
            this.tbPost.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "facebook-icon.png");
            this.imageList1.Images.SetKeyName(1, "Twitter-Icon.png");
            this.imageList1.Images.SetKeyName(2, "Google Talk.png");
            this.imageList1.Images.SetKeyName(3, "thought-bubble.png");
            // 
            // tbTwitter
            // 
            this.tbTwitter.Controls.Add(this.btnDeleteTwitterAccount);
            this.tbTwitter.Controls.Add(this.btnAddTwitterAccount);
            this.tbTwitter.Controls.Add(this.lbxTwitterAccounts);
            this.tbTwitter.ImageIndex = 1;
            this.tbTwitter.Location = new System.Drawing.Point(4, 23);
            this.tbTwitter.Name = "tbTwitter";
            this.tbTwitter.Padding = new System.Windows.Forms.Padding(3);
            this.tbTwitter.Size = new System.Drawing.Size(334, 146);
            this.tbTwitter.TabIndex = 2;
            this.tbTwitter.Text = "Twitter";
            this.tbTwitter.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTwitterAccount
            // 
            this.btnDeleteTwitterAccount.Location = new System.Drawing.Point(192, 50);
            this.btnDeleteTwitterAccount.Name = "btnDeleteTwitterAccount";
            this.btnDeleteTwitterAccount.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteTwitterAccount.TabIndex = 2;
            this.btnDeleteTwitterAccount.Text = "Delete Account";
            this.btnDeleteTwitterAccount.UseVisualStyleBackColor = true;
            this.btnDeleteTwitterAccount.Click += new System.EventHandler(this.btnDeleteTwitterAccount_Click);
            // 
            // btnAddTwitterAccount
            // 
            this.btnAddTwitterAccount.Location = new System.Drawing.Point(192, 21);
            this.btnAddTwitterAccount.Name = "btnAddTwitterAccount";
            this.btnAddTwitterAccount.Size = new System.Drawing.Size(119, 23);
            this.btnAddTwitterAccount.TabIndex = 1;
            this.btnAddTwitterAccount.Text = "Add Account";
            this.btnAddTwitterAccount.UseVisualStyleBackColor = true;
            this.btnAddTwitterAccount.Click += new System.EventHandler(this.btnAddTwitterAccount_Click);
            // 
            // lbxTwitterAccounts
            // 
            this.lbxTwitterAccounts.FormattingEnabled = true;
            this.lbxTwitterAccounts.Location = new System.Drawing.Point(8, 21);
            this.lbxTwitterAccounts.Name = "lbxTwitterAccounts";
            this.lbxTwitterAccounts.Size = new System.Drawing.Size(158, 186);
            this.lbxTwitterAccounts.TabIndex = 0;
            this.lbxTwitterAccounts.SelectedIndexChanged += new System.EventHandler(this.lbxTwitterAccounts_SelectedIndexChanged);
            // 
            // tbPost
            // 
            this.tbPost.Controls.Add(this.lblImgurStatus);
            this.tbPost.Controls.Add(this.txtImage);
            this.tbPost.Controls.Add(this.btnUploadImage);
            this.tbPost.Controls.Add(this.lblCharCount);
            this.tbPost.Controls.Add(this.txtPost);
            this.tbPost.Controls.Add(this.btnPost);
            this.tbPost.Location = new System.Drawing.Point(4, 23);
            this.tbPost.Name = "tbPost";
            this.tbPost.Padding = new System.Windows.Forms.Padding(3);
            this.tbPost.Size = new System.Drawing.Size(334, 166);
            this.tbPost.TabIndex = 0;
            this.tbPost.Text = "Post!";
            this.tbPost.UseVisualStyleBackColor = true;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(11, 9);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(235, 20);
            this.txtImage.TabIndex = 4;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(251, 6);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(77, 23);
            this.btnUploadImage.TabIndex = 3;
            this.btnUploadImage.Text = "Add Photo";
            this.btnUploadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // lblCharCount
            // 
            this.lblCharCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(8, 140);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(102, 13);
            this.lblCharCount.TabIndex = 2;
            this.lblCharCount.Text = "Character Count = 0";
            // 
            // txtPost
            // 
            this.txtPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPost.Location = new System.Drawing.Point(8, 58);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(322, 71);
            this.txtPost.TabIndex = 0;
            this.txtPost.TextChanged += new System.EventHandler(this.txtPost_TextChanged);
            // 
            // btnPost
            // 
            this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPost.Location = new System.Drawing.Point(251, 135);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "Post!";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPost);
            this.tabControl1.Controls.Add(this.tbTwitter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(342, 193);
            this.tabControl1.TabIndex = 2;
            // 
            // lblImgurStatus
            // 
            this.lblImgurStatus.AutoSize = true;
            this.lblImgurStatus.Location = new System.Drawing.Point(11, 36);
            this.lblImgurStatus.Name = "lblImgurStatus";
            this.lblImgurStatus.Size = new System.Drawing.Size(0, 13);
            this.lblImgurStatus.TabIndex = 5;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(342, 193);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "PostForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Speak Your Mind!";
            this.tbTwitter.ResumeLayout(false);
            this.tbPost.ResumeLayout(false);
            this.tbPost.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tbTwitter;
        private System.Windows.Forms.TabPage tbPost;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnDeleteTwitterAccount;
        private System.Windows.Forms.Button btnAddTwitterAccount;
        private System.Windows.Forms.ListBox lbxTwitterAccounts;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblImgurStatus;
    }
}

