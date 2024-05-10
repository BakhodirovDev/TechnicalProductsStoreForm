using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
