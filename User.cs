﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Globalization;

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
        {
            return logged; 
        }

        public static void logout ()
        {
            logged = false;
        }
         
        public static string getUser ()
        {

            TextInfo txt = new CultureInfo("en-US", false).TextInfo;

            if (logged)
                return "Bienvenido " + txt.ToTitleCase(username); 
            return null;
        }
    }
}
