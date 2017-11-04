using System;
using System.Collections.Generic;
using System.Linq;

namespace MegaSet
{
    public class UserInfo
    {
        public string Password
        {
            get;
            set;
        }

        public string Level
        {
            get;
            set;
        }

        public UserInfo(string password, string level)
        {
            Password = password;
            Level = level;
        }
    }
}
