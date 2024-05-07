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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            productBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productCountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remainingProductCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource1 = new BindingSource(components);
            panel3 = new Panel();
            SellerAddLabel = new Label();
            SellerID = new Label();
            label1 = new Label();
            SellerIDTB = new TextBox();
            SellerCountTB = new TextBox();
            SellerAdd = new Button();
            panel4 = new Panel();
            label2 = new Label();
            SellerSale = new Button();
            SellerSearchButton = new Button();
            SellerSearchTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Class.Product);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productCountryDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, productDescriptionDataGridViewTextBoxColumn, remainingProductCountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(799, 594);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Class.Product);
            productBindingSource1.CurrentChanged += productBindingSource1_CurrentChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(SellerAddLabel);
            panel3.Controls.Add(SellerID);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(SellerIDTB);
            panel3.Controls.Add(SellerCountTB);
            panel3.Controls.Add(SellerAdd);
            panel3.Location = new Point(805, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 342);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // SellerAddLabel
            // 
            SellerAddLabel.AutoSize = true;
            SellerAddLabel.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerAddLabel.Location = new Point(104, 30);
            SellerAddLabel.Name = "SellerAddLabel";
            SellerAddLabel.Size = new Size(85, 40);
            SellerAddLabel.TabIndex = 5;
            SellerAddLabel.Text = "Add";
            // 
            // SellerID
            // 
            SellerID.AutoSize = true;
            SellerID.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            SellerID.Location = new Point(36, 81);
            SellerID.Name = "SellerID";
            SellerID.Size = new Size(38, 27);
            SellerID.TabIndex = 4;
            SellerID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            label1.Location = new Point(36, 158);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 3;
            label1.Text = "Count";
            // 
            // SellerIDTB
            // 
            SellerIDTB.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            SellerIDTB.Location = new Point(36, 112);
            SellerIDTB.Name = "SellerIDTB";
            SellerIDTB.Size = new Size(233, 35);
            SellerIDTB.TabIndex = 2;
            // 
            // SellerCountTB
            // 
            SellerCountTB.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            SellerCountTB.Location = new Point(36, 186);
            SellerCountTB.Name = "SellerCountTB";
            SellerCountTB.Size = new Size(233, 35);
            SellerCountTB.TabIndex = 1;
            // 
            // SellerAdd
            // 
            SellerAdd.BackColor = Color.FromArgb(0, 192, 0);
            SellerAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerAdd.ForeColor = Color.FromArgb(192, 0, 0);
            SellerAdd.Location = new Point(80, 240);
            SellerAdd.Name = "SellerAdd";
            SellerAdd.Size = new Size(142, 42);
            SellerAdd.TabIndex = 0;
            SellerAdd.Text = "Add";
            SellerAdd.UseVisualStyleBackColor = false;
            SellerAdd.Click += SellerAdd_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(SellerSale);
            panel4.Location = new Point(805, 448);
            panel4.Name = "panel4";
            panel4.Size = new Size(310, 151);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 4);
            label2.Name = "label2";
            label2.Size = new Size(99, 40);
            label2.TabIndex = 1;
            label2.Text = "SALE";
            // 
            // SellerSale
            // 
            SellerSale.BackColor = Color.Red;
            SellerSale.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerSale.ForeColor = Color.YellowGreen;
            SellerSale.Location = new Point(74, 57);
            SellerSale.Name = "SellerSale";
            SellerSale.Size = new Size(155, 47);
            SellerSale.TabIndex = 0;
            SellerSale.Text = "Sale";
            SellerSale.UseVisualStyleBackColor = false;
            SellerSale.Click += SellerSale_Click;
            // 
            // SellerSearchButton
            // 
            SellerSearchButton.BackColor = Color.SteelBlue;
            SellerSearchButton.BackgroundImage = (Image)resources.GetObject("SellerSearchButton.BackgroundImage");
            SellerSearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            SellerSearchButton.Location = new Point(807, 14);
            SellerSearchButton.Name = "SellerSearchButton";
            SellerSearchButton.Size = new Size(30, 29);
            SellerSearchButton.TabIndex = 10;
            SellerSearchButton.UseVisualStyleBackColor = false;
            SellerSearchButton.Click += SellerSearchButton_Click;
            // 
            // SellerSearchTB
            // 
            SellerSearchTB.Location = new Point(843, 16);
            SellerSearchTB.Name = "SellerSearchTB";
            SellerSearchTB.Size = new Size(265, 27);
            SellerSearchTB.TabIndex = 11;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1113, 593);
            Controls.Add(SellerSearchTB);
            Controls.Add(SellerSearchButton);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Name = "SellerForm";
            Text = "SellerForm";
            FormClosed += SellerForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource productBindingSource;
        private DataGridView dataGridView1;
        private BindingSource productBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remainingProductCountDataGridViewTextBoxColumn;
        private Panel panel3;
        private Panel panel4;
        private Label SellerAddLabel;
        private Label SellerID;
        private Label label1;
        private TextBox SellerIDTB;
        private TextBox SellerCountTB;
        private Button SellerAdd;
        private Button SellerSale;
        private Button SellerSearchButton;
        private TextBox SellerSearchTB;
        private Label label2;
    }
}