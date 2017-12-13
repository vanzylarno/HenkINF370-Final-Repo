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
    public partial class Cash_Payment : MetroFramework.Forms.MetroForm
    {
        public Cash_Payment()
        {
            InitializeComponent();
        }
        int CashSale = 1;
        int NoCC = 1;
        private void Cash_Payment_Load(object sender, EventArgs e)
        {
            lblDate.Text = System.DateTime.Now.ToLongDateString();
            txtOrderTotal.Enabled = false;
            txtVAT.Enabled = false;
            txtChange.Enabled = false;


            double VATPercentage = 0.14;
            double VATTotal = Convert.ToDouble(Globals.Total) * VATPercentage;

            txtVAT.Text = VATTotal.ToString();


            decimal Total = Globals.Total + Convert.ToDecimal(VATTotal);
            txtOrderTotal.Text = Total.ToString();


        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtOrderTotal.Text == "" || txtChange.Text == "" || txtAmountReceived.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All information required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                try
                {
                    int paymentID;
                    int CustomerID;

                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO Payment(PaymentAmount, PaymentDate, PaymentVAt, AmountReceived, Change, PaymentTypeID, CreditCardDetailsID) VALUES(@PaymentAmount, @PaymentDate, @PaymentVAT, @AmountReceived, @Change, @PaymentTypeID, @CreditCardDetailsID)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@PaymentAmount", txtOrderTotal.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@PaymentDate", lblDate.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@PaymentVAT", txtVAT.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@AmountReceived", txtAmountReceived.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@Change", txtChange.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@PaymentTypeID", CashSale));
                    sqlcom.Parameters.Add(new SqlParameter("@CreditCardDetailsID", NoCC));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    //Get CustomerID
                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT CustomerID From Customer WHERE CustomerName ='" + Globals.CustomerName.ToString() + "' AND CustomerPhoneNumber ='" + Globals.CustomerPhoneNumber.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if(dr2.HasRows)
                    {
                        while(dr2.Read())
                        {
                            CustomerID = Convert.ToInt32((dr2["CustomerID"]));

                            //Get PaymentID
                            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                            sqlcon3.Open();
                            string cmd3 = "SELECT PaymentID From Payment WHERE PaymentAmount ='" + txtOrderTotal.Text + "' AND PaymentDate ='" + lblDate.Text + "' AND PaymentVAt ='" + txtVAT.Text + "' AND AmountReceived ='" + txtAmountReceived.Text + "' AND Change ='" + txtChange.Text + "' AND PaymentTypeID ='" + CashSale.ToString() + "' AND CreditCardDetailsID ='" + NoCC.ToString() + "'";
                            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                            SqlDataReader dr3 = sqlcom3.ExecuteReader();
                            if (dr3.HasRows)
                            {
                                while (dr3.Read())
                                {
                                    paymentID = Convert.ToInt32((dr3["PaymentID"]));


                                    //Insert Into Orders
                                    SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                                    sqlcon4.Open();
                                    string cmd4 = "INSERT INTO Orders(PaymentID, CustomerID) VALUES(@PaymentID, @CustomerID)";
                                    SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                                    sqlcom4.Parameters.Add(new SqlParameter("@PaymentID", paymentID));
                                    sqlcom4.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));
                                    sqlcom4.ExecuteNonQuery();
                                    sqlcon4.Close();
                                }
                            }
                            dr3.Close();
                            sqlcon3.Close();
                        }
                    }
                    dr2.Close();
                    sqlcon2.Close();





                    MetroFramework.MetroMessageBox.Show(this, "Payment Captured Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                    this.Dispose(true);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    this.Dispose(true);
                }
            }
           
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal Change = Convert.ToDecimal(txtAmountReceived.Text) - Convert.ToDecimal(txtOrderTotal.Text);
                txtChange.Text = Change.ToString();
            }
            catch
            {

            }
        }
    }
}
