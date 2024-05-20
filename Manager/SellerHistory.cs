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
    public partial class SellerHistory : Form
    {
        public bool MenuisLarge = false;
        public SellerHistory()
        {
            InitializeComponent();
            InitializeComboBoxes();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }
        private void InitializeComboBoxes()
        {
            // Инициализация ComboBox для дней
            for (int i = 1; i <= 31; i++)
            {
                //comboBoxDay2.Items.Add(i);
                //comboBoxDay3.Items.Add(i);
            }

            // Инициализация ComboBox для месяцев
            string[] months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            //comboBoxMonth3.Items.AddRange(months);
            //comboBoxMonth2.Items.AddRange(months);
            comboBoxMonth1.Items.AddRange(months);

            // Инициализация ComboBox для годов
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                // comboBoxYear3.Items.Add(i);
                // comboBoxYear2.Items.Add(i);
                comboBoxYear1.Items.Add(i);
            }

            // Устанавливаем начальные значения
            DateTime today = DateTime.Today;
            //comboBoxDay2.SelectedItem = today.Day;
            //comboBoxMonth2.SelectedIndex = today.Month - 1; // Индексы месяцев начинаются с 0
            //comboBoxYear2.SelectedItem = today.Year;
            //comboBoxDay3.SelectedItem = today.Day;
            //comboBoxMonth3.SelectedIndex = today.Month - 1; // Индексы месяцев начинаются с 0
            //comboBoxYear3.SelectedItem = today.Year;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buttonOK_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = filteredHistoryWithProductNames;
                dataGridView3.DataSource = filteredHistoryWithProductNames;
                // Обновляем текстовые метки статистики
                double totalSaleCount = filteredHistory.Sum(h => (double)(h.ProductCount));
                label7.Text = $"Product Quantity = {totalSaleCount} pieces";

                double totalSalePrice = filteredHistory.Sum(h => (double)(h.ProductPrice));
                label8.Text = $"Month Profit = {totalSalePrice} $";



            }
        }
        private void labelTotalSalePrice_Click(object sender, EventArgs e)
        {

        }

        private void jamidaromad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SellerHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            Graphics g = e.Graphics;
            Brush textBrush;

            // TabControl bo'limlari (TabPage) uchun standart ko'rinishlarni sozlash
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Tanlangan bo'lim uchun orqa fonni bo'yash
                textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                // Tanlanmagan bo'limlar uchun orqa fonni bo'yash
                textBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }

            // Matnni vertikal joylashishini aniqlash
            string tabText = tabControl.TabPages[e.Index].Text;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(tabText, e.Font, textBrush, tabBounds, stringFormat);

            // Matnni vertikal aylantirish
            g.ResetTransform();
            g.RotateTransform(270);
            g.TranslateTransform(-tabBounds.Height / 2 - tabBounds.Y, tabBounds.X + tabBounds.Width / 2, MatrixOrder.Append);
            g.DrawString(tabText, e.Font, textBrush, 0, 0);
            g.ResetTransform();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void SellerHistory_Load(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click_1(object sender, EventArgs e)
        {

        }

        public void MenuButton_Click(object sender, EventArgs e)
        {
            MenuisLarge = !MenuisLarge;
            if (MenuisLarge == false)
            {
                MenuPanel.Size = new Size(245, 706);
            }
            else
            {
                MenuPanel.Size = new Size(98, 706);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectSection(History1TabControl, History2TabControl, History3TabControl1, History2Button.Text);
        }

        private void History1Button_Click(object sender, EventArgs e)
        {
            SelectSection(History1TabControl, History2TabControl, History3TabControl1, History2Button.Text);
        }

        private void Sellers1Button_Click(object sender, EventArgs e)
        {
            SelectSection(History2TabControl, History3TabControl1, History1TabControl, Sellers2Button.Text);
        }
        private void Sellers2Button_Click(object sender, EventArgs e)
        {
            SelectSection(History2TabControl, History3TabControl1, History1TabControl, Sellers2Button.Text);
        }

        private void Product2Button_Click(object sender, EventArgs e)
        {
            SelectSection(History3TabControl1, History2TabControl, History1TabControl, Product2Button.Text);
        }

        private void Product1Button_Click(object sender, EventArgs e)
        {
            SelectSection(History3TabControl1, History2TabControl, History1TabControl, Product2Button.Text);
        }
        public void SelectSection(TabControl tabControl1, TabControl tabControl2, TabControl tabControl3, string TextButton)
        {
            tabControl1.Visible = true;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            tabControl1.Dock = DockStyle.Fill;
            MenuLabel.Text = TextButton;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void butMonth_Click(object sender, EventArgs e)
        {
            string PathHistorySale = @$"../../../DataBase/History.json";
            string PathProducts = @$"../../../DataBase/Products.json";

            int selectedMonth1 = comboBoxMonth1.SelectedIndex + 1; // Индексы месяцев начинаются с 0
            int selectedYear1 = (int)comboBoxYear1.SelectedItem;

            // Читаем и десериализуем данные из JSON
            string jsonHistory = File.ReadAllText(PathHistorySale);
            List<HistorySale> historyList = JsonSerializer.Deserialize<List<HistorySale>>(jsonHistory);

            string jsonProducts = File.ReadAllText(PathProducts);
            List<Product> productList = JsonSerializer.Deserialize<List<Product>>(jsonProducts);


            // Фильтрация истории по выбранному месяцу и году
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

            
            dataGridView3.DataSource = filteredHistoryWithProductNames;


            // Обновляем текстовые метки статистики
            double totalSaleCount = filteredHistory.Sum(h => (double)(h.ProductCount));
            label12.Text = $"Product Quantity = {totalSaleCount} pieces";

            double totalSalePrice = filteredHistory.Sum(h => (double)(h.ProductPrice));
            label13.Text = $"Month Profit = {totalSalePrice} $";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lbSumma_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxYear1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
