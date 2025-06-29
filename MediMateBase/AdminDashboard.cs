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
    public partial class AdminDashboard: Form
    {
        string connectionString = "Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";
        public AdminDashboard()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; // Hide password characters
            checkBox1.CheckedChanged += checkBox1_CheckedChanged; // Attach event handler for checkbox to toggle password visibility
            dataGridView1.CellFormatting += dataGridView1_CellFormatting_1; // Attach event handler for DataGridView cell formatting
            LoadDataGrid(); // Load data into DataGridView on form load
        }

        private void LoadDataGrid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ADMIN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true; // Make DataGridView read-only to prevent direct editing
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(txtId.Text, txtName.Text, txtEmail.Text, txtPassword.Text))
            {
                return; // Exit if validation fails
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ADMIN (id, name, email, password) VALUES (@id, @name, @email, @password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin added successfully.");
                    LoadDataGrid(); // Refresh the DataGridView after adding a new admin
                    ClearFields(); // Clear input fields after adding    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error adding admin: " + ex.Message);
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
            /*
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE ADMIN SET name=@name, email=@email, password=@password WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin updated successfully.");
                LoadDataGrid(); // Refresh the DataGridView after updating an admin
                ClearFields(); // Clear input fields after update
            }*/
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    StringBuilder query = new StringBuilder("UPDATE ADMIN SET ");
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
                    MessageBox.Show("Admin updated successfully.");
                    LoadDataGrid();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter a valid ID to delete.");
                return;
            }
            try {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ADMIN WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin deleted successfully.");
                    LoadDataGrid(); // Refresh the DataGridView after deleting an admin
                    ClearFields(); // Clear input fields after deletion
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error deleting admin: " + ex.Message);
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    StringBuilder queryBuilder = new StringBuilder("SELECT * FROM ADMIN WHERE 1=1");
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

                    SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No matching admin found.");
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error searching admin: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide(); // Optional: hide the current form
        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
            }
        }

       

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "password" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }

        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            checkBox1.Checked = false;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            LoadDataGrid();  // This method already reloads all admin data
            ClearFields();// Clear input fields after reset
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
