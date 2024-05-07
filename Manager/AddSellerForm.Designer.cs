namespace TechnicalProductsStore.Manager
{
    partial class AddSellerForm
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
            FullName = new TextBox();
            PhoneNumber = new TextBox();
            label2 = new Label();
            Username = new TextBox();
            label3 = new Label();
            Password = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(10, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 0;
            label1.Text = "FullName";
            // 
            // FullName
            // 
            FullName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            FullName.Location = new Point(10, 42);
            FullName.Margin = new Padding(2);
            FullName.Name = "FullName";
            FullName.Size = new Size(258, 24);
            FullName.TabIndex = 1;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            PhoneNumber.Location = new Point(10, 96);
            PhoneNumber.Margin = new Padding(2);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(258, 24);
            PhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(10, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 18);
            label2.TabIndex = 2;
            label2.Text = "Phone Number (998)";
            // 
            // Username
            // 
            Username.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            Username.Location = new Point(10, 154);
            Username.Margin = new Padding(2);
            Username.Name = "Username";
            Username.Size = new Size(258, 24);
            Username.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(10, 132);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 4;
            label3.Text = "UserName";
            // 
            // Password
            // 
            Password.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            Password.Location = new Point(10, 213);
            Password.Margin = new Padding(2);
            Password.Name = "Password";
            Password.Size = new Size(258, 24);
            Password.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(10, 190);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 18);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(70, 262);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 37);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddSellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 328);
            Controls.Add(btnAdd);
            Controls.Add(Password);
            Controls.Add(label4);
            Controls.Add(Username);
            Controls.Add(label3);
            Controls.Add(PhoneNumber);
            Controls.Add(label2);
            Controls.Add(FullName);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AddSellerForm";
            Text = "AddSellerForm";
            FormClosed += AddSellerForm_FormClosed;
            Load += AddSellerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FullName;
        private TextBox PhoneNumber;
        private Label label2;
        private TextBox Username;
        private Label label3;
        private TextBox Password;
        private Label label4;
        private Button btnAdd;
    }
}