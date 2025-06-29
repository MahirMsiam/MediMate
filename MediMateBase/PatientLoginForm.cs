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
    public partial class PatientLoginForm : Form
    {
        public PatientLoginForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientSignupForm().Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text.Trim();
            string password = passwordTxtBox.Text.Trim();

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = true;

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.");
                isValid = false;
            }

            if (isValid)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;"))
                    {
                        string query = "SELECT * FROM Patient WHERE email = @Email AND password = @Password";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Password", password);

                            con.Open();
                            DataSet ds = new DataSet();
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            adp.Fill(ds);

                            DataTable dt = ds.Tables[0];

                            int id = dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["id"]) : 0;
                            string name = dt.Rows.Count > 0 ? dt.Rows[0]["name"].ToString() : null;
                            string location = dt.Rows.Count > 0 ? dt.Rows[0]["location"].ToString() : null;


                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show($"Login successful for id {id}");
                                this.Hide();
                                new Patient_Dashboard(id, name, location).Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.");
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

        private void PatientLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}