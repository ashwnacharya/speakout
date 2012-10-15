using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeakYourMind.SystemHelpers;

namespace SpeakYourMind.DataStore
{
    public class DataAccess
    {

        public static IQueryable<TwitterAccounts> GetTwitterAccounts()
        {
            SYMData db = new SYMData(ConfigurationHelper.Instance.DBConnectionString);

            var objAccounts = from objAccount in db.TwitterAccounts
                        select objAccount;



            return objAccounts;

        }

        public static void AddTwitterAccount(string accountName, string accessTokenString, string verificationString)
        {
            SYMData db = new SYMData(ConfigurationHelper.Instance.DBConnectionString);
            TwitterAccounts account = new TwitterAccounts();
            account.AccountName = accountName;
            account.AccessToken = accessTokenString;
            account.VerificationString = verificationString;

            db.TwitterAccounts.InsertOnSubmit(account);
            db.SubmitChanges();
            
        }

        public static void RemoveTwitterAccount(string accountName)
        {
            SYMData db = new SYMData(ConfigurationHelper.Instance.DBConnectionString);

            TwitterAccounts toDelete = db.TwitterAccounts.Single(account => account.AccountName == accountName);
            db.TwitterAccounts.DeleteOnSubmit(toDelete);
            db.SubmitChanges();

        }
    }
}
