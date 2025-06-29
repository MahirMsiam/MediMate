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

namespace MediMate
{
    public partial class Pharmacists_Dashboard : Form
    {
        int id;
        int inventoryId = 0;
        public Pharmacists_Dashboard(int id)
        {
            InitializeComponent();
            this.id = id;
        }


        private void Pharmacists_Dashboard_Load(object sender, EventArgs e)
        {
            LoadInventory();
            panel2.Visible = false;
        }

        private void LoadInventory()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    string query = "select * From MEDICINEINVENTORY WHERE pharmacist_id = @Pharmacist_Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Pharmacist_Id", id);

                        con.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);

                        DataTable dt = ds.Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            dgvInventory.AutoGenerateColumns = true;
                            dgvInventory.DataSource = dt;
                            dgvInventory.Refresh();
                            dgvInventory.ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }
        }

        private void LoadMngInventory()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    string query = "select * From MEDICINEINVENTORY WHERE pharmacist_id = @Pharmacist_Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Pharmacist_Id", id);

                        con.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);

                        DataTable dt = ds.Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            dgvMngInventory.AutoGenerateColumns = true;
                            dgvMngInventory.DataSource = dt;
                            dgvMngInventory.Refresh();
                            dgvMngInventory.ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }
        }

        private void mngInventoryBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            LoadMngInventory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            LoadInventory();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string medName = medNameTxtBox.Text.Trim();
            int stock = Convert.ToInt32(stockTxtBox.Text.Trim());
            string expiry = expTxtBox.Text.Trim();
            if (inventoryId == 0)
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
                using (SqlConnection con = new SqlConnection("Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    string query = "UPDATE MEDICINEINVENTORY SET medicine_name = @Medicine_Name, stock_quantity = @Stock, expiry_date = @Expiry WHERE id = @Inventory_Id;";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@Inventory_Id", inventoryId);
                        cmd.Parameters.AddWithValue("@Medicine_Name", medName);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Expiry", expiry);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inventory Updated");
                        }
                        else
                        {
                            MessageBox.Show("Failed. Please try again.");
                        }
                    }
                }
                LoadMngInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }
        }
        private void dgvMngInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                inventoryId = Convert.ToInt32(dgvMngInventory.Rows[e.RowIndex].Cells[0].Value);
                medNameTxtBox.Text = dgvMngInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                stockTxtBox.Text = dgvMngInventory.Rows[e.RowIndex].Cells[3].Value.ToString();
                expTxtBox.Text = dgvMngInventory.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (inventoryId == 0)
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
                using (SqlConnection con = new SqlConnection("Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    string query = "delete from MEDICINEINVENTORY where id = '" + inventoryId + "';";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
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
                LoadMngInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }
            medNameTxtBox.Text = "";
            stockTxtBox.Text = "";
            expTxtBox.Text = "";
        }
    }
}
