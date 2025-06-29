namespace MediMate
{
    partial class LandingPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnGoToAdminLogin = new Button();
            btnGoToPharmacistLogin = new Button();
            btnGoToPatientLogin = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 590);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnGoToAdminLogin);
            panel1.Controls.Add(btnGoToPharmacistLogin);
            panel1.Controls.Add(btnGoToPatientLogin);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(514, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 590);
            panel1.TabIndex = 2;
            // 
            // btnGoToAdminLogin
            // 
            btnGoToAdminLogin.BackColor = SystemColors.ButtonHighlight;
            btnGoToAdminLogin.FlatAppearance.BorderSize = 0;
            btnGoToAdminLogin.FlatStyle = FlatStyle.Flat;
            btnGoToAdminLogin.Location = new Point(162, 357);
            btnGoToAdminLogin.Name = "btnGoToAdminLogin";
            btnGoToAdminLogin.Size = new Size(212, 45);
            btnGoToAdminLogin.TabIndex = 6;
            btnGoToAdminLogin.Text = "Login as Admin";
            btnGoToAdminLogin.UseVisualStyleBackColor = false;
            btnGoToAdminLogin.Click += btnGoToAdminLogin_Click;
            // 
            // btnGoToPharmacistLogin
            // 
            btnGoToPharmacistLogin.BackColor = SystemColors.ButtonHighlight;
            btnGoToPharmacistLogin.FlatAppearance.BorderSize = 0;
            btnGoToPharmacistLogin.FlatStyle = FlatStyle.Flat;
            btnGoToPharmacistLogin.Location = new Point(162, 293);
            btnGoToPharmacistLogin.Name = "btnGoToPharmacistLogin";
            btnGoToPharmacistLogin.Size = new Size(212, 45);
            btnGoToPharmacistLogin.TabIndex = 5;
            btnGoToPharmacistLogin.Text = "Login as Pharmacist";
            btnGoToPharmacistLogin.UseVisualStyleBackColor = false;
            btnGoToPharmacistLogin.Click += btnGoToPharmacistLogin_Click;
            // 
            // btnGoToPatientLogin
            // 
            btnGoToPatientLogin.BackColor = SystemColors.ButtonHighlight;
            btnGoToPatientLogin.FlatAppearance.BorderSize = 0;
            btnGoToPatientLogin.FlatStyle = FlatStyle.Flat;
            btnGoToPatientLogin.Location = new Point(162, 226);
            btnGoToPatientLogin.Name = "btnGoToPatientLogin";
            btnGoToPatientLogin.Size = new Size(212, 45);
            btnGoToPatientLogin.TabIndex = 4;
            btnGoToPatientLogin.Text = "Login As Patient";
            btnGoToPatientLogin.UseVisualStyleBackColor = false;
            btnGoToPatientLogin.Click += btnGoToPatientLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(27, 103);
            label1.Name = "label1";
            label1.Size = new Size(469, 48);
            label1.TabIndex = 3;
            label1.Text = "Welcome to MediMate";
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 590);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Button btnGoToAdminLogin;
        private Button btnGoToPharmacistLogin;
        private Button btnGoToPatientLogin;
    }
}
