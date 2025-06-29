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

namespace Medimate
{
    public partial class PatientSignupForm : Form
    {
        public PatientSignupForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientLoginForm().Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtBox.Text.Trim();
            string email = emailTxtBox.Text.Trim();
            string address = addressTxtBox.Text.Trim();
            string location = locationTxtBox.Text.Trim();
            string password = passwordTxtBox.Text.Trim();

            string namePattern = @"^[a-zA-Z\s'-]+$";
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*?&]{6,}$";

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, namePattern))
            {
                MessageBox.Show("Name must contain only letters and cannot be empty.");
                isValid = false;
            }
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Location is required.");
                isValid = false;
            }
            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Password must be at least 6 characters and contain at least one letter and one number.");
                isValid = false;
            }

            if (isValid)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;"))
                    {
                        string query = "INSERT INTO Patient (name, email, address, location, password) VALUES (@Name, @Email, @Address, @Location, @Password)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@Location", location);
                            cmd.Parameters.AddWithValue("@Password", password);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registration Successful");
                                this.Hide();
                                new PatientSignupForm().Show();
                            }
                            else
                            {
                                MessageBox.Show("Registration failed. Please try again.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error:\n" + ex.Message);
                }
            }
        }

        private void PatientSignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
