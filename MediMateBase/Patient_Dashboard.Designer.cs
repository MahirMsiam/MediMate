namespace Medimate
{
    partial class Patient_Dashboard
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
            logoPanel = new Panel();
            nameLabel = new Label();
            doseInputPanel = new Panel();
            label4 = new Label();
            label3 = new Label();
            durationTxtBox = new TextBox();
            submitBtn = new Button();
            doseTimeTxtBox = new TextBox();
            medNameTxtBox = new TextBox();
            medNameLabel = new Label();
            label1 = new Label();
            pharmacyTablePanel = new Panel();
            dgvDosages = new DataGridView();
            mngDsgBtn = new Button();
            showBtn = new Button();
            logoutBtn = new Button();
            pictureBox1 = new PictureBox();
            doseInputPanel.SuspendLayout();
            pharmacyTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDosages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logoPanel
            // 
            logoPanel.BackgroundImageLayout = ImageLayout.Stretch;
            logoPanel.Location = new Point(0, 4);
            logoPanel.Margin = new Padding(3, 4, 3, 4);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(228, 125);
            logoPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.DarkBlue;
            nameLabel.Location = new Point(709, 4);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(222, 118);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Patient's Dashboard";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Click += nameLabel_Click;
            // 
            // doseInputPanel
            // 
            doseInputPanel.BackColor = Color.Transparent;
            doseInputPanel.Controls.Add(label4);
            doseInputPanel.Controls.Add(label3);
            doseInputPanel.Controls.Add(durationTxtBox);
            doseInputPanel.Controls.Add(submitBtn);
            doseInputPanel.Controls.Add(doseTimeTxtBox);
            doseInputPanel.Controls.Add(medNameTxtBox);
            doseInputPanel.Controls.Add(medNameLabel);
            doseInputPanel.Controls.Add(label1);
            doseInputPanel.Location = new Point(0, 141);
            doseInputPanel.Margin = new Padding(3, 4, 3, 4);
            doseInputPanel.Name = "doseInputPanel";
            doseInputPanel.Size = new Size(455, 506);
            doseInputPanel.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(12, 284);
            label4.Name = "label4";
            label4.Size = new Size(160, 34);
            label4.TabIndex = 16;
            label4.Text = "Duration (Days)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(160, 34);
            label3.TabIndex = 15;
            label3.Text = "Dosage Time";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // durationTxtBox
            // 
            durationTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationTxtBox.Location = new Point(192, 284);
            durationTxtBox.Margin = new Padding(3, 4, 3, 4);
            durationTxtBox.Name = "durationTxtBox";
            durationTxtBox.Size = new Size(244, 27);
            durationTxtBox.TabIndex = 14;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.LightCyan;
            submitBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = Color.DeepSkyBlue;
            submitBtn.Location = new Point(147, 398);
            submitBtn.Margin = new Padding(3, 4, 3, 4);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(146, 46);
            submitBtn.TabIndex = 12;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // doseTimeTxtBox
            // 
            doseTimeTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doseTimeTxtBox.Location = new Point(192, 216);
            doseTimeTxtBox.Margin = new Padding(3, 4, 3, 4);
            doseTimeTxtBox.Name = "doseTimeTxtBox";
            doseTimeTxtBox.Size = new Size(244, 27);
            doseTimeTxtBox.TabIndex = 11;
            // 
            // medNameTxtBox
            // 
            medNameTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameTxtBox.Location = new Point(192, 145);
            medNameTxtBox.Margin = new Padding(3, 4, 3, 4);
            medNameTxtBox.Name = "medNameTxtBox";
            medNameTxtBox.Size = new Size(244, 27);
            medNameTxtBox.TabIndex = 9;
            // 
            // medNameLabel
            // 
            medNameLabel.BackColor = Color.LightCyan;
            medNameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medNameLabel.ForeColor = Color.DeepSkyBlue;
            medNameLabel.Location = new Point(12, 145);
            medNameLabel.Name = "medNameLabel";
            medNameLabel.Size = new Size(160, 34);
            medNameLabel.TabIndex = 8;
            medNameLabel.Text = "Medicine Name";
            medNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(66, 41);
            label1.Name = "label1";
            label1.Size = new Size(325, 60);
            label1.TabIndex = 7;
            label1.Text = "Enter Your Medicine Dose Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pharmacyTablePanel
            // 
            pharmacyTablePanel.Controls.Add(dgvDosages);
            pharmacyTablePanel.Location = new Point(476, 141);
            pharmacyTablePanel.Margin = new Padding(3, 4, 3, 4);
            pharmacyTablePanel.Name = "pharmacyTablePanel";
            pharmacyTablePanel.Size = new Size(455, 444);
            pharmacyTablePanel.TabIndex = 2;
            // 
            // dgvDosages
            // 
            dgvDosages.AllowUserToAddRows = false;
            dgvDosages.AllowUserToDeleteRows = false;
            dgvDosages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDosages.Dock = DockStyle.Fill;
            dgvDosages.Location = new Point(0, 0);
            dgvDosages.Name = "dgvDosages";
            dgvDosages.ReadOnly = true;
            dgvDosages.RowHeadersWidth = 51;
            dgvDosages.Size = new Size(455, 444);
            dgvDosages.TabIndex = 0;
            // 
            // mngDsgBtn
            // 
            mngDsgBtn.BackColor = Color.LightCyan;
            mngDsgBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mngDsgBtn.ForeColor = Color.DeepSkyBlue;
            mngDsgBtn.Location = new Point(247, 4);
            mngDsgBtn.Margin = new Padding(3, 4, 3, 4);
            mngDsgBtn.Name = "mngDsgBtn";
            mngDsgBtn.Size = new Size(208, 55);
            mngDsgBtn.TabIndex = 14;
            mngDsgBtn.Text = "Manage Dosages";
            mngDsgBtn.UseVisualStyleBackColor = false;
            mngDsgBtn.Click += mngDsgBtn_Click;
            // 
            // showBtn
            // 
            showBtn.BackColor = Color.LightCyan;
            showBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showBtn.ForeColor = Color.DeepSkyBlue;
            showBtn.Location = new Point(247, 66);
            showBtn.Margin = new Padding(3, 4, 3, 4);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(211, 55);
            showBtn.TabIndex = 15;
            showBtn.Text = "Show Phramacies";
            showBtn.UseVisualStyleBackColor = false;
            showBtn.Click += showBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.LightCyan;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.DeepSkyBlue;
            logoutBtn.Location = new Point(775, 592);
            logoutBtn.Margin = new Padding(3, 4, 3, 4);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(146, 46);
            logoutBtn.TabIndex = 17;
            logoutBtn.Text = "LogOut";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(653, 34);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Patient_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 648);
            Controls.Add(pictureBox1);
            Controls.Add(logoutBtn);
            Controls.Add(showBtn);
            Controls.Add(mngDsgBtn);
            Controls.Add(pharmacyTablePanel);
            Controls.Add(doseInputPanel);
            Controls.Add(nameLabel);
            Controls.Add(logoPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patient_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Dashboard";
            Load += Patient_Dashboard_Load;
            doseInputPanel.ResumeLayout(false);
            doseInputPanel.PerformLayout();
            pharmacyTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDosages).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel doseInputPanel;
        private System.Windows.Forms.Panel pharmacyTablePanel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox doseTimeTxtBox;
        private System.Windows.Forms.TextBox medNameTxtBox;
        private System.Windows.Forms.Label medNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox durationTxtBox;
        private System.Windows.Forms.Button mngDsgBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataGridView dgvDosages;
    }
}