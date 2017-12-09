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
    public partial class Update_Shift2 : MetroFramework.Forms.MetroForm
    {
        public Update_Shift2()
        {
            InitializeComponent();
        }

        private void Update_Shift2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtTime.Text == "" || cbxDay.SelectedItem.ToString() == "" || cbxAvailable.SelectedItem.ToString() == "" || dtpDate.Value.ToString() == "" || AvailableSlots.Text == "")
            {
                lblDetails.Text = "Error!" +
                    "\n" +
                    "\n" +
                    "Not all information required" +
                    "\n" +
                    "has been provided!";
            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "UPDATE Shifts SET Day = @Day, TimeSlot = @TimeSlot, Available = @Available, Date = @Date, AvailableSlots = @AvailableSlots WHERE ShiftID ='" + Globals.UpdateShiftID.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@Day", cbxDay.SelectedItem.ToString()));
                    sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", txtTime.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@Available", cbxAvailable.SelectedItem.ToString()));
                    sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Value.ToLongDateString()));
                    sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", AvailableSlots.Text));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();


                    lblDetails.Text = "Success!" +
                        "\n" +
                        "\n" +
                        "The new Shift was Updated " +
                        "\n" +
                        "Successfully!";
                    txtTime.Text = "";
                    cbxDay.Text = "";
                    cbxAvailable.Text = "";
                    dtpDate.Text = "";
                    AvailableSlots.Text = "";
                }
                catch
                {
                    lblDetails.Text = "Error!" +
                        "\n" +
                        "\n" +
                        "A Connection to the Database" +
                        "\n" +
                        "could not be made!";
                }
            }

        }
    }
}
