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
        List<Product> ComboProduct = new List<Product>();

        List<Product> product = new List<Product>();
        string path = @"../../../DataBase/Products.json";

        List<Users> seller = new List<Users>();
        string PathUsers = @"../../../DataBase/Users.json";

        List<Baskets> baskets = new List<Baskets>();

        List<Baskets> list = new List<Baskets>();

        string PathBasket = @$"../../../Seller/Base/baskets_{sellerID}.json";

        List<HistoryWorking> historySellerWorking = new List<HistoryWorking>();

        List<HistorySale> historySales = new List<HistorySale>();
        string PathHistorySale = @$"../../../DataBase/History.json";

        List<HistorySale> historySale = new List<HistorySale>();
        string PathSaleHistory = @$"../../../Seller/Base/SaleHistory_{sellerID}.json";

        List<HistoryWorking> Working = new List<HistoryWorking>();
        string PathHistoryWoking = @$"../../../DataBase/TotalHistory.json";

        public SellerForm(int sellerid)
        {
            InitializeComponent();
            SellerSearchTB.TextChanged += new EventHandler(SellerSearchTB_TextChanged);

            this.WindowState = FormWindowState.Maximized;

            string folderPath = @"../../../Seller/Base";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
;



            sellerID = sellerid;
            string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";
            string PathSellerHistory = @$"../../../Seller/Base/History_{sellerID}.json";
            string PathSaleHistory = @$"../../../Seller/Base/SaleHistory_{sellerID}.json";
            string PathHistoryWoking = @$"../../../DataBase/TotalHistory.json";

            if (!File.Exists(PathBaskets))
            {
                using (File.Create(PathBaskets)) { }
            }

            if (!File.Exists(PathHistoryWoking))
            {
                using (File.Create(PathHistoryWoking)) { }
            }



            if (File.Exists(PathHistoryWoking))
            {
                var existingUsersJson = File.ReadAllText(PathHistoryWoking);
                if (!string.IsNullOrWhiteSpace(existingUsersJson))
                {
                    Working = JsonSerializer.Deserialize<List<HistoryWorking>>(existingUsersJson);
                }
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
            if (!File.Exists(PathSaleHistory))
            {
                using (File.Create(PathSaleHistory)) { }
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
                    SellerSaleTotalCount = null,
                    SellerSaleTotalPrice = null
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

            if (File.Exists(PathHistorySale))
            {
                var existingUsersJson = File.ReadAllText(PathHistorySale);
                if (!string.IsNullOrWhiteSpace(existingUsersJson))
                {
                    historySales = JsonSerializer.Deserialize<List<HistorySale>>(existingUsersJson);
                }
            }
            if (File.Exists(PathSaleHistory))
            {
                var existingUsersJson = File.ReadAllText(PathSaleHistory);
                if (!string.IsNullOrWhiteSpace(existingUsersJson))
                {
                    historySale = JsonSerializer.Deserialize<List<HistorySale>>(existingUsersJson);
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


                if (string.IsNullOrWhiteSpace(SellerIDTB.Text) || string.IsNullOrWhiteSpace(SellerCountTB.Text) || CheckProductID == -1 || (ReadProduct(int.Parse(SellerIDTB.Text)).RemainingProductCount - int.Parse(SellerCountTB.Text)) < 0 || int.Parse(SellerCountTB.Text) <= 0)
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
            try
            {
                // product namesining ustiga bosilda name texboxga utkazib beradi
                var selectedProducts = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                SellerIDTB.Text = selectedProducts.Id.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("some error occurd:" + ex.Message + " - " + ex.Source);
            }

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

            string PathSellerHistory = @$"../../../Seller/Base/History_{sellerID}.json";
            string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";
            string PathSaleHistory = @$"../../../Seller/Base/SaleHistory_{sellerID}.json";
            string PathHistorySale = @$"../../../DataBase/History.json";
            if (File.Exists(PathBaskets))
            {
                var existingUsersJson = File.ReadAllText(PathBaskets);
                if (!string.IsNullOrEmpty(existingUsersJson))
                {
                    MessageBox.Show("Savatda mahsulotlar bor.");
                }
                else
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };
                    string jsonSaleHistory = File.ReadAllText(PathSaleHistory);

                    try
                    {
                        List<HistorySale> historySale = JsonSerializer.Deserialize<List<HistorySale>>(jsonSaleHistory);
                    }
                    catch 
                    { 

                    }

                    string loginTime = ReadSellerHistory(sellerID).SellerSignInTime;
                    File.Delete(PathSellerHistory);
                    historySellerWorking.Clear();


                    int totalProductCount = historySale.Sum(s => s.ProductCount);
                    double totalProductPrice = historySale.Sum(s => s.ProductPrice);

                    HistoryWorking historyWork = new HistoryWorking()
                    {
                        SellerID = sellerID,
                        SellerSignInTime = loginTime,
                        SellerSignOutTime = DateTime.Now.ToString(),
                        SellerSaleTotalCount = totalProductCount,
                        SellerSaleTotalPrice = totalProductPrice
                    };

                    Working.Add(historyWork);
                    string updatedJson = JsonSerializer.Serialize(Working, options);
                    File.WriteAllText(PathHistoryWoking, updatedJson);






                    File.Delete(PathSaleHistory);
                    File.Delete(PathBaskets);


                    LoginForm loginForm = new LoginForm();
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private void SellerSaleBTN_Click(object sender, EventArgs e)
        {
            string PathBaskets = @$"../../../Seller/Base/baskets_{sellerID}.json";
            if (File.Exists(PathBaskets))
            {


                var existingUsersJson = File.ReadAllText(PathBaskets);
                if (!string.IsNullOrEmpty(existingUsersJson))
                {
                    string PathSaleHistory = @$"../../../Seller/Base/SaleHistory_{sellerID}.json";
                    string PathHistorySale = @$"../../../DataBase/History.json";
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    for (int i = baskets.Count - 1; i >= 0; i--)
                    {
                        var basket = baskets[i];
                        Baskets targetProducts = baskets.FirstOrDefault(p => p.Id == basket.Id);

                        if (targetProducts != null)
                        {
                            HistorySale historySaleObject = new HistorySale()
                            {
                                SellerID = sellerID,
                                ProductID = int.Parse(ReadBaskets(basket.Id).Id.ToString()),
                                ProductCount = int.Parse(ReadBaskets(basket.Id).SaleCount.ToString()),
                                ProductPrice = double.Parse(ReadBaskets(basket.Id).ProductPrice.ToString()),
                                ProductSaleTime = DateTime.Now.ToString()
                            };
                            historySales.Add(historySaleObject);
                            string updatedJson = JsonSerializer.Serialize(historySales, options);
                            File.WriteAllText(PathHistorySale, updatedJson);
                        }
                    }


                    for (int i = baskets.Count - 1; i >= 0; i--)
                    {
                        var basket = baskets[i];
                        Baskets targetProducts = baskets.FirstOrDefault(p => p.Id == basket.Id);

                        if (targetProducts != null)
                        {
                            HistorySale historySaleObject = new HistorySale()
                            {
                                SellerID = sellerID,
                                ProductID = int.Parse(ReadBaskets(basket.Id).Id.ToString()),
                                ProductCount = int.Parse(ReadBaskets(basket.Id).SaleCount.ToString()),
                                ProductPrice = double.Parse(ReadBaskets(basket.Id).ProductPrice.ToString()),
                                ProductSaleTime = DateTime.Now.ToString()
                            };
                            historySale.Add(historySaleObject);
                            string updatedJson = JsonSerializer.Serialize(historySale, options);
                            File.WriteAllText(PathSaleHistory, updatedJson);
                        }
                    }




                    File.WriteAllText(PathBaskets, "");
                    baskets.Clear();
                    BasketList_DGV.DataSource = null;
                    BasketList_DGV.DataSource = baskets;


                }
                else
                {
                    MessageBox.Show("Savatda mahsulot mavjud emas");
                }
            }
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

        private void SellerSearchTB_TextChanged(object sender, EventArgs e)
        {
            string pathProduct = @"../../../DataBase/Products.json";
            if (File.Exists(pathProduct))
            {
                var existingProductData = File.ReadAllText(pathProduct);
                ComboProduct = JsonSerializer.Deserialize<List<Product>>(existingProductData);
            }
            else
            {
                MessageBox.Show("Fayl eror.");
            }
            string searchLetter = SellerSearchTB.Text.Trim().ToLower();

            if (searchLetter == null)
            {
                dataGridView1.DataSource = ComboProduct.Where(p => p.RemainingProductCount != 0).ToList();
            }
            else
            {
                List<Product> searchResult = ComboProduct.Where(p => p.ProductName.ToLower().StartsWith(searchLetter)).ToList();
                dataGridView1.DataSource = searchResult;
            }
        }
    }
}
