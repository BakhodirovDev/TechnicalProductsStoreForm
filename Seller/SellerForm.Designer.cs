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
            SellerSearchButton = new Button();
            SellerSearchTB = new TextBox();
            logout = new Button();
            productBindingSource2 = new BindingSource(components);
            UserNameLB = new Label();
            BasketList_DGV = new DataGridView();
            panel1 = new Panel();
            SellerSaleBTN = new Button();
            Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BasketList_DGV).BeginInit();
            panel1.SuspendLayout();
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productCountryDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, productDescriptionDataGridViewTextBoxColumn, remainingProductCountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(945, 881);
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
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCountryDataGridViewTextBoxColumn
            // 
            productCountryDataGridViewTextBoxColumn.DataPropertyName = "ProductCountry";
            productCountryDataGridViewTextBoxColumn.HeaderText = "Country";
            productCountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            productCountryDataGridViewTextBoxColumn.Name = "productCountryDataGridViewTextBoxColumn";
            productCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            productPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            productDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            productDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remainingProductCountDataGridViewTextBoxColumn
            // 
            remainingProductCountDataGridViewTextBoxColumn.DataPropertyName = "RemainingProductCount";
            remainingProductCountDataGridViewTextBoxColumn.HeaderText = "RemainingCount";
            remainingProductCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            remainingProductCountDataGridViewTextBoxColumn.Name = "remainingProductCountDataGridViewTextBoxColumn";
            remainingProductCountDataGridViewTextBoxColumn.ReadOnly = true;
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
            panel3.Location = new Point(987, 165);
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
            // SellerSearchButton
            // 
            SellerSearchButton.BackColor = Color.SteelBlue;
            SellerSearchButton.BackgroundImage = (Image)resources.GetObject("SellerSearchButton.BackgroundImage");
            SellerSearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            SellerSearchButton.Location = new Point(1258, 12);
            SellerSearchButton.Name = "SellerSearchButton";
            SellerSearchButton.Size = new Size(28, 26);
            SellerSearchButton.TabIndex = 10;
            SellerSearchButton.UseVisualStyleBackColor = false;
            SellerSearchButton.Click += SellerSearchButton_Click;
            // 
            // SellerSearchTB
            // 
            SellerSearchTB.Location = new Point(987, 12);
            SellerSearchTB.Name = "SellerSearchTB";
            SellerSearchTB.Size = new Size(265, 27);
            SellerSearchTB.TabIndex = 11;
            SellerSearchTB.TextChanged += SellerSearchTB_TextChanged;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Location = new Point(1377, 14);
            logout.Margin = new Padding(2);
            logout.Name = "logout";
            logout.Size = new Size(90, 27);
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
            UserNameLB.Location = new Point(1425, 14);
            UserNameLB.Margin = new Padding(2, 0, 2, 0);
            UserNameLB.Name = "UserNameLB";
            UserNameLB.Size = new Size(24, 32);
            UserNameLB.TabIndex = 15;
            UserNameLB.Text = "1";
            // 
            // BasketList_DGV
            // 
            BasketList_DGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BasketList_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BasketList_DGV.Location = new Point(936, 165);
            BasketList_DGV.Margin = new Padding(2);
            BasketList_DGV.Name = "BasketList_DGV";
            BasketList_DGV.RowHeadersWidth = 62;
            BasketList_DGV.Size = new Size(531, 561);
            BasketList_DGV.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(SellerSaleBTN);
            panel1.Controls.Add(Clear);
            panel1.Location = new Point(1355, 786);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 85);
            panel1.TabIndex = 18;
            // 
            // SellerSaleBTN
            // 
            SellerSaleBTN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SellerSaleBTN.BackColor = Color.LimeGreen;
            SellerSaleBTN.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerSaleBTN.ForeColor = Color.DimGray;
            SellerSaleBTN.Location = new Point(59, 18);
            SellerSaleBTN.Name = "SellerSaleBTN";
            SellerSaleBTN.Size = new Size(178, 47);
            SellerSaleBTN.TabIndex = 20;
            SellerSaleBTN.Text = "Sale";
            SellerSaleBTN.UseVisualStyleBackColor = false;
            SellerSaleBTN.Click += SellerSaleBTN_Click;
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Clear.BackColor = Color.DarkGray;
            Clear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.ForeColor = Color.Red;
            Clear.Location = new Point(283, 18);
            Clear.Name = "Clear";
            Clear.Size = new Size(178, 47);
            Clear.TabIndex = 19;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1554, 882);
            Controls.Add(panel1);
            Controls.Add(BasketList_DGV);
            Controls.Add(UserNameLB);
            Controls.Add(logout);
            Controls.Add(SellerSearchTB);
            Controls.Add(SellerSearchButton);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellerForm";
            Text = "SellerForm";
            FormClosed += SellerForm_FormClosed;
            Load += SellerForm_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BasketList_DGV).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource productBindingSource;
        private BindingSource productBindingSource1;
        private Panel panel3;
        private Label SellerAddLabel;
        private Label SellerID;
        private Label label1;
        private TextBox SellerIDTB;
        private TextBox SellerCountTB;
        private Button SellerAdd;
        private Button SellerSale;
        private Button SellerSearchButton;
        private TextBox SellerSearchTB;
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
        private Panel panel1;
        private Button Clear;
        private Button SellerSaleBTN;
    }
}