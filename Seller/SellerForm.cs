using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalProductsStore.Seller
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SellerSale_Click(object sender, EventArgs e)
        {

        }

        private void SellerAdd_Click(object sender, EventArgs e)
        {

        }

        private void SellerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
