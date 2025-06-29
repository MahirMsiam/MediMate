using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Medimate
{
    public partial class Patient_Dashboard : Form
    {
        string connectionString = "Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";
        int id;
        string name;
        string location;
        public Patient_Dashboard(int id, string name, string location)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.location = location;
        }

        private void Patient_Dashboard_Load(object sender, EventArgs e)
        {
            nameLabel.Text = name + "'s" + " Dashboard";
            LoadDosageData();
        }

        private void LoadDosageData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM MEDICINEDOSEROUTINE WHERE patient_id = @Patient_Id ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Patient_Id", id);

                        con.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);

                        DataTable dt = ds.Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            dgvDosages.AutoGenerateColumns = true;
                            dgvDosages.DataSource = dt;
                            dgvDosages.Refresh();
                            dgvDosages.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("No dosage routine found for this patient.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string medicineName = medNameTxtBox.Text.Trim();
            string dosageTime = doseTimeTxtBox.Text.Trim();
            int durationDays = Convert.ToInt32(durationTxtBox.Text.Trim());

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(medicineName))
            {
                MessageBox.Show("Medicine name is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(dosageTime))
            {
                MessageBox.Show("Address is required.");
                isValid = false;
            }
            //if ()
            //{
            //    MessageBox.Show("Location is required.");
            //    isValid = false;
            //}
            if (isValid)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO MedicineDoseRoutine (patient_id, medicine_name,dosage_time, duration_days) VALUES (@Patient_Id, @Medicine_Name, @Dosage_Time, @Duration_Days)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Patient_Id", id);
                            cmd.Parameters.AddWithValue("@Medicine_Name", medicineName);
                            cmd.Parameters.AddWithValue("@Dosage_Time", dosageTime);
                            cmd.Parameters.AddWithValue("@Duration_Days", durationDays);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("New Dose Routine Added");
                            }
                            else
                            {
                                MessageBox.Show("Failed. Please try again.");
                            }
                        }
                    }
                    LoadDosageData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error:\n" + ex.Message);
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientSignupForm().Show();
        }

        private void mngDsgBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manage_Dosage(id, name, location).Show();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Medicine_Inventory_Details(id, name, location).Show();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
