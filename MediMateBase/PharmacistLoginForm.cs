using MediMate;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PharmacistModule
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Set the initial state of the panels when the form starts
            pnlLogin.BringToFront();
            pnlLogin.Visible = true;
            pnlSignUp.Visible = false;
        }
        /// <summary>
        /// Clears all the input fields on the Sign Up panel.
        /// </summary>
        private void ClearSignUpFields()
        {
            txtSignUpUsername.Text = "";
            txtSignUpEmail.Text = "";
            txtSignUpPassword.Text = "";
            txtPharmacyName.Text = "";
            txtPharmacyAddress.Text = "";
        }

        // --- Panel Switching Logic ---

        private void lnkToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Brings the SignUp panel to the front and makes it visible
            pnlSignUp.BringToFront();
            pnlSignUp.Visible = true;
            pnlLogin.Visible = false;
        }

        private void lnkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Brings the Login panel to the front and makes it visible
            pnlLogin.BringToFront();
            pnlLogin.Visible = true;
            pnlSignUp.Visible = false;
        }
        // signup button logic
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // 1. Get user input from the sign-up TextBoxes
            string username = txtSignUpUsername.Text;
            string email = txtSignUpEmail.Text;
            string password = txtSignUpPassword.Text;
            string pharmacyName = txtPharmacyName.Text;
            string pharmacyAddress = txtPharmacyAddress.Text;

            // 2. Basic Validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill Username, Email, and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Hash the password for security
            //string hashedPassword = HashPassword(password);

            // 4. Prepare and Execute SQL Query
            try
            {
                // This query uses your specific fields
                string query = @"
                    INSERT INTO PHARMACIST (name, email, password, pharmacy_name, pharmacy_address) 
                    VALUES (@Username, @Email, @Password, @PharmacyName, @Address)";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@PharmacyName", pharmacyName),
                    new SqlParameter("@Address", pharmacyAddress)
                };

                // Using the DatabaseHelper class you should have in your project
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSignUpFields();
                    lnkToLogin_LinkClicked(null, null); // Switch back to login panel automatically
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation error number
                {
                    MessageBox.Show("This username or email is already registered.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Login Button Logic ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text;
            string password = txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Modified query to fetch ID and Name
            string query = "SELECT id FROM PHARMACIST WHERE Email = @Email AND Password = @Password";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int pharmacistId = reader.GetInt32(0); // Pharmacist_Id

                                MessageBox.Show($"Login successful! {pharmacistId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                new Pharmacists_Dashboard(pharmacistId).Show(); // Pass ID and name to dashboard
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- Security Helper Method ---
        //private string HashPassword(string password)
        //{
        //    using (SHA256 sha256 = SHA256.Create())
        //    {
        //        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        StringBuilder builder = new StringBuilder();
        //        for (int i = 0; i < bytes.Length; i++)
        //        {
        //            builder.Append(bytes[i].ToString("x2"));
        //        }
        //        return builder.ToString();
        //    }
        //}

        // --- Your Original Empty Event Handlers ---
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlSignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
