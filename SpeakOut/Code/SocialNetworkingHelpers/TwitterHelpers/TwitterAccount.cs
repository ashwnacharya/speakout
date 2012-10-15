#region Usings
using System;
using SpeakYourMind.BaseClasses;
using SpeakYourMind.SystemHelpers;
using Twitterizer;

#endregion


namespace SpeakYourMind.TwitterHelper
{
    /// <summary>
    /// Represents a Single Twitter Account
    /// </summary>
    public class TwitterAccount : ISocialNetworkingAccount
    {
        #region Member Fields
        internal OAuthTokenResponse AccessToken;
        internal string VerificationString = string.Empty;
        #endregion

        #region Constructors
        public TwitterAccount(string accountName, string accessTokenString, string verficationString)
        {
            AccountName = accountName;
            AccessToken = (OAuthTokenResponse)SerializationHelper.Deserialize(typeof(OAuthTokenResponse), accessTokenString);
            VerificationString = verficationString;
        }

        public TwitterAccount(string accountName, OAuthTokenResponse accessToken, string verificationString)
        {
            AccountName = accountName;
            AccessToken = accessToken;
            VerificationString = verificationString;
        }
        #endregion


        public override void Post(string post)
        {
            OAuthTokens tokens = new OAuthTokens();
            tokens.AccessToken = AccessToken.Token;
            tokens.AccessTokenSecret = AccessToken.TokenSecret;
            tokens.ConsumerKey = TwitterHelper.Twitter_ConsumerKey;
            tokens.ConsumerSecret = TwitterHelper.Twitter_ConsumerSecret;

            TwitterStatus status = new TwitterStatus();
            TwitterStatus.Update(tokens, post);

        }

        public bool ReadyToPost()
        {
            if ( AccessToken == null || String.IsNullOrEmpty(VerificationString))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public TwitterStatusCollection GetStatuses()
        {
            return null;
        }
       
    }
}
