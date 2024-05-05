namespace TechnicalProductsStore.Manager
{
    partial class SellerListForm
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
            dataGridView1 = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = usersBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1118, 631);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Class.Users);
            // 
            // SellerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 631);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "SellerListForm";
            Text = "SellerListForm";
            FormClosed += SellerListForm_FormClosed;
            Load += SellerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource usersBindingSource;
    }
}