namespace MediMate
{
    partial class AdminSignUpForm
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
            checkBox1 = new CheckBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            l_name = new Label();
            Pha_id = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            crossbtn = new Button();
            SignUp_btn = new Button();
            Back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(38, 631);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 24);
            checkBox1.TabIndex = 53;
            checkBox1.Text = "Show pass";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(37, 576);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(336, 38);
            txtPassword.TabIndex = 52;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(37, 411);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(336, 49);
            txtEmail.TabIndex = 51;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(38, 269);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(337, 49);
            txtName.TabIndex = 50;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(37, 142);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(336, 49);
            txtId.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 550);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 48;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 385);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 47;
            label2.Text = "Email";
            // 
            // l_name
            // 
            l_name.AutoSize = true;
            l_name.BackColor = SystemColors.GradientActiveCaption;
            l_name.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_name.Location = new Point(35, 242);
            l_name.Name = "l_name";
            l_name.Size = new Size(52, 18);
            l_name.TabIndex = 46;
            l_name.Text = "Name";
            // 
            // Pha_id
            // 
            Pha_id.AutoSize = true;
            Pha_id.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pha_id.Location = new Point(35, 116);
            Pha_id.Name = "Pha_id";
            Pha_id.Size = new Size(24, 18);
            Pha_id.TabIndex = 45;
            Pha_id.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 44;
            label1.Text = "Admin Sign Up";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(26, 36);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // crossbtn
            // 
            crossbtn.BackColor = SystemColors.ActiveCaption;
            crossbtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crossbtn.ForeColor = Color.Red;
            crossbtn.Location = new Point(495, 1);
            crossbtn.Margin = new Padding(3, 4, 3, 4);
            crossbtn.Name = "crossbtn";
            crossbtn.Size = new Size(45, 49);
            crossbtn.TabIndex = 54;
            crossbtn.Text = "X";
            crossbtn.UseVisualStyleBackColor = false;
            // 
            // SignUp_btn
            // 
            SignUp_btn.Location = new Point(294, 714);
            SignUp_btn.Margin = new Padding(3, 4, 3, 4);
            SignUp_btn.Name = "SignUp_btn";
            SignUp_btn.Size = new Size(149, 54);
            SignUp_btn.TabIndex = 55;
            SignUp_btn.Text = "Sign Up";
            SignUp_btn.UseVisualStyleBackColor = true;
            SignUp_btn.Click += SignUp_btn_Click;
            // 
            // Back_btn
            // 
            Back_btn.Location = new Point(38, 714);
            Back_btn.Margin = new Padding(3, 4, 3, 4);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(149, 54);
            Back_btn.TabIndex = 56;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = true;
            Back_btn.Click += Back_btn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(539, 841);
            Controls.Add(Back_btn);
            Controls.Add(SignUp_btn);
            Controls.Add(crossbtn);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(l_name);
            Controls.Add(Pha_id);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label Pha_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button crossbtn;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}