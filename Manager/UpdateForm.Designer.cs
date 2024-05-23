namespace TechnicalProductsStore.Manager
{
    partial class UpdateForm
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
            label6 = new Label();
            tbUpProductName = new TextBox();
            tbUpDeccription = new TextBox();
            tbUpPrice = new TextBox();
            tbUpEnterProduct = new TextBox();
            tbUpRemaningProduct = new TextBox();
            comboUpCountry = new ComboBox();
            butEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(45, 38);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(46, 99);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 1;
            label2.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(45, 156);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(45, 215);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(45, 273);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 4;
            label5.Text = "Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(45, 336);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 5;
            label6.Text = "Remaining-count";
            // 
            // tbUpProductName
            // 
            tbUpProductName.Location = new Point(46, 64);
            tbUpProductName.Name = "tbUpProductName";
            tbUpProductName.Size = new Size(525, 27);
            tbUpProductName.TabIndex = 7;
            // 
            // tbUpDeccription
            // 
            tbUpDeccription.Location = new Point(45, 180);
            tbUpDeccription.Name = "tbUpDeccription";
            tbUpDeccription.Size = new Size(525, 27);
            tbUpDeccription.TabIndex = 8;
            // 
            // tbUpPrice
            // 
            tbUpPrice.Location = new Point(45, 241);
            tbUpPrice.Name = "tbUpPrice";
            tbUpPrice.Size = new Size(525, 27);
            tbUpPrice.TabIndex = 9;
            // 
            // tbUpEnterProduct
            // 
            tbUpEnterProduct.Location = new Point(45, 299);
            tbUpEnterProduct.Name = "tbUpEnterProduct";
            tbUpEnterProduct.Size = new Size(525, 27);
            tbUpEnterProduct.TabIndex = 10;
            // 
            // tbUpRemaningProduct
            // 
            tbUpRemaningProduct.Location = new Point(45, 362);
            tbUpRemaningProduct.Name = "tbUpRemaningProduct";
            tbUpRemaningProduct.Size = new Size(525, 27);
            tbUpRemaningProduct.TabIndex = 11;
            // 
            // comboUpCountry
            // 
            comboUpCountry.FormattingEnabled = true;
            comboUpCountry.Location = new Point(46, 125);
            comboUpCountry.Name = "comboUpCountry";
            comboUpCountry.Size = new Size(526, 28);
            comboUpCountry.TabIndex = 13;
            // 
            // butEdit
            // 
            butEdit.BackColor = SystemColors.ActiveCaptionText;
            butEdit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            butEdit.ForeColor = SystemColors.ButtonHighlight;
            butEdit.Location = new Point(135, 428);
            butEdit.Name = "butEdit";
            butEdit.Size = new Size(348, 50);
            butEdit.TabIndex = 15;
            butEdit.Text = "Edit";
            butEdit.UseVisualStyleBackColor = false;
            butEdit.Click += button1_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(625, 522);
            Controls.Add(butEdit);
            Controls.Add(comboUpCountry);
            Controls.Add(tbUpRemaningProduct);
            Controls.Add(tbUpEnterProduct);
            Controls.Add(tbUpPrice);
            Controls.Add(tbUpDeccription);
            Controls.Add(tbUpProductName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbUpProductName;
        private TextBox tbUpDeccription;
        private TextBox tbUpPrice;
        private TextBox tbUpEnterProduct;
        private TextBox tbUpRemaningProduct;
        private ComboBox comboUpCountry;
        private Button butEdit;
    }
}