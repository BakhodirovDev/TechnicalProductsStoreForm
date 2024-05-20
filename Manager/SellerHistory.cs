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
    public partial class SellerHistory : Form
    {
        public bool MenuisLarge = false;
        public SellerHistory()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            dateTimePicker1Start.Value = DateTime.Today;
            dateTimePicker2Finish.Value = DateTime.Today.AddDays(1);

            // Create ContextMenuStrip
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            // Add "Diagramma"
            menuStrip.Items.Add("Diagramma");

            dataGridView2kunlik.ContextMenuStrip = menuStrip;
            menuStrip.Items[0].Click += new EventHandler(Chart_Click);

            string pathUsers = @"../../../DataBase/Users.json";
            string jsonUser = File.ReadAllText(pathUsers);
            List<Users> newUserList = JsonSerializer.Deserialize<List<Users>>(jsonUser);

            string PathHistoryWoking = @$"../../../DataBase/TotalHistory.json";
            string jsonwork = File.ReadAllText(PathHistoryWoking);
            List<HistoryWorking> newhistoryList = JsonSerializer.Deserialize<List<HistoryWorking>>(jsonwork);


            for (int i = 0; i < newUserList.Count; i++)
            {
                if (newUserList[i].Role.ToLower() != "manager")
                {
                    cBSellerId.Items.Add(newUserList[i].ID);
                    cBKunlikSellerId.Items.Add(newUserList[i].ID);
                    cBsanalik.Items.Add(newUserList[i].ID);
                }
            }

            lbSanalikText.Text = "";
            lbSanalikCount.Text = "";
            lbSanalikPrice.Text = "";
            lbSanalikPricetext.Text = "";

            lbKunlikCountText.Text = "";
            lbKunlikCountValue.Text = "";
            lbKunlikPriceText.Text = "";
            lbKunlikPriceValue.Text = "";

            lbTotalCount_0.Text = "";
            lbTotalCountValue_O.Text = "";
            lbTotalPriceValue_O.Text = "";
            lbTotalPrice_O.Text = "";

            cBSellerId.DropDownStyle = ComboBoxStyle.DropDownList;
            cBOylar_O.DropDownStyle = ComboBoxStyle.DropDownList;
            cBYillar_O.DropDownStyle = ComboBoxStyle.DropDownList;

            cBKunlikSellerId.DropDownStyle = ComboBoxStyle.DropDownList;
            cBsanalik.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Chart_Click(object sender, EventArgs e)
        {
           
                //tP3Kunlik.SelectedTab = tP8Chart; 
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            string PathHistoryWoking = @$"../../../DataBase/TotalHistory.json";

            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today.AddDays(1);
            label1.Text = "";
            label5.Text = "";
            label4.Text = "";
            label6.Text = "";
            if (startDate >= endDate)
            {
                dateTimePickerStart.Value = DateTime.Today;
                dateTimePickerEnd.Value = DateTime.Today.AddDays(1);
                MessageBox.Show("Sanani Noto'g'ri kiritdingiz.");
            }
            else
            {
                string json = File.ReadAllText(PathHistoryWoking);
                List<HistoryWorking> historyList = JsonSerializer.Deserialize<List<HistoryWorking>>(json);

                var filteredHistory = historyList.Where(h =>
                    DateTime.Parse(h.SellerSignInTime) >= startDate &&
                    DateTime.Parse(h.SellerSignOutTime) <= endDate).ToList();

                dataGridView1.DataSource = filteredHistory;
                label1.Text = "Sotilgan mahsulotlar soni:";
                label5.Text = "Jami Daromad:";
                double totalsalecount = (double)filteredHistory.Sum(h => h.SellerSaleTotalCount);
                label4.Text = totalsalecount.ToString() + " ta";
                double totalSalePrice = (double)filteredHistory.Sum(h => h.SellerSaleTotalPrice);
                label6.Text = totalSalePrice.ToString() + " so'm";

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

        private void cBOylar_O_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchOylik_Click(object sender, EventArgs e)
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

            if (months.ContainsKey(cBOylar_O.Text.ToLower()))
            {
                monthselect = months[cBOylar_O.Text.ToLower()];
            }
            else
            {
                monthselect = 12;
            }

            if (string.IsNullOrWhiteSpace(cBOylar_O.Text)
             || string.IsNullOrWhiteSpace(cBSellerId.Text)
             || string.IsNullOrWhiteSpace(cBYillar_O.Text))
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
                    if (item.SellerID == int.Parse(cBSellerId.Text))
                    {
                        DateTime signInDate = DateTime.ParseExact(item.SellerSignInTime, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None);

                        if (signInDate.Month == monthselect && signInDate.Year.ToString() == cBYillar_O.Text && item.SellerSaleTotalCount.Value != 0)
                        {
                            resultDataGridView.Add(item);
                            productCount += item.SellerSaleTotalCount.Value;
                            priceValue += item.SellerSaleTotalPrice.Value;
                        }
                    }
                }

                lbTotalCount_0.Text = "Total Count";
                lbTotalCountValue_O.Text = $"{productCount}";
                lbTotalPriceValue_O.Text = $"{priceValue}";
                lbTotalPrice_O.Text = "Total Price";
                dataGridViewOylik.DataSource = resultDataGridView;
            }
        }

        private void cBYillar_O_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tP4Sanalik_Click(object sender, EventArgs e)
        {

        }

        private void searchSanalik_Click(object sender, EventArgs e)
        {
            string PathHistoryWoking = @$"../../../DataBase/TotalHistory.json";

            int count = 0;
            double price = 0;

            DateTime startDate = dateTimePicker1Start.Value.Date;
            DateTime endDate = dateTimePicker2Finish.Value.Date;
            dateTimePicker1Start.Value = DateTime.Today;
            dateTimePicker2Finish.Value = DateTime.Today.AddDays(1);

            if (string.IsNullOrEmpty(cBsanalik.Text))
            {
                MessageBox.Show("Sotuvchi Id sini tanlamadingiz", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (startDate >= endDate)
            {
                dateTimePicker1Start.Value = DateTime.Today;
                dateTimePicker2Finish.Value = DateTime.Today.AddDays(1);
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
                if (item.SellerID == int.Parse(cBsanalik.Text))
                {
                    sortSanalik.Add(item);
                    count += item.SellerSaleTotalCount.Value;
                    price += item.SellerSaleTotalPrice.Value;
                }
            }

            lbSanalikText.Text = "Sotilgan mahsulotlar soni:";
            lbSanalikPricetext.Text = "Jami Daromad:";
            lbSanalikCount.Text = count.ToString();
            lbSanalikPrice.Text = price.ToString();

            dataGridView3Sanalik.DataSource = sortSanalik;
        }


        private void searchKunlik_Click(object sender, EventArgs e)
        {
            int countKunlik = 0;
            double priceKunlik = 0;
            string PathHistoryWoking = @$"../../../DataBase/TotalHistory.json";
            string json = File.ReadAllText(PathHistoryWoking);
            List<HistoryWorking> historyListKunlik = JsonSerializer.Deserialize<List<HistoryWorking>>(json);
            List<HistoryWorking> sortKunlik = new List<HistoryWorking>();

            DateTime startDate = dateTimePicker1Kunlik.Value.Date;

            if (string.IsNullOrEmpty(cBKunlikSellerId.Text))
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
                    if (item.SellerID == int.Parse(cBKunlikSellerId.Text))
                    {
                        sortKunlik.Add(item);
                        countKunlik += item.SellerSaleTotalCount.Value;
                        priceKunlik += item.SellerSaleTotalPrice.Value;
                    }
                }

                lbKunlikCountText.Text = "Sotilganlar soni";
                lbKunlikCountValue.Text = countKunlik.ToString();
                lbKunlikPriceText.Text = "Total Price : ";
                lbKunlikPriceValue.Text = priceKunlik.ToString();
                dataGridView2kunlik.DataSource = sortKunlik;
            }
        }


    }
}
