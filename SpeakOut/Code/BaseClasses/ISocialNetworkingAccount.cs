using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeakYourMind.BaseClasses
{
    public abstract class ISocialNetworkingAccount
    {
        public string AccountName;
        public abstract void Post(string post);
    }
}
