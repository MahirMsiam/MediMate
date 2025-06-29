namespace MediMate
{
    partial class AdminHome
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
            label1 = new Label();
            Adminbtn = new Button();
            Pharmacist_btn = new Button();
            patient_btn = new Button();
            crossbtn = new Button();
            logout_btn = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Admin Home";
            // 
            // Adminbtn
            // 
            Adminbtn.Location = new Point(341, 113);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(149, 43);
            Adminbtn.TabIndex = 5;
            Adminbtn.Text = "Admin";
            Adminbtn.UseVisualStyleBackColor = true;
            Adminbtn.Click += Adminbtn_Click;
            // 
            // Pharmacist_btn
            // 
            Pharmacist_btn.Location = new Point(341, 234);
            Pharmacist_btn.Name = "Pharmacist_btn";
            Pharmacist_btn.Size = new Size(149, 43);
            Pharmacist_btn.TabIndex = 6;
            Pharmacist_btn.Text = "Pharmacist\n";
            Pharmacist_btn.UseVisualStyleBackColor = true;
            Pharmacist_btn.Click += Pharmacist_btn_Click;
            // 
            // patient_btn
            // 
            patient_btn.Location = new Point(341, 348);
            patient_btn.Name = "patient_btn";
            patient_btn.Size = new Size(149, 43);
            patient_btn.TabIndex = 7;
            patient_btn.Text = "Patient\n";
            patient_btn.UseVisualStyleBackColor = true;
            patient_btn.Click += patient_btn_Click;
            // 
            // crossbtn
            // 
            crossbtn.BackColor = SystemColors.ActiveCaption;
            crossbtn.Location = new Point(790, -1);
            crossbtn.Name = "crossbtn";
            crossbtn.Size = new Size(45, 39);
            crossbtn.TabIndex = 8;
            crossbtn.Text = "X";
            crossbtn.UseVisualStyleBackColor = false;
            crossbtn.Click += button4_Click;
            // 
            // logout_btn
            // 
            logout_btn.Location = new Point(341, 464);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(149, 43);
            logout_btn.TabIndex = 10;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(243, 448);
            pictureBox5.Margin = new Padding(5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(243, 332);
            pictureBox4.Margin = new Padding(5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(243, 218);
            pictureBox3.Margin = new Padding(5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(243, 101);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 19);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(833, 572);
            Controls.Add(logout_btn);
            Controls.Add(pictureBox5);
            Controls.Add(crossbtn);
            Controls.Add(patient_btn);
            Controls.Add(Pharmacist_btn);
            Controls.Add(Adminbtn);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "AdminHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.Button Pharmacist_btn;
        private System.Windows.Forms.Button patient_btn;
        private System.Windows.Forms.Button crossbtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button logout_btn;
    }
}

