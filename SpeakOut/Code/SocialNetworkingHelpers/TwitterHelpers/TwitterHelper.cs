using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twitterizer;
using System.Diagnostics;
using SpeakYourMind.SystemHelpers;
using SpeakYourMind.DataStore;
using SpeakYourMind.DataStore;

namespace SpeakYourMind.TwitterHelper
{
    public class TwitterHelper
    {
        #region Twitter API Constants
        internal static string Twitter_ConsumerKey
        {
            get
            {
                return "1uahjb5B8gEjBaDRpSZ7A";
            }
        }

        internal static string Twitter_ConsumerSecret
        {
            get
            {
                return "7D2blQ7H39t3pvzLSjk91sRu2oWrGcMKCrcSnLuYEw";
            }
        }

        internal static string Twitter_RequestTokenURL
        {
            get
            {
                return @"http://twitter.com/oauth/request_token";
            }
        }

        internal static string Twitter_AccessTokenURL
        {
            get
            {
                return @"http://twitter.com/oauth/access_token";
            }
        }

        internal static string Twitter_AuthorizeURL
        {
            get
            {
                return @"http://twitter.com/oauth/authorize?oauth_token=";
            }
        }

        #endregion

        public static List<TwitterAccount> TwitterAccounts = null;

        static TwitterHelper()
        {
            TwitterAccounts = GetAccountsFromDB();
        }


        public static string DirectUserToGetAuthKey(OAuthTokenResponse RequestToken)
        {
            
            return Twitter_AuthorizeURL + RequestToken.Token;
        }

        public static OAuthTokenResponse InitiateAccountProvision()
        {
            OAuthTokenResponse RequestToken = OAuthUtility.GetRequestToken(Twitter_ConsumerKey, Twitter_ConsumerSecret, "oob");
            string obtainAuthKeyURL = DirectUserToGetAuthKey(RequestToken);
            Process process = new Process();
            process.StartInfo.FileName = SystemHelper.GetSystemDefaultBrowser();
            process.StartInfo.Arguments = obtainAuthKeyURL;
            process.Start();
            return RequestToken;
        }

        public static void CompleteAccountProvision(string accountName, OAuthTokenResponse RequestToken, string VerificationString)
        {
            OAuthTokenResponse accessToken = OAuthUtility.GetAccessToken(Twitter_ConsumerKey, Twitter_ConsumerSecret, RequestToken.Token, VerificationString);
            TwitterAccount account = new TwitterAccount(accountName, accessToken, VerificationString);

            TwitterAccounts.Add(account);

            AddAccountToDB(account);

        }

        public static void UnprovisionAccount(string accountName)
        {
            TwitterAccount accountToRemove = TwitterAccounts.Single(account => account.AccountName.ToUpperInvariant() == accountName.ToUpperInvariant());
            TwitterAccounts.Remove(accountToRemove);
            RemoveAccountFromDB(accountName);
        }



        private static List<TwitterAccount> GetAccountsFromDB()
        {

            List<TwitterAccount> twitterAccounts = new List<TwitterAccount>();
            var dbAccounts = DataAccess.GetTwitterAccounts();

            foreach(TwitterAccounts dbAccount in dbAccounts)
            {
                TwitterAccount twitterAccount = new TwitterAccount(dbAccount.AccountName, dbAccount.AccessToken, dbAccount.VerificationString);
                twitterAccounts.Add(twitterAccount);
            }

            return twitterAccounts;
        }

        private static void RemoveAccountFromDB(string accountName)
        {
            DataAccess.RemoveTwitterAccount(accountName);
        }


        private static void AddAccountToDB(TwitterAccount account)
        {
            string accessTokenString = SerializationHelper.Serialize(typeof(OAuthTokenResponse), account.AccessToken);
            DataAccess.AddTwitterAccount(account.AccountName, accessTokenString, account.VerificationString);
        }
    }
}
