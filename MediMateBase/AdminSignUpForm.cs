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
    public partial class AdminSignUpForm: Form
    {
        string connectionString = "Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";
        public AdminSignUpForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; // Hide password characters
            checkBox1.CheckedChanged += checkBox1_CheckedChanged; // Attach event handler for checkbox to toggle password visibility
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
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
             
                    ClearFields(); // Clear input fields after adding
                    AdminLoginForm login = new AdminLoginForm();
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

        private void Back_btn_Click(object sender, EventArgs e)
        {
            // Navigate back to the login form
            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Show();
            this.Hide(); // Hide the current form

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility based on checkbox state
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;



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

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            checkBox1.Checked = false;
        }
    }
}
