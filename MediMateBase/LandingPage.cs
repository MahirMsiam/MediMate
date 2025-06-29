using Medimate;
using PharmacistModule;

namespace MediMate
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToPatientLogin_Click(object sender, EventArgs e)
        {
            // Use the new name of the form you just added and renamed
            PatientLoginForm patientLogin = new PatientLoginForm();
            patientLogin.Show();
            this.Hide();
        }

        private void btnGoToPharmacistLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnGoToAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminLoginForm().Show();
        }
    }
}
