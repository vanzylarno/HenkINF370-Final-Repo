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
using word = Microsoft.Office.Interop.Word;

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



                            int CustomerID;
                            int PaymentID;

                            //Get CustomerID
                            SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                            sqlcon4.Open();
                            string cmd4 = "SELECT CustomerID From Customer WHERE CustomerName ='" + Globals.CustomerName.ToString() + "' AND CustomerPhoneNumber ='" + Globals.CustomerPhoneNumber.ToString() + "'";
                            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                            SqlDataReader dr4 = sqlcom4.ExecuteReader();
                            if (dr4.HasRows)
                            {
                                while (dr4.Read())
                                {
                                    CustomerID = Convert.ToInt32((dr4["CustomerID"]));

                                    //Get PaymentID
                                    SqlConnection sqlcon5 = new SqlConnection(Globals.ConnectionString);
                                    sqlcon5.Open();
                                    string cmd5 = "SELECT PaymentID From Payment WHERE PaymentAmount ='" + txtOrderTotal.Text + "' AND PaymentDate ='" + lblDate.Text + "' AND PaymentVAt ='" + txtVAT.Text + "' AND AmountReceived ='" + txtAmountReceived.Text + "' AND Change ='" + Zero.ToString() + "' AND PaymentTypeID ='" + Type + "' AND CreditCardDetailsID ='" + CCID.ToString() + "'";
                                    SqlCommand sqlcom5 = new SqlCommand(cmd5, sqlcon5);
                                    SqlDataReader dr5 = sqlcom5.ExecuteReader();
                                    if (dr5.HasRows)
                                    {
                                        while (dr5.Read())
                                        {
                                            PaymentID = Convert.ToInt32((dr5["PaymentID"]));


                                            //Insert Into Orders
                                            SqlConnection sqlcon6 = new SqlConnection(Globals.ConnectionString);
                                            sqlcon6.Open();
                                            string cmd6 = "INSERT INTO Orders(PaymentID, CustomerID) VALUES(@PaymentID, @CustomerID)";
                                            SqlCommand sqlcom6 = new SqlCommand(cmd6, sqlcon6);
                                            sqlcom6.Parameters.Add(new SqlParameter("@PaymentID", PaymentID));
                                            sqlcom6.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));
                                            sqlcom6.ExecuteNonQuery();
                                            sqlcon6.Close();
                                        }
                                    }
                                    dr5.Close();
                                    sqlcon5.Close();
                                }
                            }
                            dr4.Close();
                            sqlcon4.Close();
                        }
                    }
                    dr3.Close();
                    sqlcon3.Close();


                    //Create Receipt
                    //Create Word Application
                    word.Application wordApp = new word.Application();
                    wordApp.Visible = true;

                    //Create the Document
                    word.Document wordDoc = wordApp.Documents.Add();

                    //Create the Heading Parahraph
                    word.Paragraph wordPara = wordDoc.Paragraphs.Add();
                    wordPara.Range.Text = "Receipt";
                    object styleName = "Quote";
                    wordPara.Range.set_Style(ref styleName);
                    wordPara.Range.InsertParagraphAfter();





                    string Details;
                    string ItemName;
                    string DrinkSize;
                    string PizzaSize;
                    string PizzaBase;
                    double Price;
                    string ToppingName;
                    double ToppingPrice;

                    //Get Ordered Items
                    SqlConnection sqlcon7 = new SqlConnection(Globals.ConnectionString);
                    sqlcon7.Open();
                    string cmd7 = "SELECT  * FROM OrderBasket";
                    SqlCommand sqlcom7 = new SqlCommand(cmd7, sqlcon7);
                    SqlDataReader dr7 = sqlcom7.ExecuteReader();
                    if (dr7.HasRows)
                    {
                        while (dr7.Read())
                        {
                            ItemName = (dr7["ItemName"].ToString());
                            DrinkSize = (dr7["DrinkSize"].ToString());
                            PizzaSize = (dr7["PizzaSize"].ToString());
                            PizzaBase = (dr7["PizzaBase"].ToString());
                            Price = Convert.ToDouble((dr7["Price"]));

                            try
                            {

                                //Get Toppings
                                SqlConnection sqlcon6 = new SqlConnection(Globals.ConnectionString);
                                sqlcon6.Open();
                                string cmd6 = "SELECT * FROM ToppingBasket";
                                SqlCommand sqlcom6 = new SqlCommand(cmd6, sqlcon6);
                                SqlDataReader dr6 = sqlcom6.ExecuteReader();
                                if (dr6.HasRows)
                                {
                                    while (dr6.Read())
                                    {
                                        ToppingName = (dr6["ToppingName"].ToString());
                                        ToppingPrice = Convert.ToDouble((dr6["Price"]));

                                        Details = "Item Name: " + ItemName + "\n" +
                                            "Drink Size: " + DrinkSize + "\n" +
                                            "Pizza Size: " + PizzaSize + "\n" +
                                            "Pizza Base: " + PizzaBase + "\n" +
                                            "Price: R" + Price.ToString() + "\n" +
                                            "Topping: " + ToppingName + "\n" +
                                            "Price: R" + ToppingPrice + "\n";


                                        //Details
                                        word.Paragraph wordPara3 = wordDoc.Paragraphs.Add();
                                        object styleName3 = "Emphasis";
                                        wordPara3.Range.set_Style(ref styleName3);
                                        wordPara3.Range.InsertParagraphAfter();
                                        wordPara3.Range.Text = Details;
                                    }
                                }
                                dr6.Close();
                                sqlcon6.Close();
                            }
                            catch
                            {

                                Details = "Item Name: " + ItemName + "\n" +
                                    "Drink Size: " + DrinkSize + "\n" +
                                    "Pizza Size: " + PizzaSize + "\n" +
                                    "Pizza Base: " + PizzaBase + "\n" +
                                    "Price: R" + Price.ToString() + "\n";

                                //Details
                                word.Paragraph wordPara3 = wordDoc.Paragraphs.Add();
                                object styleName3 = "Emphasis";
                                wordPara3.Range.set_Style(ref styleName3);
                                wordPara3.Range.InsertParagraphAfter();
                                wordPara3.Range.Text = Details;
                            }
                        }
                    }
                    dr7.Close();
                    sqlcon7.Close();
                    string Date = lblDate.Text;
                    double SubTotal = Convert.ToDouble(Globals.Total);
                    double VAT = Convert.ToDouble(txtVAT.Text);
                    double Total = Convert.ToDouble(txtOrderTotal.Text);
                    double AmountReceived = Convert.ToDouble(txtAmountReceived.Text);
                    double Change = Convert.ToDouble(Zero);
                    //Totals
                    word.Paragraph wordPara4 = wordDoc.Paragraphs.Add();
                    wordPara4.Range.Text = "Totals";
                    object styleName4 = "Strong";
                    wordPara4.Range.set_Style(ref styleName);
                    wordPara4.Range.InsertParagraphAfter();
                    wordPara4.Range.Text = "Date: " + Date + "\n" +
                        "Sub Total: R" + SubTotal.ToString() + "\n" +
                        "VAT: R" + VAT.ToString() + "\n" +
                        "Total: R" + Total.ToString() + "\n" +
                        "Amount Received: R" + AmountReceived.ToString() + "\n" +
                        "Change: R" + Change.ToString();




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
