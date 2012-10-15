using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeakYourMind.TwitterHelper;

namespace SpeakYourMind.BaseClasses
{
    public class SocialNetworkingFacade
    {
        public static List<ISocialNetworkingAccount> GetAllAccounts()
        {
            List<ISocialNetworkingAccount> accounts = new List<ISocialNetworkingAccount>();

            foreach (TwitterAccount twitterAccount in TwitterHelper.TwitterHelper.TwitterAccounts)
            {
                accounts.Add(twitterAccount);
            }

            return accounts;
        }
    }
}
