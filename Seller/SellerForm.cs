using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalProductsStore.Class;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace TechnicalProductsStore.Seller
{
    public partial class SellerForm : Form
    {

        int sellerID;

        List<Product> product = new List<Product>();
        string path = @"../../../DataBase/Products.json";
        public SellerForm(int sellerID)
        {
            InitializeComponent();

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                product = JsonSerializer.Deserialize<List<Product>>(existingUsersJson);
            }


            var filteredProduct = product.Where(u => u.RemainingProductCount != 0).ToList();
            dataGridView1.DataSource = product;
            this.sellerID = sellerID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        public Product ReadProduct(int id)
        {
            return product.FirstOrDefault(u => u.Id == id);
        }

        private void SellerAdd_Click(object sender, EventArgs e)
        {
            string pathBaskets = @"../../../Seller/Baskets/baskets.json";
            string pathProduct = @"../../../DataBase/Product.json";

            var checkproduct = ReadProduct(int.Parse(SellerIDTB.Text));

            int checkproductid = checkproduct.Id;

            int qolganProduct = (int)checkproduct.RemainingProductCount - int.Parse(SellerCountTB.Text);

            int sellerCount = int.Parse(SellerCountTB.Text); // SellerCountTB.Text ni int ga aylantirish
            Product product = this.product.FirstOrDefault(p => p.Id == sellerCount);

            if (product != null)
            {
                product.RemainingProductCount = qolganProduct;
            }

            List<Baskets> basket = new List<Baskets>();
            if (string.IsNullOrWhiteSpace(SellerIDTB.Text) || string.IsNullOrWhiteSpace(SellerCountTB.Text) ||
                checkproductid <= 0 || qolganProduct <= 0)
            {
                MessageBox.Show("To'g'ri ma'lumot kiriting", "Ogohlantirish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Baskets baskets = new Baskets()
                {
                    SellerID = sellerID,
                    SaleCount = int.Parse(SellerCountTB.Text),
                    Id = checkproductid,
                    ProductName = checkproduct.ProductName,
                    ProductCountry = checkproduct.ProductCountry,
                    ProductDescription = checkproduct.ProductDescription,
                    ProductPrice = Convert.ToDouble(checkproduct.ProductPrice),
                    ProductEnterCount = Convert.ToInt32(checkproduct.ProductEnterCount),
                    ProductEnterData = DateTime.Now.ToString(),
                    RemainingProductCount = Convert.ToInt32(qolganProduct)
                };

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                var basketsJson = JsonSerializer.Serialize(baskets, options);

                File.AppendAllText(pathBaskets, basketsJson + Environment.NewLine);

                var productJson = JsonSerializer.Serialize(this.product, options);
                File.WriteAllText(pathProduct, productJson);
            }
        }

        private void SellerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SellerSearchButton_Click(object sender, EventArgs e)
        {
            //string[] stringProduct = File.ReadAllLines(path);
            List<Product> searchList = new List<Product>();
            foreach (Product item in product)
            {
                if (item.ProductName.ToLower().Contains(SellerSearchTB.Text.ToLower()))
                {
                    searchList.Add(item);
                }
            }
            dataGridView1.DataSource = searchList;

        }

        private void productBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
