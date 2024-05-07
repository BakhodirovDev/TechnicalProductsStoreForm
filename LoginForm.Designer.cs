namespace TechnicalProductsStore
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btLogin = new Button();
            label1 = new Label();
            tbUserName = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btHideEyes = new Button();
            panel2 = new Panel();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.FromArgb(224, 224, 224);
            btLogin.Cursor = Cursors.Hand;
            btLogin.FlatAppearance.BorderColor = Color.Black;
            btLogin.FlatAppearance.MouseDownBackColor = Color.Green;
            btLogin.FlatAppearance.MouseOverBackColor = Color.Green;
            btLogin.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btLogin.Location = new Point(80, 305);
            btLogin.Margin = new Padding(4, 4, 4, 4);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(222, 55);
            btLogin.TabIndex = 0;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            label1.Location = new Point(74, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 27);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // tbUserName
            // 
            tbUserName.AccessibleName = "";
            tbUserName.Location = new Point(74, 118);
            tbUserName.Margin = new Padding(4, 4, 4, 4);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(240, 31);
            tbUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            label2.Location = new Point(74, 199);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 27);
            label2.TabIndex = 3;
            label2.Text = "Password ";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(74, 228);
            tbPassword.Margin = new Padding(4, 4, 4, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(240, 31);
            tbPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(166, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 27);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 118);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 228);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btHideEyes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbUserName);
            panel1.Location = new Point(54, 120);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 394);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // btHideEyes
            // 
            btHideEyes.BackgroundImage = (Image)resources.GetObject("btHideEyes.BackgroundImage");
            btHideEyes.BackgroundImageLayout = ImageLayout.Stretch;
            btHideEyes.Location = new Point(322, 228);
            btHideEyes.Margin = new Padding(4, 4, 4, 4);
            btHideEyes.Name = "btHideEyes";
            btHideEyes.Size = new Size(42, 36);
            btHideEyes.TabIndex = 8;
            btHideEyes.UseVisualStyleBackColor = true;
            btHideEyes.Click += btHideEyes_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 44);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(4, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(258, 27);
            label4.TabIndex = 1;
            label4.Text = "Technical Products Store";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1078, 4);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(42, 36);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1124, 624);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btLogin;
        private Label label1;
        private TextBox tbUserName;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button btHideEyes;
        private Panel panel2;
        private Button button1;
        private Label label4;
    }
}