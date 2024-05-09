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

        private static int sellerID;

        List<Product> product = new List<Product>();
        string path = @"../../../DataBase/Products.json";

        List<Users> seller = new List<Users>();
        string PathUsers = @"../../../DataBase/Users.json";

        List<Baskets> baskets = new List<Baskets>();
        string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";

        public SellerForm(int sellerid)
        {

            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            

            if (!File.Exists(PathBaskets))
            {
                using (File.Create(PathBaskets)) { }
                File.AppendAllText(PathBaskets, "[]");
            }

            if (File.Exists(PathBaskets))
            {
                var existingUsersJson = File.ReadAllText(PathBaskets);
                baskets = JsonSerializer.Deserialize<List<Baskets>>(existingUsersJson);
            }
            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                product = JsonSerializer.Deserialize<List<Product>>(existingUsersJson);
            }
            if (File.Exists(PathUsers))
            {
                var existingUsersJson = File.ReadAllText(PathUsers);
                seller = JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }




            var filteredProduct = product.Where(u => u.RemainingProductCount != 0).ToList();
            dataGridView1.DataSource = product;
            sellerID = sellerid;


            UserNameLB.Text = ReadSeller(sellerID).FullName;
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

        public Users ReadSeller(int id)
        {
            return seller.FirstOrDefault(u => u.ID == id);
        }



        private void SellerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int CheckProductID = product.FindIndex(m => m.Id == int.Parse(SellerIDTB.Text));

                string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";


                if (string.IsNullOrWhiteSpace(SellerIDTB.Text) || string.IsNullOrWhiteSpace(SellerCountTB.Text) || CheckProductID == -1 || (int)ReadProduct(int.Parse(SellerIDTB.Text)).RemainingProductCount - int.Parse(SellerIDTB.Text) < 0)
                {
                    SellerIDTB.Text = "";
                    SellerCountTB.Text = "";
                    MessageBox.Show("Ma'lumotlarni to'g'ri kiriting");
                }
                else
                {
                    Baskets basket = new Baskets()
                    {
                        SellerID = sellerID,
                        SaleCount = int.Parse(SellerCountTB.Text),
                        Id = CheckProductID,
                        ProductName = ReadProduct(int.Parse(SellerIDTB.Text)).ProductName,
                        ProductCountry = ReadProduct(int.Parse(SellerIDTB.Text)).ProductCountry,
                        ProductDescription = ReadProduct(int.Parse(SellerIDTB.Text)).ProductDescription,
                        ProductPrice = Convert.ToDouble(ReadProduct(int.Parse(SellerIDTB.Text)).ProductPrice),
                        ProductEnterCount = Convert.ToInt32(ReadProduct(int.Parse(SellerIDTB.Text)).ProductEnterCount),
                        ProductEnterData = DateTime.Now.ToString(),
                        RemainingProductCount = Convert.ToInt32((int)ReadProduct(int.Parse(SellerIDTB.Text)).RemainingProductCount - int.Parse(SellerIDTB.Text))
                    };

                    baskets.Add(basket);

                }
            }
            catch
            {
                SellerIDTB.Text = "";
                SellerCountTB.Text = "";
                MessageBox.Show("Ma'lumotlarni to'g'ri kiriting");
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Hide();
        }

        private void UserNameLB_Click(object sender, EventArgs e)
        {
        }
    }
}
