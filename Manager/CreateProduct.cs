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
using System.Text.RegularExpressions; // library 
//using System.Runtime.InteropServices;

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
            if (string.IsNullOrWhiteSpace(tbProductName.Text) ||
                string.IsNullOrWhiteSpace(tbDescreption.Text) ||
                string.IsNullOrWhiteSpace(tbCountry.Text) ||
                !double.TryParse(tbPrice.Text, out double price) || // test count transformation
                !int.TryParse(tbEnterProduct.Text, out int enter_product) ||
                price <= 0 || enter_product <= 0 ||
                !Regex.IsMatch(tbCountry.Text, @"^[a-zA-Z]+$")) // test alfavit  words
            {
                lbPriceError.Text = "Bun Faqat Double qiymatlarini qabul qiladi";
                lbEnterProductError.Text = "Bun Faqat int qiymatlarini qabul qiladi";
                lbCountryError.Text = "Bu yerda fakat hariflar bolishi kerak, son bolishi mumkinmas";
                //
                MessageBox.Show("To'liq va to'g'ri malumot kirriting");
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
        
        private void CreateProduct_Mouse(object sender, MouseEventArgs e) // Mouse
        {
            
        }
    }
}
