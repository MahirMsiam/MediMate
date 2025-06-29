using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediMate
{
    public partial class PharmacistAdminDashboard: Form
    {
        string connectionstring = "Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";
        public PharmacistAdminDashboard()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; // Hide password characters
            checkBox1.CheckedChanged += checkBox1_CheckedChanged; // Attach event handler for checkbox to toggle password visibility
            dataGridView1.CellFormatting += dataGridView1_CellFormatting; // Attach event handler for DataGridView cell formatting
            LoadDataGrid(); // Load data into DataGridView on form load
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide(); // Optional: hide the current form
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {   
            if(!ValidateInputs(txtId.Text, txtName.Text, txtEmail.Text, txtPassword.Text, txtPharmacyName.Text, txtPharmacyAddress.Text))
            {
                return; // Exit if validation fails
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {

                    string query = "INSERT INTO PHARMACIST (id, name, email, password, pharmacy_name, pharmacy_address) VALUES (@id, @name, @email, @password,@pharmacy_name,@pharmacy_address)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@pharmacy_name", txtPharmacyName.Text);
                    cmd.Parameters.AddWithValue("@pharmacy_address", txtPharmacyAddress.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pharmacist added successfully.");
                    LoadDataGrid(); // Refresh the DataGridView after adding a new pharmacist
                    ClearFields(); // Clear input fields after adding

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error adding pharmacist: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);

            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter a valid ID to update.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    StringBuilder query = new StringBuilder("UPDATE PHARMACIST SET ");
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        query.Append("name=@name,");
                        parameters.Add(new SqlParameter("@name", txtName.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        query.Append("email=@email,");
                        parameters.Add(new SqlParameter("@email", txtEmail.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        query.Append("password=@password,");
                        parameters.Add(new SqlParameter("@password", txtPassword.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(txtPharmacyName.Text))
                    {
                        query.Append("pharmacy_name=@pharmacy_name,");
                        parameters.Add(new SqlParameter("@pharmacy_name", txtPharmacyName.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(txtPharmacyAddress.Text))
                    {
                        query.Append("pharmacy_address=@pharmacy_address,");
                        parameters.Add(new SqlParameter("@pharmacy_address", txtPharmacyAddress.Text));
                    }

                    if (parameters.Count == 0)
                    {
                        MessageBox.Show("No fields to update.");
                        return;
                    }

                    query.Length--;
                    query.Append(" WHERE id=@id");
                    parameters.Add(new SqlParameter("@id", txtId.Text));

                    SqlCommand cmd = new SqlCommand(query.ToString(), conn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pharmacist updated successfully.");
                    LoadDataGrid();
                    ClearFields();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error updating pharmacist: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }



        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter a valid ID to delete.");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = "DELETE FROM PHARMACIST WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pharmacist deleted successfully.");
                    LoadDataGrid(); // Refresh the DataGridView after deleting a pharmacist
                    ClearFields(); // Clear input fields after deleting

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error deleting pharmacist: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    StringBuilder queryBuilder = new StringBuilder("SELECT * FROM PHARMACIST WHERE 1=1");
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        queryBuilder.Append(" AND id = @id");
                        parameters.Add(new SqlParameter("@id", txtId.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        queryBuilder.Append(" AND name LIKE @name");
                        parameters.Add(new SqlParameter("@name", "%" + txtName.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        queryBuilder.Append(" AND email LIKE @email");
                        parameters.Add(new SqlParameter("@email", "%" + txtEmail.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtPharmacyName.Text))
                    {
                        queryBuilder.Append(" AND pharmacy_name LIKE @pharmacy_name");
                        parameters.Add(new SqlParameter("@pharmacy_name", "%" + txtPharmacyName.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtPharmacyAddress.Text))
                    {
                        queryBuilder.Append(" AND pharmacy_address LIKE @pharmacy_address");
                        parameters.Add(new SqlParameter("@pharmacy_address", "%" + txtPharmacyAddress.Text + "%"));
                    }

                    SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No matching pharmacist found.");
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error searching for pharmacist: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);

            }
        }

        private void LoadDataGrid()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                string query = "SELECT * FROM PHARMACIST";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
                txtPharmacyName.Text = row.Cells["pharmacy_name"].Value.ToString();
                txtPharmacyAddress.Text = row.Cells["pharmacy_address"].Value.ToString();
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "password" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadDataGrid();

        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPharmacyName.Clear();
            txtPharmacyAddress.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
            if (checkBox1.Checked)
            {
                // Show real password
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Mask password with *
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private bool ValidateInputs(params string[] inputs)
        {
            foreach (string input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Please enter valid input.");
                    return false;
                }
            }
            return true;
        }
    }
}
