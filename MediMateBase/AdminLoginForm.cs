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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MediMate
{
    public partial class AdminLoginForm: Form
    {
        string connectionString = "Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";

        public AdminLoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; // Hide password characters
            checkBox1.CheckedChanged += checkBox1_CheckedChanged; // Attach event handler for checkbox to toggle password visibility
           

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            // Close the application when the cancel button is clicked
            Application.Exit();

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string password = txtPassword.Text;

            if(string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both ID and Password.");
                return;
            }

           using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ADMIN WHERE id=@id AND password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login successful.");
                        AdminHome adminHome = new AdminHome();
                        adminHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid id or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {

            AdminSignUpForm signUpForm = new AdminSignUpForm();
            signUpForm.Show();
            this.Hide(); // Optional: hide the current form
        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility based on checkbox state
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Hide password
            }

        }
    }
}
