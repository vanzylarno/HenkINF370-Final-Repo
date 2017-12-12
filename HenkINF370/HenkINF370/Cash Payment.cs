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
                    int CustomerID = 1;

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
