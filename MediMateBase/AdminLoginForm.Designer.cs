namespace MediMate
{
    partial class AdminLoginForm
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
            txtId = new TextBox();
            txtPassword = new TextBox();
            Pha_id = new Label();
            label3 = new Label();
            label1 = new Label();
            crossbtn = new Button();
            cancel_btn = new Button();
            login_btn = new Button();
            signUp_btn = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(156, 190);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(329, 49);
            txtId.TabIndex = 37;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(156, 284);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(329, 38);
            txtPassword.TabIndex = 40;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Pha_id
            // 
            Pha_id.AutoSize = true;
            Pha_id.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pha_id.Location = new Point(80, 206);
            Pha_id.Name = "Pha_id";
            Pha_id.Size = new Size(24, 18);
            Pha_id.TabIndex = 41;
            Pha_id.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 309);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 42;
            label3.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 122);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 44;
            label1.Text = "Admin Login";
            // 
            // crossbtn
            // 
            crossbtn.BackColor = SystemColors.ActiveCaption;
            crossbtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crossbtn.ForeColor = Color.Red;
            crossbtn.Location = new Point(505, 0);
            crossbtn.Margin = new Padding(3, 4, 3, 4);
            crossbtn.Name = "crossbtn";
            crossbtn.Size = new Size(45, 49);
            crossbtn.TabIndex = 50;
            crossbtn.Text = "X";
            crossbtn.UseVisualStyleBackColor = false;
            crossbtn.Click += crossbtn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(129, 430);
            cancel_btn.Margin = new Padding(3, 4, 3, 4);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(135, 66);
            cancel_btn.TabIndex = 51;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(325, 436);
            login_btn.Margin = new Padding(3, 4, 3, 4);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(139, 60);
            login_btn.TabIndex = 52;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // signUp_btn
            // 
            signUp_btn.Location = new Point(343, 626);
            signUp_btn.Margin = new Padding(3, 4, 3, 4);
            signUp_btn.Name = "signUp_btn";
            signUp_btn.Size = new Size(195, 71);
            signUp_btn.TabIndex = 53;
            signUp_btn.Text = "Sign Up";
            signUp_btn.UseVisualStyleBackColor = true;
            signUp_btn.Click += signUp_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 661);
            label2.Name = "label2";
            label2.Size = new Size(290, 20);
            label2.TabIndex = 54;
            label2.Text = "If you don't have account then sign up";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(170, 85);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(156, 339);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 24);
            checkBox1.TabIndex = 55;
            checkBox1.Text = "Show pass";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(550, 724);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(signUp_btn);
            Controls.Add(login_btn);
            Controls.Add(cancel_btn);
            Controls.Add(crossbtn);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(Pha_id);
            Controls.Add(txtPassword);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login From";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Pha_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button crossbtn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}