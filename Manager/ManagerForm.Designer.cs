namespace TechnicalProductsStore.Manager
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            button1.Location = new Point(19, 19);
            button1.Name = "button1";
            button1.Size = new Size(442, 155);
            button1.TabIndex = 0;
            button1.Text = "Create Seller";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            button2.Location = new Point(19, 180);
            button2.Name = "button2";
            button2.Size = new Size(442, 155);
            button2.TabIndex = 1;
            button2.Text = "Seller List";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGoldenrodYellow;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            button3.Location = new Point(467, 19);
            button3.Name = "button3";
            button3.Size = new Size(442, 155);
            button3.TabIndex = 2;
            button3.Text = "Products";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGoldenrodYellow;
            button4.FlatAppearance.MouseOverBackColor = Color.White;
            button4.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            button4.Location = new Point(467, 180);
            button4.Name = "button4";
            button4.Size = new Size(442, 155);
            button4.TabIndex = 5;
            button4.Text = "Sales history";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGoldenrodYellow;
            button5.FlatAppearance.MouseOverBackColor = Color.White;
            button5.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            button5.Location = new Point(239, 341);
            button5.Name = "button5";
            button5.Size = new Size(442, 155);
            button5.TabIndex = 4;
            button5.Text = "Create Product";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(932, 511);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ManagerForm";
            ShowIcon = false;
            Text = "ManagerForm";
            FormClosed += ManagerForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}