namespace Medimate
{
    partial class PatientSignupForm
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
            loginFormPanel = new Panel();
            passwordTxtBox = new TextBox();
            label7 = new Label();
            locationTxtBox = new TextBox();
            label5 = new Label();
            addressTxtBox = new TextBox();
            label6 = new Label();
            loginBtn = new Button();
            label4 = new Label();
            signUpBtn = new Button();
            emailTxtBox = new TextBox();
            label3 = new Label();
            nameTxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            logoPanel = new Panel();
            loginFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.White;
            loginFormPanel.Controls.Add(passwordTxtBox);
            loginFormPanel.Controls.Add(label7);
            loginFormPanel.Controls.Add(locationTxtBox);
            loginFormPanel.Controls.Add(label5);
            loginFormPanel.Controls.Add(addressTxtBox);
            loginFormPanel.Controls.Add(label6);
            loginFormPanel.Controls.Add(loginBtn);
            loginFormPanel.Controls.Add(label4);
            loginFormPanel.Controls.Add(signUpBtn);
            loginFormPanel.Controls.Add(emailTxtBox);
            loginFormPanel.Controls.Add(label3);
            loginFormPanel.Controls.Add(nameTxtBox);
            loginFormPanel.Controls.Add(label2);
            loginFormPanel.Controls.Add(label1);
            loginFormPanel.Controls.Add(logoPanel);
            loginFormPanel.Location = new Point(133, 44);
            loginFormPanel.Margin = new Padding(3, 4, 3, 4);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(422, 830);
            loginFormPanel.TabIndex = 1;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxtBox.Location = new Point(151, 569);
            passwordTxtBox.Margin = new Padding(3, 4, 3, 4);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(244, 27);
            passwordTxtBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.BackColor = Color.LightCyan;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DeepSkyBlue;
            label7.Location = new Point(25, 569);
            label7.Name = "label7";
            label7.Size = new Size(120, 34);
            label7.TabIndex = 13;
            label7.Text = "Password";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // locationTxtBox
            // 
            locationTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locationTxtBox.Location = new Point(151, 502);
            locationTxtBox.Margin = new Padding(3, 4, 3, 4);
            locationTxtBox.Name = "locationTxtBox";
            locationTxtBox.Size = new Size(244, 27);
            locationTxtBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.BackColor = Color.LightCyan;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(25, 502);
            label5.Name = "label5";
            label5.Size = new Size(120, 34);
            label5.TabIndex = 11;
            label5.Text = "Location";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addressTxtBox
            // 
            addressTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTxtBox.Location = new Point(151, 431);
            addressTxtBox.Margin = new Padding(3, 4, 3, 4);
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(244, 27);
            addressTxtBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(25, 431);
            label6.Name = "label6";
            label6.Size = new Size(120, 34);
            label6.TabIndex = 9;
            label6.Text = "Address";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(261, 756);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 39);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 765);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't have any account?";
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.LightCyan;
            signUpBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpBtn.ForeColor = Color.DeepSkyBlue;
            signUpBtn.Location = new Point(130, 668);
            signUpBtn.Margin = new Padding(3, 4, 3, 4);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(146, 46);
            signUpBtn.TabIndex = 6;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxtBox.Location = new Point(151, 361);
            emailTxtBox.Margin = new Padding(3, 4, 3, 4);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(244, 27);
            emailTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(25, 361);
            label3.Name = "label3";
            label3.Size = new Size(120, 34);
            label3.TabIndex = 4;
            label3.Text = "Email";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxtBox.Location = new Point(151, 290);
            nameTxtBox.Margin = new Padding(3, 4, 3, 4);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(244, 27);
            nameTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(25, 290);
            label2.Name = "label2";
            label2.Size = new Size(120, 34);
            label2.TabIndex = 2;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 170);
            label1.Name = "label1";
            label1.Size = new Size(188, 60);
            label1.TabIndex = 1;
            label1.Text = "Join Us";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoPanel
            // 
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Location = new Point(2, 1);
            logoPanel.Margin = new Padding(3, 4, 3, 4);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(424, 165);
            logoPanel.TabIndex = 0;
            // 
            // PatientSignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(682, 941);
            Controls.Add(loginFormPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientSignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            Load += PatientSignupForm_Load;
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginFormPanel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label7;
    }
}