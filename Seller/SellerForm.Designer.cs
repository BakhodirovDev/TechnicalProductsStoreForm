namespace TechnicalProductsStore.Seller
{
    partial class SellerForm
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
            Panel panel1;
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            productBindingSource = new BindingSource(components);
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            productBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productCountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remainingProductCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(243, 110);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1125, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 265);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(872, 27);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(22, 18);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Class.Product);
            // 
            // panel2
            // 
            panel2.Location = new Point(1125, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 236);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productCountryDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, productDescriptionDataGridViewTextBoxColumn, remainingProductCountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource1;
            dataGridView1.Location = new Point(1, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 516);
            dataGridView1.TabIndex = 6;
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Class.Product);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCountryDataGridViewTextBoxColumn
            // 
            productCountryDataGridViewTextBoxColumn.DataPropertyName = "ProductCountry";
            productCountryDataGridViewTextBoxColumn.HeaderText = "Country";
            productCountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            productCountryDataGridViewTextBoxColumn.Name = "productCountryDataGridViewTextBoxColumn";
            productCountryDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            productPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            productDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            productDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // remainingProductCountDataGridViewTextBoxColumn
            // 
            remainingProductCountDataGridViewTextBoxColumn.DataPropertyName = "RemainingProductCount";
            remainingProductCountDataGridViewTextBoxColumn.HeaderText = "RemainingCount";
            remainingProductCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            remainingProductCountDataGridViewTextBoxColumn.Name = "remainingProductCountDataGridViewTextBoxColumn";
            remainingProductCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 602);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "SellerForm";
            Text = "SellerForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private BindingSource productBindingSource;
        private Panel panel2;
        private DataGridView dataGridView1;
        private BindingSource productBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remainingProductCountDataGridViewTextBoxColumn;
    }
}