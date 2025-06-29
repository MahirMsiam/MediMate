namespace Medimate
{
    partial class PatientLoginForm
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
            registerBtn = new Button();
            label4 = new Label();
            loginBtn = new Button();
            passwordTxtBox = new TextBox();
            label3 = new Label();
            emailTxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            logoPanel = new Panel();
            loginFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.White;
            loginFormPanel.Controls.Add(registerBtn);
            loginFormPanel.Controls.Add(label4);
            loginFormPanel.Controls.Add(loginBtn);
            loginFormPanel.Controls.Add(passwordTxtBox);
            loginFormPanel.Controls.Add(label3);
            loginFormPanel.Controls.Add(emailTxtBox);
            loginFormPanel.Controls.Add(label2);
            loginFormPanel.Controls.Add(label1);
            loginFormPanel.Controls.Add(logoPanel);
            loginFormPanel.Location = new Point(117, 154);
            loginFormPanel.Margin = new Padding(3, 4, 3, 4);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(427, 645);
            loginFormPanel.TabIndex = 0;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(266, 575);
            registerBtn.Margin = new Padding(3, 4, 3, 4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 39);
            registerBtn.TabIndex = 8;
            registerBtn.Text = "Sign Up";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 584);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't have any account?";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.LightCyan;
            loginBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.DeepSkyBlue;
            loginBtn.Location = new Point(135, 486);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(146, 46);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxtBox.Location = new Point(151, 361);
            passwordTxtBox.Margin = new Padding(3, 4, 3, 4);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(244, 27);
            passwordTxtBox.TabIndex = 5;
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
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxtBox.Location = new Point(151, 290);
            emailTxtBox.Margin = new Padding(3, 4, 3, 4);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(244, 27);
            emailTxtBox.TabIndex = 3;
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
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 170);
            label1.Name = "label1";
            label1.Size = new Size(188, 60);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back";
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
            // PatientLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(665, 941);
            Controls.Add(loginFormPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += PatientLoginForm_Load;
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginFormPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginBtn;
    }
}

