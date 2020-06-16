using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace proyecto
{
    public static class User
    {
        public static string username = "admin";
        public static string password = "password";
        private static bool logged = false; 

        public static bool login (string _userName, string _password)
        {
            if(_userName != "" && _password != "")
            {
                if (_userName == username && _password == password)
                {
                    logged = true; 
                    return true; 
                }
            }
            return false; 
        }

        public static bool isLogged()
        //https://wompampsupport.azureedge.net/fetchimage?siteId=7575&v=2&jpgQuality=100&width=700&url=https%3A%2F%2Fi.kym-cdn.com%2Fentries%2Ficons%2Ffacebook%2F000%2F012%2F982%2F039.jpg
        {
            if (logged)
            {
                return true; 
            }
            return false; 
        }

        public static void logout ()
        {
            logged = false;
        }
         
        public static string estado ()
        {
            if (logged)
                return username;
            return "";
        }
    }
}
