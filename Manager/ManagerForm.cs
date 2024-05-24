    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TechnicalProductsStore.Class;

namespace TechnicalProductsStore.Manager
{
    public partial class ManagerForm : Form
    {
        public bool MenuisLarge = false;
        List<Users> users = new List<Users>();
        List<Product> product = new List<Product>();
        public ManagerForm()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            SelectSection(SellersListPanel, ProductListPanel, ReportsTab, "SellerList");


            SellerListPanel();
            ProductsListPanel();
            InitializeComboBoxes();

            //Mirjahon
            SanalikPageningDateTimePickerQiymatlari();
            ComboBoxTuldirishSellerIdBilan();
        }
        //Mirjahon javobgar
        public void SanalikPageningDateTimePickerQiymatlari()
        {
            SellerReportSanalikDTPStart.Value = DateTime.Today;
            SellerReportSanalikDTPEnd.Value = DateTime.Today.AddDays(1);
        }
        public void ComboBoxTuldirishSellerIdBilan()
        {
            SellerReportKunlikSellerUserNameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SellerReportSanalikSellerUsernameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SellerReportOylikOylarCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SellerReportOylikSellerCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SellerReportOylikYillarCB.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonthAnaliz.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYearAnaliz.DropDownStyle = ComboBoxStyle.DropDownList;

            label23.Text = "";
            label24.Text = "";
            label25.Text = "";

            string pathUsers = @"../../../DataBase/Users.json";
            string jsonUser = File.ReadAllText(pathUsers);
            List<Users> newUserList = JsonSerializer.Deserialize<List<Users>>(jsonUser);

            for (int i = 0; i < newUserList.Count; i++)
            {
                if (newUserList[i].Role.ToLower() != "manager")
                {
                    SellerReportKunlikSellerUserNameCB.Items.Add(newUserList[i].UserName);
                    SellerReportSanalikSellerUsernameCB.Items.Add(newUserList[i].UserName);
                    SellerReportOylikSellerCB.Items.Add(newUserList[i].UserName);
                }
            }
        }

        private void InitializeComboBoxes()
        {
            // Инициализация ComboBox для месяцев
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            comboBoxMonth1.Items.AddRange(months);
            comboBoxMonthAnaliz.Items.AddRange(months);

            // Инициализация ComboBox для годов
            for (int i = 2019; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear1.Items.Add(i);
                comboBoxYearAnaliz.Items.Add(i);
            }
        }

        public void SellerListPanel()
        {

            string path = @"../../../DataBase/Users.json";

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }

            var filteredUsers = users.Where(u => u.Role != "Manager").ToList();
            SellerListDGV.DataSource = filteredUsers;


            // Create ContextMenuStrip
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            // Add "Edit", "Delete" and "Save" options
            menuStrip.Items.Add("Edit");
            menuStrip.Items.Add("Delete");
            menuStrip.Items.Add("Save");
            menuStrip.Items.Add("Create");
            menuStrip.Items.Add("Refresh");
            // Assign the ContextMenuStrip to the DataGridView
            SellerListDGV.ContextMenuStrip = menuStrip;

            menuStrip.Items[0].Click += new EventHandler(EditSellerList_Click);
            menuStrip.Items[1].Click += new EventHandler(DeleteSellerList_Click);
            menuStrip.Items[2].Click += new EventHandler(SaveSellerList_Click);
            menuStrip.Items[3].Click += new EventHandler(CreateUserSellerList_Click);
            menuStrip.Items[4].Click += new EventHandler(Refresh_SellerListDGV);

            // Initially hide the "Save" option
            menuStrip.Items[2].Visible = false;
        }

        private void EditSellerList_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = SellerListDGV.SelectedRows[0];
                var user = (Users)selectedRow.DataBoundItem;
                UpdateUser(user);
                SellerListDGV.ContextMenuStrip.Items[0].Visible = false;
                SellerListDGV.ContextMenuStrip.Items[1].Visible = false;
                SellerListDGV.ContextMenuStrip.Items[2].Visible = true;
                SellerListDGV.ContextMenuStrip.Items[3].Visible = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Yellow;
            }
            catch
            {
                MessageBox.Show("To'liq qatorni tanlab keyin 'Edit' tugmasini bosing.");
            }
        }

        private void DeleteSellerList_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row
                var selectedRow = SellerListDGV.SelectedRows[0];
                // Get the user from the selected row
                var user = (Users)selectedRow.DataBoundItem;
                // Call the DeleteUser method
                DeleteUser(user.ID);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void SaveSellerList_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the selected row
                var selectedRow = SellerListDGV.SelectedRows[0];
                // Get the user from the selected row
                var user = (Users)selectedRow.DataBoundItem;
                // Call the UpdateUser method
                UpdateUser(user);
                // Save to file
                SaveUsersToFile();

                // Show the "Edit" and "Delete" options and hide the "Save" option
                SellerListDGV.ContextMenuStrip.Items[0].Visible = true;
                SellerListDGV.ContextMenuStrip.Items[1].Visible = true;
                SellerListDGV.ContextMenuStrip.Items[2].Visible = false;
                SellerListDGV.ContextMenuStrip.Items[3].Visible = true;
                selectedRow.DefaultCellStyle.BackColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        public void CreateUserSellerList_Click(object sender, EventArgs e)
        {
            AddSellerForm addUser = new AddSellerForm();
            addUser.StartPosition = FormStartPosition.CenterScreen;
            addUser.Show();
        }

        // Read operation
        public Users ReadUser(int id)
        {
            return users.FirstOrDefault(u => u.ID == id);
        }

        // Update operation
        public void UpdateUser(Users user)
        {
            // Find the user
            var existingUser = users.FirstOrDefault(u => u.ID == user.ID);
            if (existingUser != null)
            {
                // Update the user
                existingUser.FullName = user.FullName;
                existingUser.Role = user.Role;
                // ... update other properties as needed

                // Update the data source
                SellerListDGV.DataSource = null;
                SellerListDGV.DataSource = users.Where(u => u.Role != "Manager").ToList();

                // Save to file
                SaveUsersToFile();
            }
        }

        // Delete operation
        public void DeleteUser(int id)
        {
            // Find the user
            var user = users.FirstOrDefault(u => u.ID == id);
            if (user != null)
            {
                // Remove the user from the list
                users.Remove(user);

                // Update the data source
                SellerListDGV.DataSource = null;
                SellerListDGV.DataSource = users.Where(u => u.Role != "Manager").ToList();

                // Save to file
                SaveUsersToFile();
            }
        }

        // Save users to file
        public void SaveUsersToFile()
        {
            string path = @"../../../DataBase/Users.json";
            var usersJson = System.Text.Json.JsonSerializer.Serialize(users);
            File.WriteAllText(path, usersJson);
        }

        private void SellerHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
            this.Hide();
        }

        public void ProductsListPanel()
        {
            string path = @"../../../DataBase/Products.json";

            if (File.Exists(path))
            {
                var existingProductJson = File.ReadAllText(path);
                product = JsonSerializer.Deserialize<List<Product>>(existingProductJson);
            }
            ProductLestDGV.DataSource = product;


            // Create ContextMenuStrip
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            // Add "Edit", "Delete", "Save" and "Create" options
            menuStrip.Items.Add("Edit");
            menuStrip.Items.Add("Delete");
            menuStrip.Items.Add("Save");
            menuStrip.Items.Add("Create");
            menuStrip.Items.Add("Refresh");

            // Assign the ContextMenuStrip to the DataGridView
            ProductLestDGV.ContextMenuStrip = menuStrip;

            ProductLestDGV.ContextMenuStrip.Items[2].Visible = false;

            // Add event handlers for the "Edit", "Delete" and "Save" options
            menuStrip.Items[0].Click += new EventHandler(EditProductList_Click);
            menuStrip.Items[1].Click += new EventHandler(DeleteProductList_Click);
            menuStrip.Items[2].Click += new EventHandler(SaveProductList_Click);
            menuStrip.Items[3].Click += new EventHandler(CreateProductList_Click);
            menuStrip.Items[4].Click += new EventHandler(Refresh_ProductLestDGV);
        }


        private void EditProductList_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = ProductLestDGV.SelectedRows[0];
                var product = (Product)selectedRow.DataBoundItem;
                UpdateUser(product); // Передача выбранного продукта для редактирования

            }
            catch
            {
                MessageBox.Show("Please select a row and try again.");
            }
        }
        private void SaveProductList_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the selected row
                var selectedRow = ProductLestDGV.SelectedRows[0];
                // Get the user from the selected row
                var product = (Product)selectedRow.DataBoundItem;
                // Call the UpdateUser method
                UpdateUser(product);
                // Save to file
                SaveProductToFile();

                // Show the "Edit" and "Delete" options and hide the "Save" option
                ProductLestDGV.ContextMenuStrip.Items[0].Visible = true;
                ProductLestDGV.ContextMenuStrip.Items[1].Visible = true;
                ProductLestDGV.ContextMenuStrip.Items[2].Visible = false;
                ProductLestDGV.ContextMenuStrip.Items[3].Visible = true;
                selectedRow.DefaultCellStyle.BackColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        private void DeleteProductList_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row
                var selectedRow = ProductLestDGV.SelectedRows[0];
                // Get the user from the selected row
                var product = (Product)selectedRow.DataBoundItem;
                // Call the DeleteUser method
                DeleteProduct_Click(product.Id);
                MessageBox.Show("Successfuly Delete");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void CreateProductList_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.StartPosition = FormStartPosition.CenterScreen;
            createProduct.Show();
        }
        public void Refresh_ProductLestDGV(object sender, EventArgs e) // Update datagidView
        {
            string path = @"../../../DataBase/Products.json";

            if (File.Exists(path))
            {
                var existingProductJson = File.ReadAllText(path);
                product = JsonSerializer.Deserialize<List<Product>>(existingProductJson);
            }
            ProductLestDGV.DataSource = null;
            ProductLestDGV.DataSource = product;

        }
        public void UpdateUser(Product product)
        {
            UpdateForm updateForm = new UpdateForm(product);
            updateForm.StartPosition = FormStartPosition.CenterScreen;
            updateForm.Show();
        }
        public void SaveProductToFile()
        {
            string path = @"../../../DataBase/Products.json";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var productJson = System.Text.Json.JsonSerializer.Serialize(product, options);

            File.WriteAllText(path, productJson);
        }
        public void DeleteProduct_Click(int id)
        {
            // Find the user
            var product = this.product.FirstOrDefault(u => u.Id == id);
            if (product != null)
            {
                // Remove the user from the list
                this.product.Remove(product);

                // Update the data source
                ProductLestDGV.DataSource = null;
                ProductLestDGV.DataSource = this.product.ToList();

                // Save to file
                SaveProductToFile();
            }
        }


        // Ekran o'lchamini olish
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public void MenuButton_Click(object sender, EventArgs e)
        {

            if (screenWidth == 1920 && screenHeight == 1080) // 15.6 dyum ekranni shunday taxmin qilamiz
            {
                if (!MenuisLarge)
                {
                    MenuIconPanel.Visible = false;
                    MenuButtonPanel.Visible = true;
                    MenuButtonPanel.Size = new Size(237, 706);
                    MenuisLarge = true;
                }
                else
                {
                    MenuButtonPanel.Visible = false;
                    MenuIconPanel.Visible = true;
                    MenuIconPanel.Size = new Size(87, 706);
                    MenuisLarge = false;
                }
            }
            else if (screenWidth == 2560 && screenHeight == 1600) // 16 dyum ekranni shunday taxmin qilamiz
            {
                if (!MenuisLarge)
                {
                    MenuIconPanel.Visible = false;
                    MenuButtonPanel.Visible = true;
                    MenuButtonPanel.Size = new Size(296, 883);
                    MenuisLarge = true;
                }
                else
                {
                    MenuButtonPanel.Visible = false;
                    MenuIconPanel.Visible = true;
                    MenuIconPanel.Size = new Size(111, 883);
                    MenuisLarge = false;
                }
            }
        }

        public void SelectSection(Panel tabControl1, Panel tabControl2, TabControl tabControl3, string TextButton)
        {
            tabControl1.Visible = true;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            tabControl1.Dock = DockStyle.Fill;
            MenuLabel.Text = "Manager/" + TextButton;
        }
        public void SelectSection(TabControl tabControl1, Panel tabControl2, Panel tabControl3, string TextButton)
        {
            tabControl1.Visible = true;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            ReportsTab.Dock = DockStyle.Fill;
            tabControl1.Dock = DockStyle.Fill;
            MenuLabel.Text = "Manager/" + TextButton;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Hide();
        }

        private void SellerListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Refresh_SellerListDGV(object sender, EventArgs e) // Update datagidView
        {
            string path = @"../../../DataBase/Users.json";

            List<Users> user = new List<Users>();
            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                user = JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }
            ProductLestDGV.DataSource = null;
            ProductLestDGV.DataSource = user.Where(u => u.Role != "Manager").ToList();


        }

        private void ProductListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SellerListImgBTN_Click(object sender, EventArgs e)
        {
            SelectSection(SellersListPanel, ProductListPanel, ReportsTab, "SellerList");
        }

        private void SellerListBTN_Click(object sender, EventArgs e)
        {
            SelectSection(SellersListPanel, ProductListPanel, ReportsTab, "SellerList");
        }

        private void ProductListImgBTN_Click(object sender, EventArgs e)
        {
            SelectSection(ProductListPanel, SellersListPanel, ReportsTab, "ProductList");
        }

        private void ProductsListBTN_Click(object sender, EventArgs e)
        {
            SelectSection(ProductListPanel, SellersListPanel, ReportsTab, "ProductList");
        }

        private void ReportImgBTN_Click(object sender, EventArgs e)
        {
            SelectSection(ReportsTab, SellersListPanel, ProductListPanel, "Reports");
        }

        private void ReportsBTN_Click(object sender, EventArgs e)
        {
            SelectSection(ReportsTab, SellersListPanel, ProductListPanel, "Reports");

        }

        private void KunlikSalesReport_Click(object sender, EventArgs e)
        {

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SellerListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductLestDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                int sum = Convert.ToInt32(e.Value);

                if (sum < 10)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                }
            }
        }

        private void ButSearchSaleKunlik_Click(object sender, EventArgs e)
        {
            // Пути к JSON файлам
            string PathHistorySale = @$"../../../DataBase/History.json";
            string PathProducts = @$"../../../DataBase/Products.json";

            // Получаем выбранные значения из DateTimePicker
            DateTime startDate = dateTimePickerFrom.Value.Date;
            DateTime endDate = dateTimePickerBefore.Value.Date.AddDays(1); // Увеличиваем на 1 день, чтобы включить всю выбранную дату "before"

            if (startDate >= endDate)
            {
                // Устанавливаем значения DateTimePicker по умолчанию
                dateTimePickerFrom.Value = DateTime.Today;
                dateTimePickerBefore.Value = DateTime.Today;
                MessageBox.Show("Sanani Noto'g'ri kiritdingiz.");
            }
            else
            {
                // Читаем и десериализуем данные из JSON
                string jsonHistory = File.ReadAllText(PathHistorySale);
                List<HistorySale> historyList = JsonSerializer.Deserialize<List<HistorySale>>(jsonHistory);

                string jsonProducts = File.ReadAllText(PathProducts);
                List<Product> productList = JsonSerializer.Deserialize<List<Product>>(jsonProducts);

                // Проверка десериализации
                if (historyList == null || productList == null)
                {
                    MessageBox.Show("eror json deserelize");
                    return;
                }

                // Фильтрация истории по выбранной дате с учетом различных форматов дат
                List<HistorySale> filteredHistory = historyList.Where(h =>
                {
                    DateTime saleTime;
                    bool saleTimeParsed = DateTime.TryParseExact(h.ProductSaleTime, new[] { "M/d/yyyy h:mm:ss tt", "dd.MM.yyyy HH:mm:ss" }, null, DateTimeStyles.None, out saleTime);

                    // Отладочные сообщения для проверки парсинга дат и фильтрации
                    Console.WriteLine($"saleTimeParsed: {saleTimeParsed}");
                    if (saleTimeParsed) Console.WriteLine($"saleTime: {saleTime}");

                    return saleTimeParsed && saleTime >= startDate && saleTime < endDate;
                }).ToList();

                // Проверка наличия данных после фильтрации
                if (filteredHistory.Count == 0)
                {
                    MessageBox.Show("Нет данных для отображения в выбранном диапазоне дат.");
                    return;
                }
                // Объединение данных о продажах с именами продуктов
                var filteredHistoryWithProductNames = filteredHistory.Join(
                    productList,
                    sale => sale.ProductID,
                    product => product.Id,
                    (sale, product) => new
                    {
                        sale.SellerID,
                        sale.ProductID,
                        product.ProductName,
                        sale.ProductCount,
                        sale.ProductPrice,
                        sale.ProductSaleTime
                    }).ToList();

                // Привязываем данные к DataGridView
                SaleProductDayDGV.DataSource = filteredHistoryWithProductNames;

                // Обновляем текстовые метки статистики
                double totalSaleCount = filteredHistory.Sum(h => (double)(h.ProductCount));
                label9.Text = $"Product Quantity = {totalSaleCount} pieces";

                double totalSalePrice = filteredHistory.Sum(h => (double)(h.ProductPrice));
                label10.Text = $"Days Profit = {totalSalePrice} $";

            }
        }

        private void ButSearchSaleOylik_Click(object sender, EventArgs e)
        {
            string PathHistorySale = @$"../../../DataBase/History.json";
            string PathProducts = @$"../../../DataBase/Products.json";

            int selectedMonth1 = comboBoxMonth1.SelectedIndex + 1; // Индексы месяцев начинаются с 0

            if (comboBoxYear1.SelectedItem != null)
            {
                int selectedYear1 = (int)comboBoxYear1.SelectedItem;
                string jsonHistory = File.ReadAllText(PathHistorySale);
                List<HistorySale> historyList = JsonSerializer.Deserialize<List<HistorySale>>(jsonHistory);

                string jsonProducts = File.ReadAllText(PathProducts);
                List<Product> productList = JsonSerializer.Deserialize<List<Product>>(jsonProducts);

                List<HistorySale> filteredHistory = historyList.Where(h =>
                {
                    DateTime saleTime;
                    bool saleTimeParsed = DateTime.TryParseExact(h.ProductSaleTime, new[] { "M/d/yyyy h:mm:ss tt", "dd.MM.yyyy HH:mm:ss" }, null, DateTimeStyles.None, out saleTime);

                    return saleTimeParsed &&
                           saleTime.Month == selectedMonth1 && saleTime.Year == selectedYear1;
                }).ToList();

                // Объединение данных о продажах с именами продуктов
                var filteredHistoryWithProductNames = filteredHistory.Join(
                    productList,
                    sale => sale.ProductID,
                    product => product.Id,
                    (sale, product) => new
                    {
                        sale.SellerID,
                        sale.ProductID,
                        product.ProductName,
                        product.ProductCountry,
                        sale.ProductCount,
                        sale.ProductPrice,
                        sale.ProductSaleTime
                    }).ToList();


                SaleProductMonthDGV.DataSource = filteredHistoryWithProductNames;


                // Обновляем текстовые метки статистики
                double totalSaleCount = filteredHistory.Sum(h => (double)(h.ProductCount));
                label13.Text = $"Product Quantity = {totalSaleCount} pieces";

                double totalSalePrice = filteredHistory.Sum(h => (double)(h.ProductPrice));
                label14.Text = $"Month Profit = {totalSalePrice} $";
            }
            else
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting"); return;
            }

        }

        private void SaleProductDayDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SellerReportKunlikSearchBTN_Click(object sender, EventArgs e)
        {
            int countKunlik = 0;
            double priceKunlik = 0;
            string PathHistoryWoking = @$"../../../DataBase/TotalHistory.json";
            string json = File.ReadAllText(PathHistoryWoking);
            List<HistoryWorking> historyListKunlik = JsonSerializer.Deserialize<List<HistoryWorking>>(json);
            List<HistoryWorking> sortKunlik = new List<HistoryWorking>();

            DateTime startDate = SellerReportKunlikDTP.Value.Date;

            if (string.IsNullOrEmpty(SellerReportKunlikSellerUserNameCB.Text))
            {
                MessageBox.Show("Sotuvchi Id sini tanlamadingiz", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Sanalarni aniqlash uchun formatlar ro'yxati
                string[] dateFormats = { "M/d/yyyy h:mm:ss tt", "dd.MM.yyyy HH:mm:ss" };

                var filteredHistory = historyListKunlik.Where(h =>
                {
                    DateTime sellerSignInTime;

                    bool isSignInValid = DateTime.TryParseExact(h.SellerSignInTime, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out sellerSignInTime);

                    return isSignInValid && sellerSignInTime.Date == startDate;
                }).ToList();

                foreach (var item in filteredHistory)
                {
                    if (item.SellerID == UserNameOrqaliIdniOlishKunlik())
                    {
                        if (item.SellerSaleTotalCount != 0)
                        {
                            sortKunlik.Add(item);
                            countKunlik += item.SellerSaleTotalCount.Value;
                            priceKunlik += item.SellerSaleTotalPrice.Value;
                        }
                    }
                }

                SellerReportKunlikTotalCountText.Text = "Total Count :";
                SellerReportKunlikTotalCountValue.Text = countKunlik.ToString() + " ta";
                SellerReportKunlikTotalPriceText.Text = "Total Price : ";
                SellerReportKunlikTotalPriceValue.Text = priceKunlik.ToString() + "$";
                SellerReportKunlikDGV.DataSource = sortKunlik;
            }
        }

        private void SellerReportSanalikSearchBTN_Click(object sender, EventArgs e)
        {
            string PathHistoryWoking = @$"../../../DataBase/TotalHistory.json";

            int count = 0;
            double price = 0;

            DateTime startDate = SellerReportSanalikDTPStart.Value.Date;
            DateTime endDate = SellerReportSanalikDTPEnd.Value.Date;
            SellerReportSanalikDTPStart.Value = DateTime.Today;
            SellerReportSanalikDTPEnd.Value = DateTime.Today.AddDays(1);

            if (string.IsNullOrEmpty(SellerReportSanalikSellerUsernameCB.Text))
            {
                MessageBox.Show("Sotuvchi Id sini tanlamadingiz", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (startDate >= endDate)
            {
                SellerReportSanalikDTPStart.Value = DateTime.Today;
                SellerReportSanalikDTPEnd.Value = DateTime.Today.AddDays(1);
                MessageBox.Show("Sanani Noto'g'ri kiritdingiz.");
                return;
            }

            string json = File.ReadAllText(PathHistoryWoking);
            List<HistoryWorking> historyListsanalik = JsonSerializer.Deserialize<List<HistoryWorking>>(json);
            List<HistoryWorking> sortSanalik = new List<HistoryWorking>();

            // Sanalarni aniqlash uchun formatlar
            string[] dateFormats = { "M/d/yyyy h:mm:ss tt", "dd.MM.yyyy HH:mm:ss" };

            var filteredHistory = historyListsanalik.Where(h =>
            {
                DateTime sellerSignInTime, sellerSignOutTime;

                bool isSignInValid = DateTime.TryParseExact(h.SellerSignInTime, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out sellerSignInTime);
                bool isSignOutValid = DateTime.TryParseExact(h.SellerSignOutTime, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out sellerSignOutTime);

                return isSignInValid && isSignOutValid &&
                       sellerSignInTime >= startDate &&
                       sellerSignOutTime <= endDate;
            }).ToList();

            foreach (var item in filteredHistory)
            {
                if (item.SellerID == UserNameOrqaliIdniOlishSanalik())
                {
                    if (item.SellerSaleTotalCount != 0)
                    {
                        sortSanalik.Add(item);
                        count += item.SellerSaleTotalCount.Value;
                        price += item.SellerSaleTotalPrice.Value;
                    }

                }
            }
            SellerReportSanalikTotalCountText.Text = "Total Count:";
            SellerReportSanalikTotalPriceText.Text = "Total Price:";
            SellerReportSanalikTotalCountValue.Text = count.ToString() + " ta";
            SellerReportSanalikTotalPriceValue.Text = price.ToString() + "$";

            SellerReportSanalikDGV.DataSource = sortSanalik;
        }
        public int UserNameOrqaliIdniOlishOylik()
        {
            List<Users> users = new List<Users>();
            string pathUsers = @"../../../DataBase/Users.json";
            string jsonformat2 = File.ReadAllText(pathUsers);
            users = JsonSerializer.Deserialize<List<Users>>(jsonformat2);

            var objectQaytarish = users.FirstOrDefault(u => u.UserName == SellerReportOylikSellerCB.Text);
            int cBSellerId = objectQaytarish.ID;
            return cBSellerId;
        }
        public int UserNameOrqaliIdniOlishKunlik()
        {
            List<Users> users = new List<Users>();
            string pathUsers = @"../../../DataBase/Users.json";
            string jsonformat2 = File.ReadAllText(pathUsers);
            users = JsonSerializer.Deserialize<List<Users>>(jsonformat2);

            var objectQaytarish = users.FirstOrDefault(u => u.UserName == SellerReportKunlikSellerUserNameCB.Text);
            int cBSellerId = objectQaytarish.ID;
            return cBSellerId;
        }
        public int UserNameOrqaliIdniOlishSanalik()
        {
            List<Users> users = new List<Users>();
            string pathUsers = @"../../../DataBase/Users.json";
            string jsonformat2 = File.ReadAllText(pathUsers);
            users = JsonSerializer.Deserialize<List<Users>>(jsonformat2);

            var objectQaytarish = users.FirstOrDefault(u => u.UserName == SellerReportSanalikSellerUsernameCB.Text);
            int cBSellerId = objectQaytarish.ID;
            return cBSellerId;
        }
        private void SellerReportOylikSearchBTN_Click(object sender, EventArgs e)
        {
            int monthselect = 0;
            double priceValue = 0;
            int productCount = 0;

            Dictionary<string, int> months = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "january", 1 }, { "february", 2 }, { "march", 3 }, { "april", 4 },
                { "may", 5 }, { "june", 6 }, { "july", 7 }, { "august", 8 },
                { "september", 9 }, { "october", 10 }, { "november", 11 }, { "december", 12 }
            };

            if (months.ContainsKey(SellerReportOylikOylarCB.Text.ToLower()))
            {
                monthselect = months[SellerReportOylikOylarCB.Text.ToLower()];
            }
            else
            {
                monthselect = 12;
            }

            if (string.IsNullOrWhiteSpace(SellerReportOylikOylarCB.Text) ||
                string.IsNullOrWhiteSpace(SellerReportOylikYillarCB.Text) ||
                string.IsNullOrWhiteSpace(SellerReportOylikSellerCB.Text))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<HistoryWorking> resultDataGridView = new List<HistoryWorking>();

                string pathHistoryWorkingClic = @"../../../DataBase/TotalHistory.json";
                string jsonformat = File.ReadAllText(pathHistoryWorkingClic);
                List<HistoryWorking> historyWorkingClick = JsonSerializer.Deserialize<List<HistoryWorking>>(jsonformat);

                string[] dateFormats = { "M/d/yyyy h:mm:ss tt", "dd.MM.yyyy HH:mm:ss" };
                var filteredHistory = historyWorkingClick.Where(h =>
                {
                    DateTime sellerSignInTime, sellerSignOutTime;

                    bool isSignInValid = DateTime.TryParseExact(h.SellerSignInTime, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out sellerSignInTime);
                    bool isSignOutValid = DateTime.TryParseExact(h.SellerSignOutTime, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out sellerSignOutTime);

                    return isSignInValid && isSignOutValid;

                }).ToList();

                foreach (var item in filteredHistory)
                {
                    if (item.SellerID == UserNameOrqaliIdniOlishOylik())
                    {
                        DateTime signInDate = DateTime.ParseExact(item.SellerSignInTime, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None);

                        if (signInDate.Month == monthselect && signInDate.Year.ToString() == SellerReportOylikYillarCB.Text && item.SellerSaleTotalCount.Value != 0)
                        {
                            if (item.SellerSaleTotalCount != 0)
                            {
                                resultDataGridView.Add(item);
                                productCount += item.SellerSaleTotalCount.Value;
                                priceValue += item.SellerSaleTotalPrice.Value;
                            }

                        }
                    }
                }

                SellerReportOylikTotalCountText.Text = "Total Count";
                SellerReportOylikTotalCountValue.Text = $"{productCount} ta";
                SellerReportOylikTotalPriceText.Text = "Total Price";
                SellerReportOylikTotalPriceValue.Text = $"{priceValue}$";
                SellerReportOylikDGV.DataSource = resultDataGridView;
            }
        }

        private void SanalikSellerReport_Click(object sender, EventArgs e)
        {

        }

        private void SellerReportSanalikDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MonthProductReport_Click(object sender, EventArgs e)
        {

        }
        private void AnalizReport(out List<HistorySale> filteredHistory, out List<Product> productList)
        {
            string PathHistorySale = @$"../../../DataBase/History.json";
            string PathProducts = @$"../../../DataBase/Products.json";

            int selectedMonthAnaliz = comboBoxMonthAnaliz.SelectedIndex + 1; // Индексы месяцев начинаются с 0

            filteredHistory = new List<HistorySale>();
            productList = new List<Product>();

            if (comboBoxYearAnaliz.SelectedItem != null)
            {
                int selectedYearAnaliz = (int)comboBoxYearAnaliz.SelectedItem;
                string jsonHistory = File.ReadAllText(PathHistorySale);
                List<HistorySale> historyList = JsonSerializer.Deserialize<List<HistorySale>>(jsonHistory);

                string jsonProducts = File.ReadAllText(PathProducts);
                productList = JsonSerializer.Deserialize<List<Product>>(jsonProducts);

                filteredHistory = historyList.Where(h =>
                {
                    DateTime saleTime;
                    bool saleTimeParsed = DateTime.TryParseExact(h.ProductSaleTime, new[] { "M/d/yyyy h:mm:ss tt", "dd.MM.yyyy HH:mm:ss" }, null, DateTimeStyles.None, out saleTime);

                    return saleTimeParsed &&
                           saleTime.Month == selectedMonthAnaliz && saleTime.Year == selectedYearAnaliz;
                }).ToList();
            }
        }

        private void butAnalizNotSell_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMonthAnaliz.Text) || string.IsNullOrEmpty(comboBoxYearAnaliz.Text))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AnalizReport(out List<HistorySale> filteredHistory, out List<Product> productList);

            var filterAnaliz = productList.Where(p => p.ProductEnterCount == p.RemainingProductCount).ToList();
            ProductsAnalizReportDGV.DataSource = filterAnaliz;

            label23.Text = "";
            label24.Text = "";
            label25.Text = "";


        }

        private void butAnalizSell_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMonthAnaliz.Text) || string.IsNullOrEmpty(comboBoxYearAnaliz.Text))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AnalizReport(out List<HistorySale> filteredHistory, out List<Product> productList);
            var filterAnaliz = filteredHistory.Where(p => p.ProductCount > 0).ToList();

            var filteredHistoryWithProductNames = filteredHistory.Join(
                productList,
                sale => sale.ProductID,
                product => product.Id,
                (sale, product) => new
                {
                    product.Id,
                    sale.ProductID,
                    product.RemainingProductCount,
                    product.ProductEnterCount,
                    product.ProductName,
                    product.ProductCountry,
                    sale.ProductCount,
                    sale.ProductPrice,
                    sale.ProductSaleTime
                }).ToList();

            ProductsAnalizReportDGV.DataSource = filteredHistoryWithProductNames;
            var sortedHistoryByPrice = filteredHistoryWithProductNames.OrderByDescending(item => item.ProductPrice).ToList();

            // Получаем три продукта с наибольшими ценами
            var top3Products = sortedHistoryByPrice.Take(3).ToList();

            // Выводим информацию о трех продуктах с наибольшими ценами в лейблы
            if (top3Products.Count >= 1)
            {
                label23.Text = $"1. {top3Products[0].ProductName}: {top3Products[0].ProductPrice} $";
            }
            if (top3Products.Count >= 2)
            {
                label24.Text = $"2. {top3Products[1].ProductName}: {top3Products[1].ProductPrice} $";
            }
            if (top3Products.Count >= 3)
            {
                label25.Text = $"3. {top3Products[2].ProductName}: {top3Products[2].ProductPrice} $";
            }

        }

        private void ProductsAnalizReportDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butAnalizSellDay_Click(object sender, EventArgs e)
        {


        }
        private void butAnalizNotSellDay_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxYearAnaliz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void SanalikProductReport_Click(object sender, EventArgs e)
        {

        }

        private void butAnalizSellDay_Click_1(object sender, EventArgs e)
        {
            // Пути к JSON файлам
            string PathHistorySale = @$"../../../DataBase/History.json";
            string PathProducts = @$"../../../DataBase/Products.json";

            DateTime startDate = dateTimePickerAnalizFrom.Value.Date;
            DateTime endDate = dateTimePickerAnalizBefore.Value.Date.AddDays(1); // Увеличиваем на 1 день, чтобы включить всю выбранную дату "before"

            if (startDate >= endDate)
            {
                // Устанавливаем значения DateTimePicker по умолчанию
                dateTimePickerAnalizFrom.Value = DateTime.Today;
                dateTimePickerAnalizBefore.Value = DateTime.Today;
                MessageBox.Show("Sanani Noto'g'ri kiritdingiz.");
            }
            else
            {
                // Читаем и десериализуем данные из JSON
                string jsonHistory = File.ReadAllText(PathHistorySale);
                List<HistorySale> historyList = JsonSerializer.Deserialize<List<HistorySale>>(jsonHistory);

                string jsonProducts = File.ReadAllText(PathProducts);
                List<Product> productList = JsonSerializer.Deserialize<List<Product>>(jsonProducts);

                // Проверка десериализации
                if (historyList == null || productList == null)
                {
                    MessageBox.Show("eror json deserelize");
                    return;
                }

                // Фильтрация истории по выбранной дате с учетом различных форматов дат
                List<HistorySale> filteredHistory = historyList.Where(h =>
                {
                    DateTime saleTime;
                    bool saleTimeParsed = DateTime.TryParseExact(h.ProductSaleTime, new[] { "M/d/yyyy h:mm:ss tt", "dd.MM.yyyy HH:mm:ss" }, null, DateTimeStyles.None, out saleTime);

                    // Отладочные сообщения для проверки парсинга дат и фильтрации
                    Console.WriteLine($"saleTimeParsed: {saleTimeParsed}");
                    if (saleTimeParsed) Console.WriteLine($"saleTime: {saleTime}");

                    return saleTimeParsed && saleTime >= startDate && saleTime < endDate;
                }).ToList();

                // Проверка наличия данных после фильтрации
                if (filteredHistory.Count == 0)
                {
                    MessageBox.Show("Нет данных для отображения в выбранном диапазоне дат.");
                    return;
                }

                var filterAnaliz = filteredHistory.Where(p => p.ProductCount > 0).ToList();

                var filteredHistoryWithProductNames = filteredHistory.Join(
                    productList,
                    sale => sale.ProductID,
                    product => product.Id,
                    (sale, product) => new
                    {
                        sale.ProductID,
                        product.Id,
                        product.RemainingProductCount,
                        product.ProductEnterCount,
                        product.ProductName,
                        product.ProductCountry,
                        sale.ProductCount,
                        sale.ProductPrice,
                        sale.ProductSaleTime
                    }).ToList();

                ProductsAnalizReportDaysDGV.DataSource = filteredHistoryWithProductNames;
                var sortedHistoryByPrice = filteredHistoryWithProductNames.OrderByDescending(item => item.ProductPrice).ToList();

                // Получаем три продукта с наибольшими ценами
                var top3Products = sortedHistoryByPrice.Take(3).ToList();

                // Выводим информацию о трех продуктах с наибольшими ценами в лейблы
                if (top3Products.Count >= 1)
                {
                    label28.Text = $"1. {top3Products[0].ProductName}: {top3Products[0].ProductPrice} $";
                }
                if (top3Products.Count >= 2)
                {
                    label29.Text = $"2. {top3Products[1].ProductName}: {top3Products[1].ProductPrice} $";
                }
                if (top3Products.Count >= 3)
                {
                    label30.Text = $"3. {top3Products[2].ProductName}: {top3Products[2].ProductPrice} $";
                }

            }
        }

        private void butAnalizNotSellDay_Click_1(object sender, EventArgs e)
        {
            // Пути к JSON файлам
            string PathHistorySale = @$"../../../DataBase/History.json";
            string PathProducts = @$"../../../DataBase/Products.json";

            DateTime startDate = dateTimePickerAnalizFrom.Value.Date;
            DateTime endDate = dateTimePickerAnalizBefore.Value.Date.AddDays(1); // Увеличиваем на 1 день, чтобы включить всю выбранную дату "before"

            if (startDate >= endDate)
            {
                // Устанавливаем значения DateTimePicker по умолчанию
                dateTimePickerAnalizFrom.Value = DateTime.Today;
                dateTimePickerAnalizBefore.Value = DateTime.Today;
                MessageBox.Show("Sanani Noto'g'ri kiritdingiz.");
            }
            else
            {
                // Читаем и десериализуем данные из JSON
                string jsonHistory = File.ReadAllText(PathHistorySale);
                List<HistorySale> historyList = JsonSerializer.Deserialize<List<HistorySale>>(jsonHistory);

                string jsonProducts = File.ReadAllText(PathProducts);
                List<Product> productList = JsonSerializer.Deserialize<List<Product>>(jsonProducts);

                // Проверка десериализации
                if (historyList == null || productList == null)
                {
                    MessageBox.Show("eror json deserelize");
                    return;
                }

                // Фильтрация истории по выбранной дате с учетом различных форматов дат
                List<HistorySale> filteredHistory = historyList.Where(h =>
                {
                    DateTime saleTime;
                    bool saleTimeParsed = DateTime.TryParseExact(h.ProductSaleTime, new[] { "M/d/yyyy h:mm:ss tt", "dd.MM.yyyy HH:mm:ss" }, null, DateTimeStyles.None, out saleTime);

                    // Отладочные сообщения для проверки парсинга дат и фильтрации
                    Console.WriteLine($"saleTimeParsed: {saleTimeParsed}");
                    if (saleTimeParsed) Console.WriteLine($"saleTime: {saleTime}");

                    return saleTimeParsed && saleTime >= startDate && saleTime < endDate;
                }).ToList();

                // Проверка наличия данных после фильтрации
                if (filteredHistory.Count == 0)
                {
                    MessageBox.Show("Нет данных для отображения в выбранном диапазоне дат.");
                    return;
                }

                var filterAnaliz = productList.Where(p => p.ProductEnterCount == p.RemainingProductCount).ToList();
                ProductsAnalizReportDaysDGV.DataSource = filterAnaliz;




            }
        }

        private void ProductsAnalizReportDaysDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OylikSellerReport_Click(object sender, EventArgs e)
        {

        }
    }
}
