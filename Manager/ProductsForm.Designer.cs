namespace TechnicalProductsStore.Manager
{
    partial class ProductsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productCountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productEnterCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productEnterDataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remainingProductCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productCountryDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, productDescriptionDataGridViewTextBoxColumn, productEnterCountDataGridViewTextBoxColumn, productEnterDataDataGridViewTextBoxColumn, remainingProductCountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1544, 658);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // productCountryDataGridViewTextBoxColumn
            // 
            productCountryDataGridViewTextBoxColumn.DataPropertyName = "ProductCountry";
            productCountryDataGridViewTextBoxColumn.HeaderText = "ProductCountry";
            productCountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            productCountryDataGridViewTextBoxColumn.Name = "productCountryDataGridViewTextBoxColumn";
            productCountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            productPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            productPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            productDescriptionDataGridViewTextBoxColumn.Width = 180;
            // 
            // productEnterCountDataGridViewTextBoxColumn
            // 
            productEnterCountDataGridViewTextBoxColumn.DataPropertyName = "ProductEnterCount";
            productEnterCountDataGridViewTextBoxColumn.HeaderText = "ProductEnterCount";
            productEnterCountDataGridViewTextBoxColumn.MinimumWidth = 8;
            productEnterCountDataGridViewTextBoxColumn.Name = "productEnterCountDataGridViewTextBoxColumn";
            productEnterCountDataGridViewTextBoxColumn.Width = 180;
            // 
            // productEnterDataDataGridViewTextBoxColumn
            // 
            productEnterDataDataGridViewTextBoxColumn.DataPropertyName = "ProductEnterData";
            productEnterDataDataGridViewTextBoxColumn.HeaderText = "ProductEnterData";
            productEnterDataDataGridViewTextBoxColumn.MinimumWidth = 8;
            productEnterDataDataGridViewTextBoxColumn.Name = "productEnterDataDataGridViewTextBoxColumn";
            productEnterDataDataGridViewTextBoxColumn.Width = 180;
            // 
            // remainingProductCountDataGridViewTextBoxColumn
            // 
            remainingProductCountDataGridViewTextBoxColumn.DataPropertyName = "RemainingProductCount";
            remainingProductCountDataGridViewTextBoxColumn.HeaderText = "RemainingProductCount";
            remainingProductCountDataGridViewTextBoxColumn.MinimumWidth = 8;
            remainingProductCountDataGridViewTextBoxColumn.Name = "remainingProductCountDataGridViewTextBoxColumn";
            remainingProductCountDataGridViewTextBoxColumn.Width = 220;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Class.Product);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(525, 119);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(450, 450);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 658);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Name = "ProductsForm";
            Text = "ProductsForm";
            FormClosed += ProductsForm_FormClosed;
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productEnterCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productEnterDataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remainingProductCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}