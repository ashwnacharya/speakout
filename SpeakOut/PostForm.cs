using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SpeakYourMind.SystemHelpers;
using SpeakYourMind.BaseClasses;
using Twitterizer;
using SpeakYourMind.TwitterHelper;

namespace SpeakYourMind.UI
{
    public partial class PostForm : Form
    {
        List<ISocialNetworkingAccount> accounts = null;

        public PostForm()
        {
            InitializeComponent();
            accounts = SocialNetworkingFacade.GetAllAccounts();

            lbxTwitterAccounts.DataSource = (from account in accounts select account.AccountName).ToList();
        }


        private void btnPost_Click(object sender, EventArgs e)
        {
            #region Old Code
            /*
            if (CanPostToTwitter())
            {

                if (!twitterHelper.ReadyToPost())
                {
                    string obtainAuthKeyURL = twitterHelper.DirectUserToGetAuthKey();
                    Process process = new Process();
                    process.StartInfo.FileName = SystemHelper.GetSystemDefaultBrowser();
                    process.StartInfo.Arguments = obtainAuthKeyURL;
                    process.Start();
                    tabControl1.SelectedTab = tbTwitter;

                    string caption = "You have not allowed SpeakYourMind to access twitter on your behalf";
                    StringBuilder message = new StringBuilder();
                    message.AppendLine("The Twitter Authorise page will have opened in your browser.");
                    message.AppendLine("To authorise:");
                    message.AppendLine("\t1. From the Authorise page, click on 'Allow'");
                    message.AppendLine("\t2. Copy the 8 digit authorization pin.");
                    message.AppendLine("\t3. Paste it in the Twitter tab of the SpeakYourMind application");
                    message.AppendLine("\t4. Click on Save.");
                    message.AppendLine("The SpeakYouMind Application will remember your authorization from next time onwards");
                    MessageBox.Show(message.ToString(), caption);
                }
                else
                {
                    string tweet = GetTweet();
                    try
                    {
                        twitterHelper.Post(tweet);
                        MessageBox.Show("Success!");
                        txtPost.Text = String.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            */
            #endregion

            string post = GetPost();

            string postWithURLsShortened = BitlyHelper.BitlyHelper.GetURLsShortenedinBlockOFText(post);
            txtPost.Text = postWithURLsShortened;

            foreach (ISocialNetworkingAccount account in accounts)
            {
                account.Post(postWithURLsShortened);
            }

            MessageBox.Show("Success");

        }

        private string GetPost()
        {
            return txtPost.Text;
        }


        private void txtPost_TextChanged(object sender, EventArgs e)
        {
            lblCharCount.Text = "Character Count = " + txtPost.TextLength;

            if (txtPost.TextLength > 140)
            {
                lblCharCount.ForeColor = Color.Red;
            }
        }

        private void btnAddTwitterAccount_Click(object sender, EventArgs e)
        {
            OAuthTokenResponse RequestToken = TwitterHelper.TwitterHelper.InitiateAccountProvision();

            AddTwitterAccount dialog = new AddTwitterAccount();
            dialog.ShowDialog(this);

            string accountName = dialog.TwitterAccountName;
            string verificationString = dialog.TwitterVerificationString;

            TwitterHelper.TwitterHelper.CompleteAccountProvision(accountName, RequestToken, verificationString);


            accounts = SocialNetworkingFacade.GetAllAccounts();

            lbxTwitterAccounts.DataSource = (from account in accounts select account.AccountName).ToList();



        }

        private void btnDeleteTwitterAccount_Click(object sender, EventArgs e)
        {
            string accountToDelete = lbxTwitterAccounts.SelectedValue.ToString();

            TwitterHelper.TwitterHelper.UnprovisionAccount(accountToDelete);

            accounts = SocialNetworkingFacade.GetAllAccounts();

            lbxTwitterAccounts.DataSource = (from account in accounts select account.AccountName).ToList();

        }

        private void lbxTwitterAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTwitterAccounts.SelectedIndex == -1)
            {
                btnAddTwitterAccount.Enabled = false;
                btnDeleteTwitterAccount.Enabled = false;
            }

            else
            {
                btnAddTwitterAccount.Enabled = true;
                btnDeleteTwitterAccount.Enabled = true;
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // Show Open File dialog

            

            

            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Jpeg files (*.jpg)|*.jpg|PNG files (*.png)|*.png";


            openDlg.FileName = "";
            openDlg.CheckFileExists = true;
            openDlg.CheckPathExists = true;

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                lblImgurStatus.Text = "Uploading Image";
                txtImage.Text = openDlg.FileName;
                string imgurPath = ImgurHelper.ImgurHelper.PostToImgurAnonymously(txtImage.Text);
                txtPost.Text = txtPost.Text + " " + imgurPath;
                lblImgurStatus.Text = "Image uploaded at " + imgurPath;
                Cursor.Current = Cursors.Default;
            }

            
            
            txtImage.Text = String.Empty;
        }



    }
}
