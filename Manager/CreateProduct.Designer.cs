namespace TechnicalProductsStore.Manager
{
    partial class CreateProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbProductName = new TextBox();
            tbCountry = new TextBox();
            tbDescreption = new TextBox();
            tbPrice = new TextBox();
            tbEnterProduct = new TextBox();
            AddProduct = new Button();
            lbCountryError = new Label();
            lbPriceError = new Label();
            lbEnterProductError = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(23, 97);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 0;
            label1.Text = "Product-Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(23, 157);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 1;
            label2.Text = "Country";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(23, 220);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 285);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 346);
            label5.Name = "label5";
            label5.Size = new Size(134, 23);
            label5.TabIndex = 4;
            label5.Text = "Enter_Product";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(199, 97);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(482, 27);
            tbProductName.TabIndex = 7;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(199, 157);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(482, 27);
            tbCountry.TabIndex = 8;
            // 
            // tbDescreption
            // 
            tbDescreption.Location = new Point(199, 220);
            tbDescreption.Name = "tbDescreption";
            tbDescreption.Size = new Size(482, 27);
            tbDescreption.TabIndex = 9;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(199, 285);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(482, 27);
            tbPrice.TabIndex = 10;
            // 
            // tbEnterProduct
            // 
            tbEnterProduct.Location = new Point(199, 346);
            tbEnterProduct.Name = "tbEnterProduct";
            tbEnterProduct.Size = new Size(482, 27);
            tbEnterProduct.TabIndex = 11;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.Black;
            AddProduct.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddProduct.ForeColor = SystemColors.ButtonFace;
            AddProduct.Location = new Point(23, 430);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(658, 54);
            AddProduct.TabIndex = 14;
            AddProduct.Text = "Add";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // lbCountryError
            // 
            lbCountryError.AutoSize = true;
            lbCountryError.ForeColor = Color.Red;
            lbCountryError.Location = new Point(199, 187);
            lbCountryError.Name = "lbCountryError";
            lbCountryError.Size = new Size(0, 20);
            lbCountryError.TabIndex = 16;
            // 
            // lbPriceError
            // 
            lbPriceError.AutoSize = true;
            lbPriceError.ForeColor = Color.Red;
            lbPriceError.Location = new Point(199, 315);
            lbPriceError.Name = "lbPriceError";
            lbPriceError.Size = new Size(0, 20);
            lbPriceError.TabIndex = 17;
            lbPriceError.Click += lbPriceError_Click;
            // 
            // lbEnterProductError
            // 
            lbEnterProductError.AutoSize = true;
            lbEnterProductError.ForeColor = Color.Red;
            lbEnterProductError.Location = new Point(199, 376);
            lbEnterProductError.Name = "lbEnterProductError";
            lbEnterProductError.Size = new Size(0, 20);
            lbEnterProductError.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 48);
            label6.Name = "label6";
            label6.Size = new Size(265, 25);
            label6.TabIndex = 19;
            label6.Text = "Welcome to the Manager";
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(716, 521);
            Controls.Add(label6);
            Controls.Add(lbEnterProductError);
            Controls.Add(lbPriceError);
            Controls.Add(lbCountryError);
            Controls.Add(AddProduct);
            Controls.Add(tbEnterProduct);
            Controls.Add(tbPrice);
            Controls.Add(tbDescreption);
            Controls.Add(tbCountry);
            Controls.Add(tbProductName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "CreateProduct";
            Text = "CreateProduct";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            FormClosed += CreateProduct_FormClosed;
            Load += CreateProduct_Load;
            MouseDown += CreateProduct_Mouse;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbProductName;
        private TextBox tbCountry;
        private TextBox tbDescreption;
        private TextBox tbPrice;
        private TextBox tbEnterProduct;
        private Button AddProduct;
        private Label lbCountryError;
        private Label lbPriceError;
        private Label lbEnterProductError;
        private Label label6;
    }
}