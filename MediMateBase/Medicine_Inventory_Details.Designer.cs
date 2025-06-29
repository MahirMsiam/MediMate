namespace Medimate
{
    partial class Medicine_Inventory_Details
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
            pharmacyTablePanel = new Panel();
            dgvDosages = new DataGridView();
            pictureBox1 = new PictureBox();
            allBtn = new Button();
            searchBtn = new Button();
            nameLabel = new Label();
            logoPanel = new Panel();
            searchTxtBox = new TextBox();
            label1 = new Label();
            backBtn = new Button();
            pharmacyTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDosages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pharmacyTablePanel
            // 
            pharmacyTablePanel.Controls.Add(dgvDosages);
            pharmacyTablePanel.Location = new Point(1, 192);
            pharmacyTablePanel.Margin = new Padding(3, 4, 3, 4);
            pharmacyTablePanel.Name = "pharmacyTablePanel";
            pharmacyTablePanel.Size = new Size(931, 384);
            pharmacyTablePanel.TabIndex = 3;
            // 
            // dgvDosages
            // 
            dgvDosages.AllowUserToAddRows = false;
            dgvDosages.AllowUserToDeleteRows = false;
            dgvDosages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvDosages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDosages.Dock = DockStyle.Fill;
            dgvDosages.Location = new Point(0, 0);
            dgvDosages.Name = "dgvDosages";
            dgvDosages.ReadOnly = true;
            dgvDosages.RowHeadersWidth = 51;
            dgvDosages.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDosages.Size = new Size(931, 384);
            dgvDosages.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(654, 31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // allBtn
            // 
            allBtn.BackColor = Color.LightCyan;
            allBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allBtn.ForeColor = Color.DeepSkyBlue;
            allBtn.Location = new Point(235, 64);
            allBtn.Margin = new Padding(3, 4, 3, 4);
            allBtn.Name = "allBtn";
            allBtn.Size = new Size(203, 55);
            allBtn.TabIndex = 28;
            allBtn.Text = "All Phramacies";
            allBtn.UseVisualStyleBackColor = false;
            allBtn.Click += allBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.LightCyan;
            searchBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = Color.DeepSkyBlue;
            searchBtn.Location = new Point(498, 1);
            searchBtn.Margin = new Padding(3, 4, 3, 4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(139, 55);
            searchBtn.TabIndex = 27;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.DarkBlue;
            nameLabel.Location = new Point(710, 1);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(222, 118);
            nameLabel.TabIndex = 25;
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
            logoPanel.TabIndex = 26;
            logoPanel.Paint += logoPanel_Paint;
            // 
            // searchTxtBox
            // 
            searchTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxtBox.Location = new Point(234, 4);
            searchTxtBox.Margin = new Padding(3, 4, 3, 4);
            searchTxtBox.Multiline = true;
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.Size = new Size(258, 52);
            searchTxtBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(260, 129);
            label1.Name = "label1";
            label1.Size = new Size(404, 60);
            label1.TabIndex = 31;
            label1.Text = "Inventories Based On Your Location";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.LightCyan;
            backBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.DeepSkyBlue;
            backBtn.Location = new Point(12, 584);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(139, 55);
            backBtn.TabIndex = 33;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // Medicine_Inventory_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 648);
            Controls.Add(backBtn);
            Controls.Add(label1);
            Controls.Add(searchTxtBox);
            Controls.Add(pictureBox1);
            Controls.Add(allBtn);
            Controls.Add(searchBtn);
            Controls.Add(nameLabel);
            Controls.Add(logoPanel);
            Controls.Add(pharmacyTablePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Medicine_Inventory_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicine Inventory Details";
            Load += Medicine_Inventory_Details_Load;
            pharmacyTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDosages).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pharmacyTablePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory_Location;
        private System.Windows.Forms.Button backBtn;
        private DataGridView dgvDosages;
    }
}