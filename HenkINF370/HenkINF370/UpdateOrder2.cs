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
    public partial class UpdateOrder2 : MetroFramework.Forms.MetroForm
    {
        public UpdateOrder2()
        {
            InitializeComponent();
        }
        int CustomerTypeID;
        int PaymentTypeID;
        int CreditCardDetailsID;

        private void UpdateOrder2_Load(object sender, EventArgs e)
        {
            PopulateCustomerTypes();
            txtVAT.Enabled = false;
            txtChange.Enabled = false;
            PopulatePaymentTypeID();
        }
        private void PopulateCustomerTypes()
        {
            cbxCustomerType.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Description FROM CustomerType";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    cbxCustomerType.Items.Add((dr["Description"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxCustomerType_Click(object sender, EventArgs e)
        {
            PopulateCustomerTypes();

        }

        private void cbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT CustomerTypeID FROM CustomerType WHERE Description ='" + cbxCustomerType.SelectedItem.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    CustomerTypeID = Convert.ToInt32((dr["CustomerTypeID"]));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "UPDATE Customer SET CustomerName = @CustomerName, CustomerPhoneNumber = @CustomerPhoneNumber, CustomerTypeID = @CustomerTypeID WHERE CustomerID ='" + Globals.CustomerID.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                sqlcom.Parameters.Add(new SqlParameter("@CustomerName", txtCustomerName.Text));
                sqlcom.Parameters.Add(new SqlParameter("@CustomerPhoneNumber", txtPhoneNumber.Text));
                sqlcom.Parameters.Add(new SqlParameter("@CustomerTypeID", CustomerTypeID));
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();

                SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                sqlcon2.Open();
                string cmd2 = "SELECT CreditCardDetailsID FROM Payment WHERE PaymentID ='" + Globals.PaymentID.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                SqlDataReader dr2 = sqlcom2.ExecuteReader();
                if(dr2.HasRows)
                {
                    while(dr2.Read())
                    {
                        CreditCardDetailsID = Convert.ToInt32((dr2["CreditCardDetailsID"]));

                            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                            sqlcon3.Open();
                            string cmd3 = "UPDATE CreditCardDetails SET CardNumber = @CardNumber WHERE CreditCardDetailsID ='" + CreditCardDetailsID.ToString() + "'";
                            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                            sqlcom3.Parameters.Add(new SqlParameter("@CardNumber", txtCardNumber.Text));
                            sqlcom3.ExecuteNonQuery();
                            sqlcon3.Close();

                            SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                            sqlcon4.Open();
                            string cmd4 = "UPDATE Payment SET PaymentAmount = @PaymentAmount, PaymentDate = @PaymentDate, PaymentVAt = @PaymentVAT, AmountReceived = @AmountReceived, Change = @Change, PaymentTypeID = @PaymentTypeID, CreditCardDetailsID = @CreditCardDetailsID WHERE PaymentID ='" + Globals.PaymentID.ToString() + "'";
                            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                            sqlcom4.Parameters.Add(new SqlParameter("@PaymentAmount", txtPaymentAmount.Text));
                            sqlcom4.Parameters.Add(new SqlParameter("@PaymentDate", dtpDate.Text));
                            sqlcom4.Parameters.Add(new SqlParameter("@PaymentVAT", txtVAT.Text));
                            sqlcom4.Parameters.Add(new SqlParameter("@AmountReceived", txtAmountReceived.Text));
                            sqlcom4.Parameters.Add(new SqlParameter("@Change", txtChange.Text));
                            sqlcom4.Parameters.Add(new SqlParameter("@PaymentTypeID", PaymentTypeID));
                            sqlcom4.Parameters.Add(new SqlParameter("@CreditCardDetailsID", CreditCardDetailsID));
                            sqlcom4.ExecuteNonQuery();
                            sqlcon4.Close();
             

                        
                    }
                }
                dr2.Close();
                sqlcon2.Close();

                MetroFramework.MetroMessageBox.Show(this, "Order Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void txtPaymentAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double VATPercentage = 0.14;
                decimal VATAmount = Convert.ToDecimal(txtPaymentAmount.Text) * Convert.ToDecimal(VATPercentage);

                txtVAT.Text = VATAmount.ToString();
            }
            catch
            {

            }
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal Change = Convert.ToDecimal(txtAmountReceived.Text) - Convert.ToDecimal(txtPaymentAmount.Text);
                txtChange.Text = Change.ToString();
            }
            catch
            {

            }
        }

        private void PopulatePaymentTypeID()
        {
            cbxPaymentType.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PaymentTypeDescription FROM PaymentType";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxPaymentType.Items.Add((dr["PaymentTypeDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void cbxPaymentType_Click(object sender, EventArgs e)
        {
            PopulatePaymentTypeID();
        }

        private void cbxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PaymentTypeID FROM PaymentType WHERE PaymentTypeDescription ='" + cbxPaymentType.SelectedItem.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                  PaymentTypeID = Convert.ToInt32((dr["PaymentTypeID"]));

                    if (PaymentTypeID == 1)
                    {
                        txtCardNumber.Text = @"N\A";
                        txtCardNumber.Enabled = false;
                        CreditCardDetailsID = 1;
                    }
                    else
                    {
                        txtCardNumber.Enabled = true;
                        txtCardNumber.Text = "";
                    }
                }
            }
            dr.Close();
            sqlcon.Close();
        }
    }
}
