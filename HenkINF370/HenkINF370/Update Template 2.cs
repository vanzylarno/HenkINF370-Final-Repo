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
    public partial class Update_Template_2 : MetroFramework.Forms.MetroForm
    {
        public Update_Template_2()
        {
            InitializeComponent();
        }

        private void Update_Template_2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtTimeSlot.Text == "" || txtAvailableSlots.Text == "" || cbxDay.SelectedItem.ToString() == "" || cbxAvailable.SelectedItem.ToString() == "" || dtpDate.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "UPDATE Shifts SET Day = @Day, TimeSlot = @TimeSlot, Available = @Available, Date = @Date, AvailableSlots = @AvailableSlots WHERE ShiftID ='" + Globals.TemplateID.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@Day", cbxDay.SelectedItem.ToString()));
                    sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", txtTimeSlot.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@Available", cbxAvailable.SelectedItem.ToString()));
                    sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "Shift Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                    this.Dispose(true);

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
