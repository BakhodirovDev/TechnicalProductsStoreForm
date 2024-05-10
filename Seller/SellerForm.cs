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
using static System.Windows.Forms.Design.AxImporter;
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

        List<Baskets> list = new List<Baskets>();

        string PathBasket = @$"../../../Seller/Base/baskets_{sellerID}.json";

        List<HistoryWorking> historySellerWorking = new List<HistoryWorking>();

        public SellerForm(int sellerid)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            sellerID = sellerid;
            string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";
            string PathSellerHistory = @$"../../../Seller/Base/History_{sellerID}.json";

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

            if (!File.Exists(PathSellerHistory))
            {
                using (File.Create(PathSellerHistory)) { }
            }

            if (File.Exists(PathSellerHistory))
            {
                var existingUsersJson = File.ReadAllText(PathSellerHistory);
                if (!string.IsNullOrWhiteSpace(existingUsersJson))
                {
                    // Try to deserialize the JSON as a list
                    try
                    {
                        historySellerWorking = JsonSerializer.Deserialize<List<HistoryWorking>>(existingUsersJson);
                    }
                    // If that fails, try to deserialize it as a single object and add it to the list
                    catch
                    {
                        var singleHistory = JsonSerializer.Deserialize<HistoryWorking>(existingUsersJson);
                        historySellerWorking = new List<HistoryWorking> { singleHistory };
                    }
                }

                HistoryWorking history = new HistoryWorking()
                {
                    SellerID = sellerID,
                    SellerSignInTime = DateTime.Now.ToString(),
                    SellerSignOutTime = null,
                    SellerSaleCount = null,
                    SellerSalePrice = null
                };

                historySellerWorking.Add(history);

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(historySellerWorking, options);

                File.WriteAllText(PathSellerHistory, json);
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


            if (File.Exists(PathBasket))
            {
                var existingUsersJson = File.ReadAllText(PathBasket);
                if (!string.IsNullOrWhiteSpace(existingUsersJson))
                {
                    list = JsonSerializer.Deserialize<List<Baskets>>(existingUsersJson);
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

        public HistoryWorking ReadSellerHistory(int id)
        {
            return historySellerWorking.FirstOrDefault(u => u.SellerID == id);
        }

        public Product ReadProduct(int id)
        {
            return product.FirstOrDefault(u => u.Id == id);
        }

        public Users ReadSeller(int id)
        {
            return seller.FirstOrDefault(u => u.ID == id);
        }
        public Baskets ReadBaskets(int id)
        {
            return baskets.FirstOrDefault(u => u.Id == id);
        }


        private void SellerAdd_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

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



                    Baskets targetProducts = baskets.FirstOrDefault(p => p.Id == int.Parse(SellerIDTB.Text));


                    if (targetProducts != null)
                    {
                        targetProducts.SaleCount = (targetProducts.SaleCount + int.Parse(SellerCountTB.Text));
                        double productPrice = targetProducts.ProductPrice.Value;
                        targetProducts.ProductPrice = targetProducts.SaleCount * productPrice;
                        string updatedJson = JsonSerializer.Serialize(baskets, options);
                        File.WriteAllText(PathBaskets, updatedJson);
                    }
                    else
                    {
                        double productPrice = int.Parse(SellerCountTB.Text) * ReadProduct(int.Parse(SellerIDTB.Text)).ProductPrice.Value;
                        Baskets basket = new Baskets()
                        {
                            SellerID = sellerID,
                            SaleCount = int.Parse(SellerCountTB.Text),
                            Id = int.Parse(SellerIDTB.Text),
                            ProductName = ReadProduct(int.Parse(SellerIDTB.Text)).ProductName,
                            ProductCountry = ReadProduct(int.Parse(SellerIDTB.Text)).ProductCountry,
                            ProductDescription = ReadProduct(int.Parse(SellerIDTB.Text)).ProductDescription,
                            ProductPrice = productPrice,
                            ProductEnterCount = Convert.ToInt32(ReadProduct(int.Parse(SellerIDTB.Text)).ProductEnterCount),
                            ProductEnterData = DateTime.Now.ToString(),
                            RemainingProductCount = (ReadProduct(int.Parse(SellerIDTB.Text)).RemainingProductCount - int.Parse(SellerCountTB.Text))
                        };

                        baskets.Add(basket);


                        string json = JsonSerializer.Serialize(baskets, options);

                        File.WriteAllText(PathBaskets, json);
                    }

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
            string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";
            string PathSellerHistory = @$"../../../Seller/Base/History_{sellerID}.json";
            if (File.Exists(PathBaskets))
            {
                var existingUsersJson = File.ReadAllText(PathBaskets);
                if (!string.IsNullOrEmpty(existingUsersJson))
                {
                    MessageBox.Show("Savatda mahsulotlar bor.");
                }
                else
                {
                    HistoryWorking historyWorking = new HistoryWorking()
                    {
                        SellerID = ReadSellerHistory(sellerID).SellerID,
                        SellerSignInTime = ReadSellerHistory(sellerID).SellerSignInTime,
                        SellerSignOutTime = DateTime.Now.ToString(),
                        SellerSaleCount = ReadSellerHistory(sellerID).SellerSaleCount,
                        SellerSalePrice = ReadSellerHistory(sellerID).SellerSalePrice
                    };
                    historySellerWorking.Add(historyWorking);

                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    string json = JsonSerializer.Serialize(historySellerWorking, options);

                    File.Delete(PathBaskets);

                    if (File.Exists(PathSellerHistory))
                    {
                        var UsersJson = File.ReadAllText(PathSellerHistory);
                        if (!string.IsNullOrWhiteSpace(UsersJson))
                        {
                            var historySellerWorking = JsonSerializer.Deserialize<List<HistoryWorking>>(UsersJson);

                            // Assuming you want to update the first item in the list
                            if (historySellerWorking.Any())
                            {
                                historySellerWorking[0].SellerSignOutTime = DateTime.Now.ToString();

                                string Sellerjson = JsonSerializer.Serialize(historySellerWorking, options);

                                File.WriteAllText(PathSellerHistory, Sellerjson);
                            }
                        }
                    }

                    //File.Delete(PathSellerHistory);
                    LoginForm loginForm = new LoginForm();
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private void SellerSaleBTN_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            for (int i = baskets.Count - 1; i >= 0; i--)
            {
                var basket = baskets[i];
                Product targetProducts = product.FirstOrDefault(p => p.Id == basket.Id);

                if (targetProducts != null)
                {
                    int targetProductsCount = int.Parse(ReadBaskets(basket.Id).SaleCount.ToString());
                    targetProducts.RemainingProductCount = (targetProducts.RemainingProductCount + targetProductsCount);
                }

               

                string updatedJson = JsonSerializer.Serialize(product, options);
                File.WriteAllText(path, updatedJson);

               
                var filteredProduct = product.Where(u => u.RemainingProductCount != 0).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filteredProduct;
            }
            File.WriteAllText(PathBaskets, "");
            baskets.Clear();
            BasketList_DGV.DataSource = null;
            BasketList_DGV.DataSource = baskets;

        }
    }
}
