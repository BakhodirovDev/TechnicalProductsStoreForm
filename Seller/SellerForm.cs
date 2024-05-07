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
        List<Product> users1 = new List<Product>();
        string path = @"../../../DataBase/Products.json";
        public SellerForm()
        {
            InitializeComponent();

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users1 = JsonSerializer.Deserialize<List<Product>>(existingUsersJson);
            }
            dataGridView1.DataSource = users1;
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

        private void SellerAdd_Click(object sender, EventArgs e)
        {
            //Product product = new Product();
            string pathBaskets = @"../../../Seller/Baskets/baskets.json";
            int checkId = users1.FindIndex(m=>m.Id==int.Parse(SellerIDTB.Text))+1;

            LoginForm loginForm = new LoginForm();
            int sellerID = loginForm.sendIdUsers;
            //if(loginForm)

            //Product addProduct = users1.FirsrtOrDefault(m=>m.Id == checkId);
            List<(int, int, Product)> Baskets = new List<(int, int,Product)>();
            if (string.IsNullOrWhiteSpace(SellerIDTB.Text) ||
                string.IsNullOrWhiteSpace(SellerCountTB.Text) ||
                checkId<=0 || users1[checkId-1].RemainingProductCount -int.Parse(SellerCountTB.Text) < 0)
            {
                MessageBox.Show("To'g'ri ma'lumot kiriting", "Ogohlantirish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Baskets.Add((sellerID, int.Parse(SellerCountTB.Text), users1[checkId-1]));

                string jsonBasket = JsonConvert.SerializeObject(Baskets);
                StreamWriter streamWriter = new StreamWriter(pathBaskets);
                streamWriter.WriteLine(jsonBasket);
                streamWriter.Close();
                users1[checkId - 1].RemainingProductCount = users1[checkId-1].RemainingProductCount - int.Parse(SellerCountTB.Text);
            }


            
        }

        private void SellerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
        }

<<<<<<< HEAD
=======
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SellerSearchButton_Click(object sender, EventArgs e)
        {
            //string[] stringProduct = File.ReadAllLines(path);
            List<Product> searchList = new List<Product>();
            foreach (Product item in users1 )
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
<<<<<<< HEAD
=======

>>>>>>> afc53d5cbb610bb5e192a444280aee621fe8c4a2
        private void SellerForm_Load(object sender, EventArgs e)
        {

        }
>>>>>>> fc01f452d1dcd150fd13ac6c70406bd16c254ff0
    }
}
