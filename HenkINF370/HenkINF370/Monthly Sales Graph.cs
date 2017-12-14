using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HenkINF370
{
    public partial class Monthly_Sales_Graph : MetroFramework.Forms.MetroForm
    {
        public Monthly_Sales_Graph()
        {
            InitializeComponent();
        }

        private void Monthly_Sales_Graph_Load(object sender, EventArgs e)
        {
            metroButton1.Enabled = false;
            chart1.Hide();
        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chart1.Series["Sales Made"].Points.Clear();
                metroButton1.Enabled = true;
                chart1.Show();
                GetTotalSalesMade();
                GetCashMade();
                Test2();
            }
            catch
            {

            }

        }
        private void GetTotalSalesMade()
        {
            int SalesMade;
            int PaymentID;
            //Get Payments
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PaymentID FROM Orders";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PaymentID = Convert.ToInt32((dr["PaymentID"]));

                    //Get Sales Made Today 
                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT Count(PaymentID) AS SalesMade FROM Payment WHERE PaymentDate LIKE '%" + cbxMonth.SelectedItem.ToString() + "%'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            SalesMade = Convert.ToInt32((dr2["SalesMade"]));
                            lblTotalSalesMade.Text = SalesMade.ToString();
                        }
                    }
                    dr2.Close();
                    sqlcon2.Close();
                }
            }
            dr.Close();
            sqlcon.Close();
        }
        private void GetCashMade()
        {
            double Cash;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT SUM(PaymentAmount) as CashMade FROM Payment WHERE PaymentDate LIKE'%" + cbxMonth.SelectedItem.ToString() + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cash = Convert.ToDouble((dr["CashMade"]));
                    lblRevenue.Text = Cash.ToString();
                }
            }
            dr.Close();
            sqlcon.Close();
        }
        private void Test2()
        {
            int PaymentTypeID;
            string Description;
            int SalesMade;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PaymentTypeID, COUNT(PaymentID) as SalesMade FROM Payment WHERE PaymentDate LIKE '%" + cbxMonth.SelectedItem.ToString() + "%' Group BY PaymentTypeID";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PaymentTypeID = Convert.ToInt32((dr["PaymentTypeID"]));
                    SalesMade = Convert.ToInt32((dr["SalesMade"]));

                    if (PaymentTypeID == 1)
                    {
                        Description = "Cash Sale";
                    }
                    else
                    {
                        Description = "Credit Card Sale";
                    }

                    chart1.Series["Sales Made"].Points.AddXY(Description, SalesMade);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }
    }
}
