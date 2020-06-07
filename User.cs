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
        public static bool loged = false; 

        public static bool login(string _userName, string _password)
        {
            if(_userName != "" && _password != "")
            {
                if (_userName == username && _password == password)
                {
                    loged = true; 
                    return true; 
                }
            }
            return false; 
        }
         
    }
}
