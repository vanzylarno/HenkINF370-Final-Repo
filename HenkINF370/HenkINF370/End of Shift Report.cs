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
    public partial class End_of_Shift_Report : MetroFramework.Forms.MetroForm
    {
        public End_of_Shift_Report()
        {
            InitializeComponent();
        }
        string Description;
        int SalesMadeToday;
        private void End_of_Shift_Report_Load(object sender, EventArgs e)
        {
            lblDate.Text = System.DateTime.Now.ToLongDateString();
            try
            { //Get Total Sales Made Today
                GetTotalSalesMade();
                Test2();
                TotalCashMade();

            }
            catch
            {

            }
        }

        private void TotalCashMade()
        {
            double Cash;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT SUM(PaymentAmount) as CashMade FROM Payment WHERE PaymentDate ='" + lblDate.Text + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    Cash = Convert.ToDouble((dr["CashMade"]));
                    lblRevenue.Text = Cash.ToString();
                }
            }
            dr.Close();
            sqlcon.Close();
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
                while(dr.Read())
                {
                    PaymentID = Convert.ToInt32((dr["PaymentID"]));

                    //Get Sales Made Today 
                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT Count(PaymentID) AS SalesMade FROM Payment WHERE PaymentDate ='" + lblDate.Text.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if(dr2.HasRows)
                    {
                        while(dr2.Read())
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
     
        private void Test2()
        {
            int PaymentTypeID;
            string Description;
            int SalesMade;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PaymentTypeID, COUNT(PaymentID) as SalesMade FROM Payment WHERE PaymentDate ='" + lblDate.Text + "' Group BY PaymentTypeID";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    PaymentTypeID = Convert.ToInt32((dr["PaymentTypeID"]));
                    SalesMade = Convert.ToInt32((dr["SalesMade"]));

                    if(PaymentTypeID == 1)
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

        string Details;
    
        private void documentWriter()
        {


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Create Word Application
            word.Application wordApp = new word.Application();
            wordApp.Visible = true;

            //Create the Document
            word.Document wordDoc = wordApp.Documents.Add();

            //Create the Heading Parahraph
            word.Paragraph wordPara = wordDoc.Paragraphs.Add();
            wordPara.Range.Text = "End of Shift Report";
            object styleName = "Intense Quote";
            wordPara.Range.set_Style(ref styleName);
            wordPara.Range.InsertParagraphAfter();

            //Create a New Paragraph
            word.Paragraph wordPara2 = wordDoc.Paragraphs.Add();
            wordPara2.Range.Text = "This Document Contains all the crucial information regarding the Total Sales made per Shift. This information includes the Total Sales Made in the Shift, Each Sale made, their payment type and amounts. The total Amount of Sales Made this shift is: " + lblTotalSalesMade.Text + " " + "The Total Revenue made today is: R" + lblRevenue.Text;
            object styleName2 = "Subtle Emphasis";
            wordPara2.Range.set_Style(ref styleName2);
            wordPara2.Range.InsertParagraphAfter();

            
            int PaymentID;
                double PaumentAmount;
                string PaymentDate;
                double PaymentVAT;
                double AmountReceived;
                double Change;
                int PaymentTypeID;
                string Description;
                string Type;

                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "SELECT PaymentID, PaymentAmount, PaymentDate, PaymentVAt, AmountReceived, Change, PaymentTypeID FROM Payment WHERE PaymentDate ='" + lblDate.Text + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PaymentID = Convert.ToInt32((dr["PaymentID"]));
                    PaumentAmount = Convert.ToDouble((dr["PaymentAmount"]));
                    PaymentDate = (dr["PaymentDate"].ToString());
                    PaymentVAT = Convert.ToDouble((dr["PaymentVAt"]));
                    AmountReceived = Convert.ToDouble((dr["AmountReceived"]));
                    Change = Convert.ToDouble((dr["Change"]));
                    PaymentTypeID = Convert.ToInt32((dr["PaymentTypeID"]));

                    if (PaymentTypeID == 1)
                    {
                        Type = "Cash Sale";
                    }
                    else
                    {
                        Type = "Credit Card Sale";
                    }

                    Details = "Payment ID: " + PaymentID.ToString() + "\n" +
                              "Payment Amount: R" + PaumentAmount.ToString() + "\n" +
                              "Payment Date: " + PaymentDate.ToString() + "\n" +
                              "VAT: R" + PaymentVAT.ToString() + "\n" +
                              "Amount Received: R" + AmountReceived.ToString() + "\n" +
                              "Change: R" + Change.ToString() + "\n" +
                              "Payment Type: " + Type.ToString() + "\n";


                    word.Paragraph wordPara3 = wordDoc.Paragraphs.Add();
                    object styleName3 = "List Paragraph";
                    wordPara3.Range.set_Style(ref styleName3);
                    wordPara3.Range.InsertParagraphAfter();
                    wordPara3.Range.Text = Details;
                }
            }
                
            dr.Close();
            sqlcon.Close();         

         
        }


    }
}
