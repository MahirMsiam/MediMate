using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediMate
{
    public partial class AdminHome: Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)  // crossbtn 
        {
            this.Close();

        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();

            admin.Show();

            this.Hide(); // Optional: hide the current form

        }

        private void Pharmacist_btn_Click(object sender, EventArgs e)
        {
            PharmacistAdminDashboard pharmacist = new PharmacistAdminDashboard();
            pharmacist.Show();
            this.Hide(); // Optional: hide the current form
        }

        private void patient_btn_Click(object sender, EventArgs e)
        {
            PatientAdminDashboard patient = new PatientAdminDashboard();
            patient.Show();
            this.Hide(); // Optional: hide the current form
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AdminLoginForm loginForm = new AdminLoginForm();
                loginForm.Show();
                this.Hide(); // Hide the current form
            }
            // If No is clicked, do nothing and stay on the current form
        }
    }
}
