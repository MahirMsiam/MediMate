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
using System.Xml.Linq;

namespace MediMate
{
    
    public partial class PatientAdminDashboard: Form
    {
        string connectionString = "Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";
        public PatientAdminDashboard()
        {
            InitializeComponent();
            LoadPatients(); // Load patients into DataGridView on form load
        }

        private void LoadPatients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id, name, email, address, location FROM PATIENT";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (!dataGridView1.Columns.Contains("Details"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Action";
                    btn.Text = "Details";
                    btn.Name = "Details";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btn);
                }

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
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

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(txtId.Text, txtName.Text, txtEmail.Text, txtPassword.Text, txtAddress.Text, txtLocation.Text)) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO PATIENT (id, name, email, password, address, location) 
                                 VALUES (@id, @name, @email, @password, @address, @location)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient added.");
                    LoadPatients();
                    ClearFields(); // Clear input fields after adding a patient
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions, e.g., duplicate ID
                MessageBox.Show("Error adding patient: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);

            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please input valid ID.");
                return;
            }
            /*
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE PATIENT SET name=@name, email=@email, password=@password, 
                                 address=@address, location=@location WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient updated.");
                LoadPatients();
            }
            */
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    StringBuilder query = new StringBuilder("UPDATE PATIENT SET ");
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
                    if (!string.IsNullOrWhiteSpace(txtAddress.Text))
                    {
                        query.Append("address=@address,");
                        parameters.Add(new SqlParameter("@address", txtAddress.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                    {
                        query.Append("location=@location,");
                        parameters.Add(new SqlParameter("@location", txtLocation.Text));
                    }

                    if (parameters.Count == 0)
                    {
                        MessageBox.Show("No fields to update.");
                        return;
                    }

                    query.Length--; // Remove last comma
                    query.Append(" WHERE id=@id");
                    parameters.Add(new SqlParameter("@id", txtId.Text));

                    SqlCommand cmd = new SqlCommand(query.ToString(), conn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient updated.");
                    LoadPatients();
                    ClearFields(); // Clear input fields after updating a patient
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions, e.g., duplicate ID
                MessageBox.Show("Error updating patient: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(txtId.Text)) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM PATIENT WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient deleted.");
                    LoadPatients();
                    ClearFields(); // Clear input fields after deleting a patient
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions, e.g., foreign key constraint violation
                MessageBox.Show("Error deleting patient: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);

            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    StringBuilder queryBuilder = new StringBuilder("SELECT id, name, email, address, location FROM PATIENT WHERE 1=1");
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
                    if (!string.IsNullOrWhiteSpace(txtAddress.Text))
                    {
                        queryBuilder.Append(" AND address LIKE @address");
                        parameters.Add(new SqlParameter("@address", "%" + txtAddress.Text + "%"));
                    }
                    if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                    {
                        queryBuilder.Append(" AND location LIKE @location");
                        parameters.Add(new SqlParameter("@location", "%" + txtLocation.Text + "%"));
                    }
                    SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //dataGridView1.DataSource = dt;
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No matching Patient found.");
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                MessageBox.Show("Error searching for patient: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);

            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            LoadPatients();
            ClearFields(); // Clear input fields after resetting

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Details"].Index && e.RowIndex >= 0)
            {
                int patientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT medicine_name, dosage_time, duration_days 
                                     FROM MEDICINEDOSEROUTINE WHERE patient_id = @pid";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pid", patientId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    string routine = "";
                    while (reader.Read())
                    {
                        routine += $"Medicine: {reader["medicine_name"]}, Time: {reader["dosage_time"]}, Days: {reader["duration_days"]}\n";
                    }
                    MessageBox.Show(string.IsNullOrWhiteSpace(routine) ? "No routine found." : routine, "Medicine Routine");
                }
            }
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtLocation.Clear();
            checkBox1.Checked = false;
        }

        private bool ValidateInputs(params string[] values)
        {
            foreach (var val in values)
            {
                if (string.IsNullOrWhiteSpace(val))
                {
                    MessageBox.Show("Please input valid value.");
                    return false;
                }
            }
            return true;
        }
    }
}
