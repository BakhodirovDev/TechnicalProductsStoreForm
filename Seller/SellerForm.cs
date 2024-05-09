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

        public SellerForm(int sellerid)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            sellerID = sellerid;
            string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";

            if (!File.Exists(PathBaskets))
            {
                using (File.Create(PathBaskets)) { }
            }

            if (File.Exists(PathBaskets))
            {
                var existingUsersJson = File.ReadAllText(PathBaskets);
                if (!string.IsNullOrWhiteSpace(existingUsersJson))
                {
                    baskets = JsonSerializer.Deserialize<List<Baskets>>(existingUsersJson);
                }
            }
            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(existingUsersJson))
                {
                    product = JsonSerializer.Deserialize<List<Product>>(existingUsersJson);
                }
            }
            if (File.Exists(PathUsers))
            {
                var existingUsersJson = File.ReadAllText(PathUsers);
                if (!string.IsNullOrWhiteSpace(existingUsersJson))
                {
                    seller = JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
                }
            }

            var filteredProduct = product.Where(u => u.RemainingProductCount != 0).ToList();

            dataGridView1.DataSource = filteredProduct;

            BasketList_DGV.AutoGenerateColumns = false;

            BasketList_DGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product Name"
            });

            BasketList_DGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SaleCount",
                HeaderText = "Sale Count"
            });

            BasketList_DGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductPrice",
                HeaderText = "Product Price"
            });

            BasketList_DGV.ReadOnly = true;
            BasketList_DGV.DataSource = baskets;

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


                if (string.IsNullOrWhiteSpace(SellerIDTB.Text) || string.IsNullOrWhiteSpace(SellerCountTB.Text) || CheckProductID == -1 || (ReadProduct(int.Parse(SellerIDTB.Text)).RemainingProductCount - int.Parse(SellerCountTB.Text)) < 0)
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
                        Id = int.Parse(SellerIDTB.Text),
                        ProductName = ReadProduct(int.Parse(SellerIDTB.Text)).ProductName,
                        ProductCountry = ReadProduct(int.Parse(SellerIDTB.Text)).ProductCountry,
                        ProductDescription = ReadProduct(int.Parse(SellerIDTB.Text)).ProductDescription,
                        ProductPrice = Convert.ToDouble(ReadProduct(int.Parse(SellerIDTB.Text)).ProductPrice),
                        ProductEnterCount = Convert.ToInt32(ReadProduct(int.Parse(SellerIDTB.Text)).ProductEnterCount),
                        ProductEnterData = DateTime.Now.ToString(),
                        RemainingProductCount = (ReadProduct(int.Parse(SellerIDTB.Text)).RemainingProductCount - int.Parse(SellerCountTB.Text))
                    };

                    baskets.Add(basket);
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    string json = JsonSerializer.Serialize(baskets, options);


                    Product targetProduct = product.FirstOrDefault(p => p.Id == int.Parse(SellerIDTB.Text));

                    if (targetProduct != null)
                    {
                        targetProduct.RemainingProductCount = (ReadProduct(int.Parse(SellerIDTB.Text)).RemainingProductCount - int.Parse(SellerCountTB.Text));
                        string updatedJson = JsonSerializer.Serialize(product, options);
                        File.WriteAllText(path, updatedJson);
                    }

                    SellerIDTB.Text = "";
                    SellerCountTB.Text = "";


                    var filteredProduct = product.Where(u => u.RemainingProductCount != 0).ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filteredProduct;

                    File.WriteAllText(PathBaskets, json);

                    BasketList_DGV.DataSource = null; 
                    
                    BasketList_DGV.DataSource = baskets;

                    MessageBox.Show("Successfully");

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

        private void BasketList_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
