﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HenkINF370
{
    public partial class Manager_Features : MetroFramework.Forms.MetroForm
    {
        public Manager_Features()
        {
            InitializeComponent();
        }

        private void Manager_Features_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Add_User myform = new Add_User();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Delete_User myform = new Delete_User();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Find_User myform = new Find_User();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Update_User myform = new Update_User();
            myform.ShowDialog();
        }
    }
}
