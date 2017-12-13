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
    public partial class Update_Order : MetroFramework.Forms.MetroForm
    {
        public Update_Order()
        {
            InitializeComponent();
        }
        int CustomerID;
        int PaymentID;
        int OrderID;
        private void Update_Order_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT OrderID FROM Orders";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["OrderID"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
            sqlcon3.Open();
            string cmd3 = "SELECT CustomerID FROM Customer WHERE CustomerName LIKE '%" + txtFilter1.Text + "%'";
            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
            SqlDataReader dr3 = sqlcom3.ExecuteReader();
            if (dr3.HasRows)
            {

                while (dr3.Read())
                {
                    CustomerID = Convert.ToInt32((dr3["CustomerID"]));

                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT OrderID FROM Orders WHERE CustomerID ='" + CustomerID.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {

                            listBox1.Items.Add((dr2["OrderID"].ToString()));

                        }
                    }
                    dr2.Close();
                    sqlcon2.Close();
                }
            }
            dr3.Close();
            sqlcon3.Close();
        }

        private void txtFilter2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Distinct PaymentID FROM Payment WHERE PaymentDate LIKE '%" + txtFilter2.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PaymentID = Convert.ToInt32((dr["PaymentID"]));

                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT Distinct OrderID FROM Orders WHERE PaymentID ='" + PaymentID.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            listBox1.Items.Add((dr2["OrderID"].ToString()));
                        }
                    }
                    dr2.Close();
                    sqlcon2.Close();
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                GetCustomerDetails();
                GetPaymentDetails();
            }
            catch
            {

            }
        }
        private void GetCustomerDetails()
        {
            int CustomerTypeID;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT CustomerID, OrderID FROM Orders WHERE OrderID ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    CustomerID = Convert.ToInt32((dr["CustomerID"]));
                    OrderID = Convert.ToInt32((dr["OrderID"]));

                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT * FROM Customer WHERE CustomerID ='" + CustomerID.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            txtCustomerName.Text = (dr2["CustomerName"].ToString());
                            txtPhoneNumber.Text = (dr2["CustomerPhoneNumber"].ToString());
                            CustomerTypeID = Convert.ToInt32((dr2["CustomerTypeID"]));

                            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                            sqlcon3.Open();
                            string cmd3 = "SELECT Description FROM CustomerType WHERE CustomerTypeID ='" + CustomerTypeID.ToString() + "'";
                            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                            SqlDataReader dr3 = sqlcom3.ExecuteReader();
                            if (dr3.HasRows)
                            {
                                while (dr3.Read())
                                {
                                    txtCustomerType.Text = (dr3["Description"].ToString());
                                }
                            }
                            dr3.Close();
                            sqlcon3.Close();
                        }
                    }
                    dr2.Close();
                    sqlcon2.Close();
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void GetPaymentDetails()
        {
            int PaymentTypeID;
            int CCDetailsID;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PaymentID, OrderID FROM Orders WHERE OrderID ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PaymentID = Convert.ToInt32((dr["PaymentID"]));
                    OrderID = Convert.ToInt32((dr["OrderID"]));


                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT * FROM Payment WHERE PaymentID ='" + PaymentID.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            txtPaymentAmount.Text = (dr2["PaymentAmount"].ToString());
                            txtDate.Text = (dr2["PaymentDate"].ToString());
                            txtVAT.Text = (dr2["PaymentVAt"].ToString());
                            txtAmountReceived.Text = (dr2["AmountReceived"].ToString());
                            txtChange.Text = (dr2["Change"].ToString());
                            PaymentTypeID = Convert.ToInt32((dr2["PaymentTypeID"]));
                            CCDetailsID = Convert.ToInt32((dr2["CreditCardDetailsID"]));

                            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                            sqlcon3.Open();
                            string cmd3 = "SELECT PaymentTypeDescription FROM PaymentType WHERE PaymentTypeID ='" + PaymentTypeID.ToString() + "'";
                            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                            SqlDataReader dr3 = sqlcom3.ExecuteReader();
                            if (dr3.HasRows)
                            {
                                while (dr3.Read())
                                {
                                    txtPaymentType.Text = (dr3["PaymentTypeDescription"].ToString());
                                }
                            }
                            dr3.Close();
                            sqlcon3.Close();

                            SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                            sqlcon4.Open();
                            string cmd4 = "SELECT CardNumber FROM CreditCardDetails WHERE CreditCardDetailsID ='" + CCDetailsID.ToString() + "'";
                            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                            SqlDataReader dr4 = sqlcom4.ExecuteReader();
                            if (dr4.HasRows)
                            {
                                while (dr4.Read())
                                {
                                    txtCardNumber.Text = (dr4["CardNumber"].ToString());
                                }
                            }
                            dr4.Close();
                            sqlcon4.Close();
                        }
                    }
                    dr2.Close();
                    sqlcon2.Close();
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Update this Order?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d == DialogResult.Yes)
            {
                Globals.OrderID = OrderID;
                Globals.PaymentID = PaymentID;
                Globals.CustomerID = CustomerID;

                this.Close();
                this.Dispose(true);
                UpdateOrder2 myform = new UpdateOrder2();
                myform.ShowDialog();

            }
        }
    }
}
