using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalProductsStore.Manager
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm productsForm = new ProductsForm();
            productsForm.StartPosition = FormStartPosition.CenterScreen;
            productsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateProduct createProduct = new CreateProduct(1);
            createProduct.StartPosition = FormStartPosition.CenterScreen;
            createProduct.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSellerForm addSellerForm = new AddSellerForm(1);
            addSellerForm.StartPosition = FormStartPosition.CenterScreen;
            addSellerForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SellerHistory sellerHistory = new SellerHistory();
            sellerHistory.StartPosition = FormStartPosition.CenterScreen;
            sellerHistory.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerListForm sellerListForm = new SellerListForm();
            sellerListForm.StartPosition = FormStartPosition.CenterScreen;
            sellerListForm.Show();
            this.Hide();
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Hide();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
