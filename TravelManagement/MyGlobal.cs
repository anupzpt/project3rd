using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagement
{
    class MyGlobal
    {
        //anu
        //public static string constring ="Data Source=DESKTOP-B0NOPO2\\SQLEXPRESS;Initial Catalog=travelmanagement;Integrated Security=True";
        public static string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=travelmanagement;Integrated Security=True";       
        public static int SN;
        public static int admininfo;
        public static int crosstimer;
        public static int logintimer;
        public static int loginsucess;
        public static int admin;
        public static int user;
        public static string username;

    }
    
}
