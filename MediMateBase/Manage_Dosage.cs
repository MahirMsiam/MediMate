using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medimate
{
    public partial class Manage_Dosage : Form
    {
        string connectionString ="Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";
        int id;
        string name;
        int routineId = 0;
        string location;
        public Manage_Dosage(int id, string name, string location)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.location = location;
        }


        private void Manage_Dosage_Load(object sender, EventArgs e)
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
                    string query = "SELECT * FROM MEDICINEDOSEROUTINE WHERE patient_id = @Id ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        con.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);

                        DataTable dt = ds.Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            dgvDosages.AutoGenerateColumns = false;
                            dgvDosages.DataSource = dt;
                            dgvDosages.Refresh();
                            dgvDosages.ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }
        }

        private void dgvDosages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                routineId = Convert.ToInt32(dgvDosages.Rows[e.RowIndex].Cells[0].Value);
                medNameTxtBox.Text = dgvDosages.Rows[e.RowIndex].Cells[1].Value.ToString();
                dosageNameTxtBox.Text = dgvDosages.Rows[e.RowIndex].Cells[2].Value.ToString();
                durationDaysTxtBox.Text = dgvDosages.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (routineId == 0)
            {
                MessageBox.Show("Please select row first");
                return;
            }
            var click = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);

            if (click == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "delete from MEDICINEDOSEROUTINE where id = @Routine_Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Routine_Id", routineId);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Routine Deleted");
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
            medNameTxtBox.Text = "";
            dosageNameTxtBox.Text = "";
            durationDaysTxtBox.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Dashboard(id, name, location).Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string medName = medNameTxtBox.Text.Trim();
            string dosageTime = dosageNameTxtBox.Text.Trim();
            int durationDays = Convert.ToInt32(durationDaysTxtBox.Text.Trim());

            if (routineId == 0)
            {
                MessageBox.Show("Please select row first");
                return;
            }

            var click = MessageBox.Show("Do you want to modify?", "Confirmation", MessageBoxButtons.YesNo);

            if (click == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE MEDICINEDOSEROUTINE SET medicine_name = @Medicine_Name, dosage_time = @Dosage_Time, duration_days = @Duration_Days WHERE id = @Routine_Id;";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Routine_Id", routineId);
                        cmd.Parameters.AddWithValue("@Medicine_Name", medName);
                        cmd.Parameters.AddWithValue("@Dosage_Time", dosageTime);
                        cmd.Parameters.AddWithValue("@Duration_Days", durationDays);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Routine Updated");
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


        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
