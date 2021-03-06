﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkINF370
{
    public class Globals
    {
        //Connection
        public static string ConnectionString = @"Data Source=ARNO\SQLEXPRESS;Initial Catalog=HenkINF370;Integrated Security=True";

        //User Details
        public static string UserName;
        public static int UserID;
        public static int UpdateUserID;

        //ShiftDetails
        public static int UpdateShiftID;
        public static string Start;
        public static string Stop;
        public static int CurrentShiftID;
        public static int TemplateID;

        //MenuItem
        public static int SelectedMenuItemID;

        //Combo
        public static string SelectedComboDescription;
        public static string SelectedComboExpireDate;
        public static string SelectedComboPrice;
        public static int ComboID;

        //Toppings
        public static int SelectedToppingID;
        public static string Name;
        public static string Price;

        //Order
        public static decimal Total;
        public static string CustomerName;
        public static string CustomerPhoneNumber;
        public static int OrderID;
        public static int CustomerID;
        public static int PaymentID;

        //Update User
        public static int SelectedUserID;

    }
}
