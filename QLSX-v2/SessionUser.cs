using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLSX
{
    public static class SessionUser
    {
        private static string userName;
        private static string password;
        private static string fullName;

        public static string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static string Password
        {
            get { return password; }
            set { password = value; }
        }

        public static bool Login(string _userName, string _password)
        {
            userName = _userName;
            password = _password;
            return true;
        }
    }
}
