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
    public partial class Template : MetroFramework.Forms.MetroForm
    {
        public Template()
        {
            InitializeComponent();
        }

        string Monday = "Monday";
        string Tuesday = "Tuesday";
        string Wednesday = "Wednesday";
        string Thursday = "Thursday";
        string Friday = "Friday";
        string Saturday = "Saturday";
        string Sunday = "Sunday";

        private void Template_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string day;
                    bool isAvailable;
                    string Condition;

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        //Monday
                        if (i == 1)
                        {
                            day = Monday;
                            isAvailable = Convert.ToBoolean(row.Cells[1].Value);

                            //Yes
                            if (isAvailable == true)
                            {
                                Condition = "Yes";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();

                            }
                            //No
                            else
                            {
                                Condition = "No";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }

                        }

                        //Tuesday
                        else if (i == 2)
                        {
                            day = Tuesday;
                            isAvailable = Convert.ToBoolean(row.Cells[2].Value);

                            //Yes
                            if (isAvailable == true)
                            {
                                Condition = "Yes";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                            //No
                            else
                            {
                                Condition = "No";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                        }

                        //Wednesday
                        else if (i == 3)
                        {
                            day = Wednesday;
                            isAvailable = Convert.ToBoolean(row.Cells[3].Value);

                            //Yes
                            if (isAvailable == true)
                            {
                                Condition = "Yes";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                            //No
                            else
                            {
                                Condition = "No";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                        }

                        //Thursday
                        else if (i == 4)
                        {
                            day = Thursday;
                            isAvailable = Convert.ToBoolean(row.Cells[4].Value);

                            //Yes
                            if (isAvailable == true)
                            {
                                Condition = "Yes";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                            //No
                            else
                            {
                                Condition = "No";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                        }

                        //Friday
                        else if (i == 5)
                        {
                            day = Friday;
                            isAvailable = Convert.ToBoolean(row.Cells[5].Value);

                            //Yes
                            if (isAvailable == true)
                            {
                                Condition = "Yes";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                            //No
                            else
                            {
                                Condition = "No";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                        }

                        //Saturday
                        else if (i == 6)
                        {
                            day = Saturday;
                            isAvailable = Convert.ToBoolean(row.Cells[6].Value);

                            //Yes
                            if (isAvailable == true)
                            {
                                Condition = "Yes";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                            //No
                            else
                            {
                                Condition = "No";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                        }

                        //Sunday
                        else if (i == 7)
                        {
                            day = Sunday;
                            isAvailable = Convert.ToBoolean(row.Cells[7].Value);

                            //Yes
                            if (isAvailable == true)
                            {
                                Condition = "Yes";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                            //No
                            else
                            {
                                Condition = "No";

                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                sqlcon.Open();
                                string cmd = "INSERT INTO Shifts(Day, TimeSlot, Available, Date, AvailableSlots) VALUES(@Day, @TimeSlot, @Available, @Date, @AvailableSlots)";
                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                sqlcom.Parameters.Add(new SqlParameter("@Day", day));
                                sqlcom.Parameters.Add(new SqlParameter("@TimeSlot", row.Cells["colTimeSlot"].Value));
                                sqlcom.Parameters.Add(new SqlParameter("@Available", Condition));
                                sqlcom.Parameters.Add(new SqlParameter("@Date", dtpDate.Text));
                                sqlcom.Parameters.Add(new SqlParameter("@AvailableSlots", txtAvailableSlots.Text));
                                sqlcom.ExecuteNonQuery();
                                sqlcon.Close();
                            }
                        }
                    }
                }

                MetroFramework.MetroMessageBox.Show(this, "Shifts Created Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {

            }
        }
            
    }
}
