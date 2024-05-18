using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public SellerHistory()
        {
            InitializeComponent();
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
    }
}
