namespace TechnicalProductsStore.Manager
{
    partial class SellerHistory
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            sellerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sellerSignInTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sellerSignOutTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sellerSaleTotalCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sellerSaleTotalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            historyWorkingBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            historySaleBindingSource = new BindingSource(components);
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonOK = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historyWorkingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historySaleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sellerIDDataGridViewTextBoxColumn, sellerSignInTimeDataGridViewTextBoxColumn, sellerSignOutTimeDataGridViewTextBoxColumn, sellerSaleTotalCountDataGridViewTextBoxColumn, sellerSaleTotalPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = historyWorkingBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(884, 675);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // sellerIDDataGridViewTextBoxColumn
            // 
            sellerIDDataGridViewTextBoxColumn.DataPropertyName = "SellerID";
            sellerIDDataGridViewTextBoxColumn.HeaderText = "SellerID";
            sellerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            sellerIDDataGridViewTextBoxColumn.Name = "sellerIDDataGridViewTextBoxColumn";
            sellerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerSignInTimeDataGridViewTextBoxColumn
            // 
            sellerSignInTimeDataGridViewTextBoxColumn.DataPropertyName = "SellerSignInTime";
            sellerSignInTimeDataGridViewTextBoxColumn.HeaderText = "SellerSignInTime";
            sellerSignInTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            sellerSignInTimeDataGridViewTextBoxColumn.Name = "sellerSignInTimeDataGridViewTextBoxColumn";
            sellerSignInTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerSignOutTimeDataGridViewTextBoxColumn
            // 
            sellerSignOutTimeDataGridViewTextBoxColumn.DataPropertyName = "SellerSignOutTime";
            sellerSignOutTimeDataGridViewTextBoxColumn.HeaderText = "SellerSignOutTime";
            sellerSignOutTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            sellerSignOutTimeDataGridViewTextBoxColumn.Name = "sellerSignOutTimeDataGridViewTextBoxColumn";
            sellerSignOutTimeDataGridViewTextBoxColumn.Width = 170;
            // 
            // sellerSaleTotalCountDataGridViewTextBoxColumn
            // 
            sellerSaleTotalCountDataGridViewTextBoxColumn.DataPropertyName = "SellerSaleTotalCount";
            sellerSaleTotalCountDataGridViewTextBoxColumn.HeaderText = "SellerSaleTotalCount";
            sellerSaleTotalCountDataGridViewTextBoxColumn.MinimumWidth = 8;
            sellerSaleTotalCountDataGridViewTextBoxColumn.Name = "sellerSaleTotalCountDataGridViewTextBoxColumn";
            sellerSaleTotalCountDataGridViewTextBoxColumn.Width = 180;
            // 
            // sellerSaleTotalPriceDataGridViewTextBoxColumn
            // 
            sellerSaleTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "SellerSaleTotalPrice";
            sellerSaleTotalPriceDataGridViewTextBoxColumn.HeaderText = "SellerSaleTotalPrice";
            sellerSaleTotalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            sellerSaleTotalPriceDataGridViewTextBoxColumn.Name = "sellerSaleTotalPriceDataGridViewTextBoxColumn";
            sellerSaleTotalPriceDataGridViewTextBoxColumn.Width = 170;
            // 
            // historyWorkingBindingSource
            // 
            historyWorkingBindingSource.DataSource = typeof(Class.HistoryWorking);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Class.Product);
            // 
            // historySaleBindingSource
            // 
            historySaleBindingSource.DataSource = typeof(Class.HistorySale);
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dateTimePickerStart.Location = new Point(905, 55);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(415, 35);
            dateTimePickerStart.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dateTimePickerEnd.Location = new Point(905, 146);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(415, 35);
            dateTimePickerEnd.TabIndex = 3;
            // 
            // buttonOK
            // 
            buttonOK.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            buttonOK.Location = new Point(1031, 212);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(166, 46);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "Search";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            label2.Location = new Point(905, 23);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 7;
            label2.Text = "Start Day";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            label3.Location = new Point(905, 114);
            label3.Name = "label3";
            label3.Size = new Size(98, 29);
            label3.TabIndex = 8;
            label3.Text = "End Day";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(905, 564);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(1183, 564);
            label4.Name = "label4";
            label4.Size = new Size(0, 30);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(905, 620);
            label5.Name = "label5";
            label5.Size = new Size(0, 30);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(1124, 620);
            label6.Name = "label6";
            label6.Size = new Size(0, 30);
            label6.TabIndex = 12;
            // 
            // SellerHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 674);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonOK);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dataGridView1);
            Name = "SellerHistory";
            Text = "SellerHistory";
            FormClosed += SellerHistory_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)historyWorkingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)historySaleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource historySaleBindingSource;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellerSignInTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellerSignOutTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellerSaleTotalCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellerSaleTotalPriceDataGridViewTextBoxColumn;
        private BindingSource historyWorkingBindingSource;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonOK;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}