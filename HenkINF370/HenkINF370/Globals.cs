using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkINF370
{
    public class Globals
    {
        public static string ConnectionString = @"Data Source=ARNO\SQLEXPRESS;Initial Catalog=HenkINF370;Integrated Security=True";
        public static string UserName;
        public static int UserID;
        public static int UpdateUserID;
        public static int UpdateShiftID;
        public static string Start;
        public static string Stop;
        public static int CurrentShiftID;
        public static int SelectedMenuItemID;
    }
}
