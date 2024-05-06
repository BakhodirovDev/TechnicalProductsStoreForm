using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalProductsStore.Class;

namespace TechnicalProductsStore.Manager
{
    public partial class CreateProduct : Form
    {

        public int Form;
        public CreateProduct(int FormID)
        {
            this.Form = FormID;
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e) // object != null
        {
            lbPriceError.Text = "Bun Faqat Double qiymatlarini qabul qiladi";
            if (string.IsNullOrWhiteSpace(tbProductName.Text) ||
                string.IsNullOrWhiteSpace(tbDescreption.Text) ||
                string.IsNullOrWhiteSpace(tbProductName.Text) ||
                Convert.ToDouble(tbPrice.Text) == 0 ||
                Convert.ToInt32(tbEnterProduct.Text) == 0)
            {
                MessageBox.Show("Toliq malumot kirriting");
                return;
            }

            string pathProduct = @"../../../DataBase/Products.json";

            List<Product> products = new List<Product>();

            if (File.Exists(pathProduct))
            {
                var existingProductPath = File.ReadAllText(pathProduct);
                products = JsonSerializer.Deserialize<List<Product>>(existingProductPath);
            }

            int IdProductNext = products.Count > 0 ? products.Max(u => u.Id) + 1 : 1; // original ID_Product

            Product product = new Product
            {
                Id = IdProductNext,
                ProductName = tbProductName.Text,
                ProductCountry = tbCountry.Text,
                ProductDescription = tbDescreption.Text,
                ProductPrice = Convert.ToDouble(tbPrice.Text),
                ProductEnterCount = Convert.ToInt32(tbEnterProduct.Text),
                ProductEnterData = DateTime.Now.ToString(),
                RemainingProductCount = Convert.ToInt32(tbEnterProduct.Text),
            };

            products.Add(product);

            var optionProduct = new JsonSerializerOptions // formating Json with probel
            {
                WriteIndented = true,
            };

            string JsonProduct = JsonSerializer.Serialize(products, optionProduct); // seralazing object in json and use option
            File.WriteAllText(pathProduct, JsonProduct);
            MessageBox.Show("Successfully");
            //MessageBox.Show("Go manager = YES or create product = NO","Tanlang",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            this.Hide();
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();





        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {

        }

        private void CreateProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form == 1)
            {
                
                ManagerForm managerForm = new ManagerForm();
                managerForm.StartPosition = FormStartPosition.CenterScreen;
                managerForm.Show();
            }
            else if (Form == 2)
            {
                ProductsForm form = new ProductsForm();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
            this.Hide();
        }

        private void lbPriceError_Click(object sender, EventArgs e)
        {

        }
    }
}
