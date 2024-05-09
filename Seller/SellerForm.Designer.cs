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
            logout = new Button();
            productBindingSource2 = new BindingSource(components);
            UserNameLB = new Label();
            BasketList_DGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BasketList_DGV).BeginInit();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Class.Product);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productCountryDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, productDescriptionDataGridViewTextBoxColumn, remainingProductCountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1181, 1589);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 80;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // productCountryDataGridViewTextBoxColumn
            // 
            productCountryDataGridViewTextBoxColumn.DataPropertyName = "ProductCountry";
            productCountryDataGridViewTextBoxColumn.HeaderText = "Country";
            productCountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            productCountryDataGridViewTextBoxColumn.Name = "productCountryDataGridViewTextBoxColumn";
            productCountryDataGridViewTextBoxColumn.ReadOnly = true;
            productCountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            productPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            productPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            productDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            productDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            productDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // remainingProductCountDataGridViewTextBoxColumn
            // 
            remainingProductCountDataGridViewTextBoxColumn.DataPropertyName = "RemainingProductCount";
            remainingProductCountDataGridViewTextBoxColumn.HeaderText = "RemainingCount";
            remainingProductCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            remainingProductCountDataGridViewTextBoxColumn.Name = "remainingProductCountDataGridViewTextBoxColumn";
            remainingProductCountDataGridViewTextBoxColumn.ReadOnly = true;
            remainingProductCountDataGridViewTextBoxColumn.Width = 150;
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
            panel3.Location = new Point(1234, 206);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 428);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // SellerAddLabel
            // 
            SellerAddLabel.AutoSize = true;
            SellerAddLabel.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerAddLabel.Location = new Point(130, 38);
            SellerAddLabel.Margin = new Padding(4, 0, 4, 0);
            SellerAddLabel.Name = "SellerAddLabel";
            SellerAddLabel.Size = new Size(100, 47);
            SellerAddLabel.TabIndex = 5;
            SellerAddLabel.Text = "Add";
            // 
            // SellerID
            // 
            SellerID.AutoSize = true;
            SellerID.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            SellerID.Location = new Point(45, 101);
            SellerID.Margin = new Padding(4, 0, 4, 0);
            SellerID.Name = "SellerID";
            SellerID.Size = new Size(46, 33);
            SellerID.TabIndex = 4;
            SellerID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            label1.Location = new Point(45, 198);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 33);
            label1.TabIndex = 3;
            label1.Text = "Count";
            // 
            // SellerIDTB
            // 
            SellerIDTB.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            SellerIDTB.Location = new Point(45, 140);
            SellerIDTB.Margin = new Padding(4);
            SellerIDTB.Name = "SellerIDTB";
            SellerIDTB.Size = new Size(290, 40);
            SellerIDTB.TabIndex = 2;
            // 
            // SellerCountTB
            // 
            SellerCountTB.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            SellerCountTB.Location = new Point(45, 232);
            SellerCountTB.Margin = new Padding(4);
            SellerCountTB.Name = "SellerCountTB";
            SellerCountTB.Size = new Size(290, 40);
            SellerCountTB.TabIndex = 1;
            // 
            // SellerAdd
            // 
            SellerAdd.BackColor = Color.FromArgb(0, 192, 0);
            SellerAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerAdd.ForeColor = Color.FromArgb(192, 0, 0);
            SellerAdd.Location = new Point(100, 300);
            SellerAdd.Margin = new Padding(4);
            SellerAdd.Name = "SellerAdd";
            SellerAdd.Size = new Size(178, 52);
            SellerAdd.TabIndex = 0;
            SellerAdd.Text = "Add";
            SellerAdd.UseVisualStyleBackColor = false;
            SellerAdd.Click += SellerAdd_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(SellerSale);
            panel4.Location = new Point(1675, 934);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(663, 189);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 47);
            label2.TabIndex = 1;
            label2.Text = "SALE";
            // 
            // SellerSale
            // 
            SellerSale.BackColor = Color.Red;
            SellerSale.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerSale.ForeColor = Color.YellowGreen;
            SellerSale.Location = new Point(239, 97);
            SellerSale.Margin = new Padding(4);
            SellerSale.Name = "SellerSale";
            SellerSale.Size = new Size(194, 59);
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
            SellerSearchButton.Location = new Point(1572, 15);
            SellerSearchButton.Margin = new Padding(4);
            SellerSearchButton.Name = "SellerSearchButton";
            SellerSearchButton.Size = new Size(35, 32);
            SellerSearchButton.TabIndex = 10;
            SellerSearchButton.UseVisualStyleBackColor = false;
            SellerSearchButton.Click += SellerSearchButton_Click;
            // 
            // SellerSearchTB
            // 
            SellerSearchTB.Location = new Point(1234, 15);
            SellerSearchTB.Margin = new Padding(4);
            SellerSearchTB.Name = "SellerSearchTB";
            SellerSearchTB.Size = new Size(330, 31);
            SellerSearchTB.TabIndex = 11;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Location = new Point(2226, 18);
            logout.Name = "logout";
            logout.Size = new Size(112, 34);
            logout.TabIndex = 6;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += button1_Click;
            // 
            // productBindingSource2
            // 
            productBindingSource2.DataSource = typeof(Class.Product);
            // 
            // UserNameLB
            // 
            UserNameLB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserNameLB.AutoSize = true;
            UserNameLB.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserNameLB.Location = new Point(1781, 18);
            UserNameLB.Name = "UserNameLB";
            UserNameLB.Size = new Size(28, 38);
            UserNameLB.TabIndex = 15;
            UserNameLB.Text = "1";
            // 
            // BasketList_DGV
            // 
            BasketList_DGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BasketList_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BasketList_DGV.Location = new Point(1674, 206);
            BasketList_DGV.Name = "BasketList_DGV";
            BasketList_DGV.RowHeadersWidth = 62;
            BasketList_DGV.Size = new Size(664, 701);
            BasketList_DGV.TabIndex = 16;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(2447, 1590);
            Controls.Add(BasketList_DGV);
            Controls.Add(UserNameLB);
            Controls.Add(logout);
            Controls.Add(SellerSearchTB);
            Controls.Add(SellerSearchButton);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SellerForm";
            Text = "SellerForm";
            FormClosed += SellerForm_FormClosed;
            Load += SellerForm_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BasketList_DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource productBindingSource;
        private BindingSource productBindingSource1;
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
        private Button logout;
        protected DataGridView dataGridView1;
        private Label UserNameLB;
        private BindingSource productBindingSource2;
        private DataGridView BasketList_DGV;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remainingProductCountDataGridViewTextBoxColumn;
    }
}