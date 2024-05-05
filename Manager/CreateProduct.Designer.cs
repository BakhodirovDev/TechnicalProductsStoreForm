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
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 113);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Product-Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 173);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Country";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 236);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 301);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 362);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Enter_Product";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(250, 113);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(482, 27);
            tbProductName.TabIndex = 7;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(250, 173);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(482, 27);
            tbCountry.TabIndex = 8;
            // 
            // tbDescreption
            // 
            tbDescreption.Location = new Point(250, 236);
            tbDescreption.Name = "tbDescreption";
            tbDescreption.Size = new Size(482, 27);
            tbDescreption.TabIndex = 9;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(250, 301);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(482, 27);
            tbPrice.TabIndex = 10;
            // 
            // tbEnterProduct
            // 
            tbEnterProduct.Location = new Point(250, 362);
            tbEnterProduct.Name = "tbEnterProduct";
            tbEnterProduct.Size = new Size(482, 27);
            tbEnterProduct.TabIndex = 11;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(74, 446);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(658, 29);
            AddProduct.TabIndex = 14;
            AddProduct.Text = "Add";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(276, 35);
            label6.Name = "label6";
            label6.Size = new Size(251, 28);
            label6.TabIndex = 15;
            label6.Text = "Welcome to the manager";
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 549);
            Controls.Add(label6);
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
            Name = "CreateProduct";
            Text = "CreateProduct";
            Load += CreateProduct_Load;
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
        private Label label6;
    }
}