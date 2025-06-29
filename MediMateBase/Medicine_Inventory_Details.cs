using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Medimate
{
    public partial class Medicine_Inventory_Details : Form
    {
        string connectionString = "Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";
        int id;
        string name;
        string location;
        public Medicine_Inventory_Details(int id, string name, string location)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.location = location;
        }
        private void Medicine_Inventory_Details_Load(object sender, EventArgs e)
        {
            nameLabel.Text = name + "'s" + " Dashboard";
            string query = "SELECT * from MEDICINEINVENTORY";
            LoadInventory(query);
        }
        private void LoadInventory(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }
        }

        //private void locationBtn_Click(object sender, EventArgs e)
        //{

        //    string query = "SELECT * from PHARMACIST WHERE pharmacy_address = @Inventory_Location;";
        //    LoadInventory(query);
        //}

        private void allBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from MEDICINEINVENTORY";
            LoadInventory(query);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Dashboard(id, name, location).Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchTxtBox.Text.Trim();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * from MEDICINEINVENTORY WHERE medicine_name=@SearchText;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", searchText);

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

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDosages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
