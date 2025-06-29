namespace Medimate
{
    partial class Manage_Dosage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nameLabel = new Label();
            logoPanel = new Panel();
            pharmacyTablePanel = new Panel();
            dgvDosages = new DataGridView();
            doseInputPanel = new Panel();
            durationDaysTxtBox = new TextBox();
            label2 = new Label();
            dosageNameTxtBox = new TextBox();
            dosageNameLabel = new Label();
            deleteBtn = new Button();
            updateBtn = new Button();
            medNameTxtBox = new TextBox();
            medNameLabel = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            backBtn = new Button();
            Routine_Id = new DataGridViewTextBoxColumn();
            Medicine_Name = new DataGridViewTextBoxColumn();
            Dosage_Time = new DataGridViewTextBoxColumn();
            Duration_Days = new DataGridViewTextBoxColumn();
            pharmacyTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDosages).BeginInit();
            doseInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.DarkBlue;
            nameLabel.Location = new Point(710, 1);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(222, 118);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Patient's Dashboard";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Click += nameLabel_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackgroundImageLayout = ImageLayout.Stretch;
            logoPanel.Location = new Point(1, 1);
            logoPanel.Margin = new Padding(3, 4, 3, 4);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(228, 118);
            logoPanel.TabIndex = 17;
            // 
            // pharmacyTablePanel
            // 
            pharmacyTablePanel.Controls.Add(dgvDosages);
            pharmacyTablePanel.Location = new Point(1, 134);
            pharmacyTablePanel.Margin = new Padding(3, 4, 3, 4);
            pharmacyTablePanel.Name = "pharmacyTablePanel";
            pharmacyTablePanel.Size = new Size(522, 454);
            pharmacyTablePanel.TabIndex = 20;
            // 
            // dgvDosages
            // 
            dgvDosages.AllowUserToAddRows = false;
            dgvDosages.AllowUserToDeleteRows = false;
            dgvDosages.AllowUserToResizeColumns = false;
            dgvDosages.AllowUserToResizeRows = false;
            dgvDosages.BackgroundColor = Color.LightBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDosages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDosages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDosages.Columns.AddRange(new DataGridViewColumn[] { Routine_Id, Medicine_Name, Dosage_Time, Duration_Days });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDosages.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDosages.Dock = DockStyle.Fill;
            dgvDosages.GridColor = Color.LightBlue;
            dgvDosages.Location = new Point(0, 0);
            dgvDosages.Margin = new Padding(3, 4, 3, 4);
            dgvDosages.Name = "dgvDosages";
            dgvDosages.ReadOnly = true;
            dgvDosages.RowHeadersVisible = false;
            dgvDosages.RowHeadersWidth = 51;
            dgvDosages.RowTemplate.Height = 24;
            dgvDosages.ScrollBars = ScrollBars.Vertical;
            dgvDosages.Size = new Size(522, 454);
            dgvDosages.TabIndex = 0;
            dgvDosages.CellClick += dgvDosages_CellClick;
            // 
            // doseInputPanel
            // 
            doseInputPanel.BackColor = Color.Transparent;
            doseInputPanel.Controls.Add(durationDaysTxtBox);
            doseInputPanel.Controls.Add(label2);
            doseInputPanel.Controls.Add(dosageNameTxtBox);
            doseInputPanel.Controls.Add(dosageNameLabel);
            doseInputPanel.Controls.Add(deleteBtn);
            doseInputPanel.Controls.Add(updateBtn);
            doseInputPanel.Controls.Add(medNameTxtBox);
            doseInputPanel.Controls.Add(medNameLabel);
            doseInputPanel.Location = new Point(529, 134);
            doseInputPanel.Margin = new Padding(3, 4, 3, 4);
            doseInputPanel.Name = "doseInputPanel";
            doseInputPanel.Size = new Size(403, 514);
            doseInputPanel.TabIndex = 21;
            // 
            // durationDaysTxtBox
            // 
            durationDaysTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationDaysTxtBox.Location = new Point(11, 388);
            durationDaysTxtBox.Margin = new Padding(3, 4, 3, 4);
            durationDaysTxtBox.Multiline = true;
            durationDaysTxtBox.Name = "durationDaysTxtBox";
            durationDaysTxtBox.Size = new Size(381, 54);
            durationDaysTxtBox.TabIndex = 25;
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(11, 316);
            label2.Name = "label2";
            label2.Size = new Size(185, 55);
            label2.TabIndex = 24;
            label2.Text = "Duration Days";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dosageNameTxtBox
            // 
            dosageNameTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dosageNameTxtBox.Location = new Point(11, 240);
            dosageNameTxtBox.Margin = new Padding(3, 4, 3, 4);
            dosageNameTxtBox.Multiline = true;
            dosageNameTxtBox.Name = "dosageNameTxtBox";
            dosageNameTxtBox.Size = new Size(381, 54);
            dosageNameTxtBox.TabIndex = 23;
            // 
            // dosageNameLabel
            // 
            dosageNameLabel.BackColor = Color.LightCyan;
            dosageNameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dosageNameLabel.ForeColor = Color.DeepSkyBlue;
            dosageNameLabel.Location = new Point(11, 169);
            dosageNameLabel.Name = "dosageNameLabel";
            dosageNameLabel.Size = new Size(185, 55);
            dosageNameLabel.TabIndex = 22;
            dosageNameLabel.Text = "Dosage Time";
            dosageNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(210, 454);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(146, 41);
            deleteBtn.TabIndex = 21;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.DarkBlue;
            updateBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(41, 454);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(146, 41);
            updateBtn.TabIndex = 20;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // medNameTxtBox
            // 
            medNameTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameTxtBox.Location = new Point(11, 98);
            medNameTxtBox.Margin = new Padding(3, 4, 3, 4);
            medNameTxtBox.Multiline = true;
            medNameTxtBox.Name = "medNameTxtBox";
            medNameTxtBox.Size = new Size(381, 54);
            medNameTxtBox.TabIndex = 9;
            // 
            // medNameLabel
            // 
            medNameLabel.BackColor = Color.LightCyan;
            medNameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medNameLabel.ForeColor = Color.DeepSkyBlue;
            medNameLabel.Location = new Point(11, 26);
            medNameLabel.Name = "medNameLabel";
            medNameLabel.Size = new Size(185, 55);
            medNameLabel.TabIndex = 8;
            medNameLabel.Text = "Medicine Name";
            medNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(654, 34);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(265, 30);
            label3.Name = "label3";
            label3.Size = new Size(325, 62);
            label3.TabIndex = 26;
            label3.Text = "Manage All Your Dosages";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.LightCyan;
            backBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.DeepSkyBlue;
            backBtn.Location = new Point(12, 595);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(146, 46);
            backBtn.TabIndex = 27;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // Routine_Id
            // 
            Routine_Id.DataPropertyName = "id";
            Routine_Id.HeaderText = "ID";
            Routine_Id.MinimumWidth = 6;
            Routine_Id.Name = "Routine_Id";
            Routine_Id.ReadOnly = true;
            Routine_Id.Width = 50;
            // 
            // Medicine_Name
            // 
            Medicine_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Medicine_Name.DataPropertyName = "Medicine_Name";
            Medicine_Name.HeaderText = "Medicine Name";
            Medicine_Name.MinimumWidth = 6;
            Medicine_Name.Name = "Medicine_Name";
            Medicine_Name.ReadOnly = true;
            Medicine_Name.Resizable = DataGridViewTriState.False;
            // 
            // Dosage_Time
            // 
            Dosage_Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dosage_Time.DataPropertyName = "Dosage_Time";
            Dosage_Time.HeaderText = "Dosage Time";
            Dosage_Time.MinimumWidth = 6;
            Dosage_Time.Name = "Dosage_Time";
            Dosage_Time.ReadOnly = true;
            Dosage_Time.Resizable = DataGridViewTriState.False;
            // 
            // Duration_Days
            // 
            Duration_Days.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Duration_Days.DataPropertyName = "Duration_Days";
            Duration_Days.HeaderText = "Duration Days";
            Duration_Days.MinimumWidth = 6;
            Duration_Days.Name = "Duration_Days";
            Duration_Days.ReadOnly = true;
            Duration_Days.Resizable = DataGridViewTriState.False;
            // 
            // Manage_Dosage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 648);
            Controls.Add(backBtn);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(doseInputPanel);
            Controls.Add(pharmacyTablePanel);
            Controls.Add(nameLabel);
            Controls.Add(logoPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manage_Dosage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Dosage";
            Load += Manage_Dosage_Load;
            pharmacyTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDosages).EndInit();
            doseInputPanel.ResumeLayout(false);
            doseInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel pharmacyTablePanel;
        private System.Windows.Forms.DataGridView dgvDosages;
        private System.Windows.Forms.Panel doseInputPanel;
        private System.Windows.Forms.TextBox medNameTxtBox;
        private System.Windows.Forms.Label medNameLabel;
        private System.Windows.Forms.TextBox durationDaysTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dosageNameTxtBox;
        private System.Windows.Forms.Label dosageNameLabel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backBtn;
        private DataGridViewTextBoxColumn Routine_Id;
        private DataGridViewTextBoxColumn Medicine_Name;
        private DataGridViewTextBoxColumn Dosage_Time;
        private DataGridViewTextBoxColumn Duration_Days;
    }
}