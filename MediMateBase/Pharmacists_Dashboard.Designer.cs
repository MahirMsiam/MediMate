namespace MediMate
{
    partial class Pharmacists_Dashboard
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
            mngInventoryBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            dgvInventory = new DataGridView();
            panel2 = new Panel();
            doseInputPanel = new Panel();
            button1 = new Button();
            expTxtBox = new TextBox();
            label2 = new Label();
            stockTxtBox = new TextBox();
            dosageNameLabel = new Label();
            deleteBtn = new Button();
            updateBtn = new Button();
            medNameTxtBox = new TextBox();
            medNameLabel = new Label();
            dgvMngInventory = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel2.SuspendLayout();
            doseInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMngInventory).BeginInit();
            SuspendLayout();
            // 
            // mngInventoryBtn
            // 
            mngInventoryBtn.BackColor = Color.RoyalBlue;
            mngInventoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mngInventoryBtn.ForeColor = Color.White;
            mngInventoryBtn.Location = new Point(720, 12);
            mngInventoryBtn.Name = "mngInventoryBtn";
            mngInventoryBtn.Size = new Size(212, 65);
            mngInventoryBtn.TabIndex = 0;
            mngInventoryBtn.Text = "Manage Inventory";
            mngInventoryBtn.UseVisualStyleBackColor = false;
            mngInventoryBtn.Click += mngInventoryBtn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 94);
            label1.Name = "label1";
            label1.Size = new Size(185, 40);
            label1.TabIndex = 1;
            label1.Text = "Inventory List";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvInventory);
            panel1.Location = new Point(1, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 361);
            panel1.TabIndex = 2;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(941, 361);
            dgvInventory.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(doseInputPanel);
            panel2.Controls.Add(dgvMngInventory);
            panel2.Location = new Point(1, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 397);
            panel2.TabIndex = 3;
            // 
            // doseInputPanel
            // 
            doseInputPanel.BackColor = Color.Transparent;
            doseInputPanel.Controls.Add(button1);
            doseInputPanel.Controls.Add(expTxtBox);
            doseInputPanel.Controls.Add(label2);
            doseInputPanel.Controls.Add(stockTxtBox);
            doseInputPanel.Controls.Add(dosageNameLabel);
            doseInputPanel.Controls.Add(deleteBtn);
            doseInputPanel.Controls.Add(updateBtn);
            doseInputPanel.Controls.Add(medNameTxtBox);
            doseInputPanel.Controls.Add(medNameLabel);
            doseInputPanel.Location = new Point(659, 4);
            doseInputPanel.Margin = new Padding(3, 4, 3, 4);
            doseInputPanel.Name = "doseInputPanel";
            doseInputPanel.Size = new Size(365, 384);
            doseInputPanel.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(243, 293);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(93, 41);
            button1.TabIndex = 26;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // expTxtBox
            // 
            expTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expTxtBox.Location = new Point(11, 224);
            expTxtBox.Margin = new Padding(3, 4, 3, 4);
            expTxtBox.Multiline = true;
            expTxtBox.Name = "expTxtBox";
            expTxtBox.Size = new Size(344, 41);
            expTxtBox.TabIndex = 25;
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(11, 176);
            label2.Name = "label2";
            label2.Size = new Size(176, 44);
            label2.TabIndex = 24;
            label2.Text = "Expiry Date";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stockTxtBox
            // 
            stockTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockTxtBox.Location = new Point(11, 136);
            stockTxtBox.Margin = new Padding(3, 4, 3, 4);
            stockTxtBox.Multiline = true;
            stockTxtBox.Name = "stockTxtBox";
            stockTxtBox.Size = new Size(344, 36);
            stockTxtBox.TabIndex = 23;
            // 
            // dosageNameLabel
            // 
            dosageNameLabel.BackColor = Color.LightCyan;
            dosageNameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dosageNameLabel.ForeColor = Color.DeepSkyBlue;
            dosageNameLabel.Location = new Point(11, 93);
            dosageNameLabel.Name = "dosageNameLabel";
            dosageNameLabel.Size = new Size(176, 39);
            dosageNameLabel.TabIndex = 22;
            dosageNameLabel.Text = "Stock Quantity";
            dosageNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(131, 293);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(109, 41);
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
            updateBtn.Location = new Point(11, 293);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(114, 41);
            updateBtn.TabIndex = 20;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // medNameTxtBox
            // 
            medNameTxtBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameTxtBox.Location = new Point(11, 56);
            medNameTxtBox.Margin = new Padding(3, 4, 3, 4);
            medNameTxtBox.Multiline = true;
            medNameTxtBox.Name = "medNameTxtBox";
            medNameTxtBox.Size = new Size(344, 33);
            medNameTxtBox.TabIndex = 9;
            // 
            // medNameLabel
            // 
            medNameLabel.BackColor = Color.LightCyan;
            medNameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medNameLabel.ForeColor = Color.DeepSkyBlue;
            medNameLabel.Location = new Point(11, 12);
            medNameLabel.Name = "medNameLabel";
            medNameLabel.Size = new Size(156, 40);
            medNameLabel.TabIndex = 8;
            medNameLabel.Text = "Medicine Name";
            medNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvMngInventory
            // 
            dgvMngInventory.AllowUserToAddRows = false;
            dgvMngInventory.AllowUserToDeleteRows = false;
            dgvMngInventory.AllowUserToResizeColumns = false;
            dgvMngInventory.AllowUserToResizeRows = false;
            dgvMngInventory.BackgroundColor = Color.LightBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMngInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMngInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMngInventory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMngInventory.GridColor = Color.LightBlue;
            dgvMngInventory.Location = new Point(0, 4);
            dgvMngInventory.Margin = new Padding(3, 4, 3, 4);
            dgvMngInventory.Name = "dgvMngInventory";
            dgvMngInventory.ReadOnly = true;
            dgvMngInventory.RowHeadersVisible = false;
            dgvMngInventory.RowHeadersWidth = 51;
            dgvMngInventory.RowTemplate.Height = 24;
            dgvMngInventory.ScrollBars = ScrollBars.Vertical;
            dgvMngInventory.Size = new Size(653, 389);
            dgvMngInventory.TabIndex = 1;
            dgvMngInventory.CellClick += dgvMngInventory_CellClick;
            // 
            // Pharmacists_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 529);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(mngInventoryBtn);
            Name = "Pharmacists_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacists_Dashboard";
            Load += Pharmacists_Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel2.ResumeLayout(false);
            doseInputPanel.ResumeLayout(false);
            doseInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMngInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mngInventoryBtn;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvInventory;
        private Panel panel2;
        private DataGridView dgvMngInventory;
        private Panel doseInputPanel;
        private TextBox expTxtBox;
        private Label label2;
        private TextBox stockTxtBox;
        private Label dosageNameLabel;
        private Button deleteBtn;
        private Button updateBtn;
        private TextBox medNameTxtBox;
        private Label medNameLabel;
        private Button button1;
    }
}