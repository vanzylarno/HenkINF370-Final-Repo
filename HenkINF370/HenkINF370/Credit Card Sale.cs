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
    public partial class Credit_Card_Sale : MetroFramework.Forms.MetroForm
    {
        public Credit_Card_Sale()
        {
            InitializeComponent();
        }
        int Zero = 0;
        int Type = 2;

        private void Credit_Card_Sale_Load(object sender, EventArgs e)
        {
            lblDate.Text = System.DateTime.Now.ToLongDateString();
            txtOrderTotal.Enabled = false;
            txtVAT.Enabled = false;


            double VATPercentage = 0.14;
            double VATTotal = Convert.ToDouble(Globals.Total) * VATPercentage;

            txtVAT.Text = VATTotal.ToString();


            decimal Total = Globals.Total + Convert.ToDecimal(VATTotal);
            txtOrderTotal.Text = Total.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtOrderTotal.Text == "" || txtAmountReceived.Text == "" || txtCC.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All information required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "INSERT INTO CreditCardDetails(CardNumber) VALUES(@CardNumber)";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    sqlcom2.Parameters.Add(new SqlParameter("@CardNumber", txtCC.Text));
                    sqlcom2.ExecuteNonQuery();
                    sqlcon2.Close();

                    SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                    sqlcon3.Open();
                    string cmd3 = "SELECT CreditCardDetailsID FROM CreditCardDetails WHERE CardNumber ='" + txtCC.Text + "'";
                    SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                    SqlDataReader dr3 = sqlcom3.ExecuteReader();
                    if(dr3.HasRows)
                    {
                        while(dr3.Read())
                        {
                            int CCID;
                            CCID = Convert.ToInt32((dr3["CreditCardDetailsID"]));

                            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                            sqlcon.Open();
                            string cmd = "INSERT INTO Payment(PaymentAmount, PaymentDate, PaymentVAt, AmountReceived, Change, PaymentTypeID, CreditCardDetailsID) VALUES(@PaymentAmount, @PaymentDate, @PaymentVAT, @AmountReceived, @Change, @PaymentTypeID, @CreditCardDetailsID)";
                            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                            sqlcom.Parameters.Add(new SqlParameter("@PaymentAmount", txtOrderTotal.Text));
                            sqlcom.Parameters.Add(new SqlParameter("@PaymentDate", lblDate.Text));
                            sqlcom.Parameters.Add(new SqlParameter("@PaymentVAT", txtVAT.Text));
                            sqlcom.Parameters.Add(new SqlParameter("@AmountReceived", txtAmountReceived.Text));
                            sqlcom.Parameters.Add(new SqlParameter("@Change", Zero));
                            sqlcom.Parameters.Add(new SqlParameter("@PaymentTypeID", Type));
                            sqlcom.Parameters.Add(new SqlParameter("@CreditCardDetailsID", CCID));
                            sqlcom.ExecuteNonQuery();
                            sqlcon.Close();
                        }
                    }
                    dr3.Close();
                    sqlcon3.Close();


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
    }
}
