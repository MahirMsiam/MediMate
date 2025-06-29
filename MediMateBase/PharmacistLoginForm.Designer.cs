namespace PharmacistModule
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pnlLogin = new Panel();
            lnkToSignUp = new LinkLabel();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            txtLoginEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lgin = new Label();
            pnlSignUp = new Panel();
            btnSignUp = new Button();
            lnkToLogin = new LinkLabel();
            txtPharmacyAddress = new TextBox();
            txtPharmacyName = new TextBox();
            txtSignUpPassword = new TextBox();
            txtSignUpEmail = new TextBox();
            txtSignUpUsername = new TextBox();
            label6 = new Label();
            l = new Label();
            label4 = new Label();
            label3 = new Label();
            fulname = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            pnlSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 823);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.RoyalBlue;
            pnlLogin.Controls.Add(lnkToSignUp);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtLoginPassword);
            pnlLogin.Controls.Add(txtLoginEmail);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(lgin);
            pnlLogin.Dock = DockStyle.Right;
            pnlLogin.ForeColor = SystemColors.ButtonHighlight;
            pnlLogin.Location = new Point(520, 0);
            pnlLogin.Margin = new Padding(4, 5, 4, 5);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(555, 823);
            pnlLogin.TabIndex = 1;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // lnkToSignUp
            // 
            lnkToSignUp.AutoSize = true;
            lnkToSignUp.BackColor = Color.Transparent;
            lnkToSignUp.Font = new Font("Microsoft Sans Serif", 10F);
            lnkToSignUp.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkToSignUp.LinkColor = Color.White;
            lnkToSignUp.Location = new Point(172, 494);
            lnkToSignUp.Margin = new Padding(4, 0, 4, 0);
            lnkToSignUp.Name = "lnkToSignUp";
            lnkToSignUp.Size = new Size(244, 20);
            lnkToSignUp.TabIndex = 6;
            lnkToSignUp.TabStop = true;
            lnkToSignUp.Text = "Don't have an account? sign up";
            lnkToSignUp.LinkClicked += lnkToSignUp_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(268, 406);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(243, 331);
            txtLoginPassword.Margin = new Padding(4, 5, 4, 5);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(205, 27);
            txtLoginPassword.TabIndex = 4;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Location = new Point(243, 266);
            txtLoginEmail.Margin = new Padding(4, 5, 4, 5);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(205, 27);
            txtLoginEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(125, 331);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.Location = new Point(125, 266);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // lgin
            // 
            lgin.AutoSize = true;
            lgin.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lgin.Location = new Point(151, 134);
            lgin.Margin = new Padding(4, 0, 4, 0);
            lgin.Name = "lgin";
            lgin.Size = new Size(278, 32);
            lgin.TabIndex = 0;
            lgin.Text = "Login to your account";
            // 
            // pnlSignUp
            // 
            pnlSignUp.BackColor = Color.RoyalBlue;
            pnlSignUp.Controls.Add(btnSignUp);
            pnlSignUp.Controls.Add(lnkToLogin);
            pnlSignUp.Controls.Add(txtPharmacyAddress);
            pnlSignUp.Controls.Add(txtPharmacyName);
            pnlSignUp.Controls.Add(txtSignUpPassword);
            pnlSignUp.Controls.Add(txtSignUpEmail);
            pnlSignUp.Controls.Add(txtSignUpUsername);
            pnlSignUp.Controls.Add(label6);
            pnlSignUp.Controls.Add(l);
            pnlSignUp.Controls.Add(label4);
            pnlSignUp.Controls.Add(label3);
            pnlSignUp.Controls.Add(fulname);
            pnlSignUp.Dock = DockStyle.Fill;
            pnlSignUp.Location = new Point(519, 0);
            pnlSignUp.Margin = new Padding(4, 5, 4, 5);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(1, 823);
            pnlSignUp.TabIndex = 7;
            pnlSignUp.Visible = false;
            pnlSignUp.Paint += pnlSignUp_Paint;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Microsoft Sans Serif", 10F);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(229, 503);
            btnSignUp.Margin = new Padding(4, 5, 4, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(100, 42);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lnkToLogin
            // 
            lnkToLogin.AutoSize = true;
            lnkToLogin.Font = new Font("Microsoft Sans Serif", 10F);
            lnkToLogin.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkToLogin.LinkColor = Color.White;
            lnkToLogin.Location = new Point(149, 571);
            lnkToLogin.Margin = new Padding(4, 0, 4, 0);
            lnkToLogin.Name = "lnkToLogin";
            lnkToLogin.Size = new Size(252, 20);
            lnkToLogin.TabIndex = 10;
            lnkToLogin.TabStop = true;
            lnkToLogin.Text = "Already have an account? Log in";
            lnkToLogin.LinkClicked += lnkToLogin_LinkClicked;
            // 
            // txtPharmacyAddress
            // 
            txtPharmacyAddress.Location = new Point(264, 405);
            txtPharmacyAddress.Margin = new Padding(4, 5, 4, 5);
            txtPharmacyAddress.Name = "txtPharmacyAddress";
            txtPharmacyAddress.Size = new Size(213, 27);
            txtPharmacyAddress.TabIndex = 9;
            // 
            // txtPharmacyName
            // 
            txtPharmacyName.Location = new Point(264, 355);
            txtPharmacyName.Margin = new Padding(4, 5, 4, 5);
            txtPharmacyName.Name = "txtPharmacyName";
            txtPharmacyName.Size = new Size(213, 27);
            txtPharmacyName.TabIndex = 8;
            // 
            // txtSignUpPassword
            // 
            txtSignUpPassword.Location = new Point(264, 300);
            txtSignUpPassword.Margin = new Padding(4, 5, 4, 5);
            txtSignUpPassword.Name = "txtSignUpPassword";
            txtSignUpPassword.Size = new Size(213, 27);
            txtSignUpPassword.TabIndex = 7;
            txtSignUpPassword.UseSystemPasswordChar = true;
            // 
            // txtSignUpEmail
            // 
            txtSignUpEmail.Location = new Point(264, 248);
            txtSignUpEmail.Margin = new Padding(4, 5, 4, 5);
            txtSignUpEmail.Name = "txtSignUpEmail";
            txtSignUpEmail.Size = new Size(213, 27);
            txtSignUpEmail.TabIndex = 6;
            // 
            // txtSignUpUsername
            // 
            txtSignUpUsername.Location = new Point(264, 195);
            txtSignUpUsername.Margin = new Padding(4, 5, 4, 5);
            txtSignUpUsername.Name = "txtSignUpUsername";
            txtSignUpUsername.Size = new Size(213, 27);
            txtSignUpUsername.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.Location = new Point(89, 402);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 4;
            label6.Text = "Pharma Address";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Microsoft Sans Serif", 10F);
            l.Location = new Point(89, 300);
            l.Margin = new Padding(4, 0, 4, 0);
            l.Name = "l";
            l.Size = new Size(83, 20);
            l.TabIndex = 3;
            l.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(89, 352);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 2;
            label4.Text = "Pharmacy Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(89, 249);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // fulname
            // 
            fulname.AutoSize = true;
            fulname.Font = new Font("Microsoft Sans Serif", 10F);
            fulname.Location = new Point(89, 197);
            fulname.Margin = new Padding(4, 0, 4, 0);
            fulname.Name = "fulname";
            fulname.Size = new Size(91, 20);
            fulname.TabIndex = 0;
            fulname.Text = "User name";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 823);
            Controls.Add(pnlSignUp);
            Controls.Add(pnlLogin);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlSignUp.ResumeLayout(false);
            pnlSignUp.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lgin;
        private System.Windows.Forms.LinkLabel lnkToSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fulname;
        private System.Windows.Forms.TextBox txtPharmacyAddress;
        private System.Windows.Forms.TextBox txtPharmacyName;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.TextBox txtSignUpEmail;
        private System.Windows.Forms.TextBox txtSignUpUsername;
        private System.Windows.Forms.LinkLabel lnkToLogin;
        private System.Windows.Forms.Button btnSignUp;
    }
}