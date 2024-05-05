using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using TechnicalProductsStore.Class;
using System.Text.Json;

namespace TechnicalProductsStore.Manager
{
    public partial class AddSellerForm : Form
    {
        public int Form;
        public AddSellerForm(int FormID)
        {
            this.Form = FormID;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullName.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(Username.Text) ||
                string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiritish kerak.");
                return;
            }

            string path = @"../../../DataBase/Users.json";

            List<Users> users = new List<Users>();

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }

            if (users.Any(t => t.UserName == Username.Text))
            {
                MessageBox.Show("Sotuvchi ba'zada mavjud.");
                return;
            }

            int nextId = users.Count > 0 ? users.Max(u => u.ID) + 1 : 1;

            Users user = new Users
            {
                ID = nextId,
                FullName = FullName.Text,
                PhoneNumber = PhoneNumber.Text,
                Password = Password.Text,
                UserName = Username.Text,
                Role = $"{Role.Seller}"
            };

            users.Add(user);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(users, options);

            File.WriteAllText(path, json);
            MessageBox.Show("Successfully");
            // Form == 1 bo'lganda ManagerForm ga o'tadi
            if (Form == 1)
            {
                ManagerForm form = new ManagerForm();
                form.StartPosition = FormStartPosition.CenterScreen; // bu funksiya Formani o'rtadan chiqaradi
                form.Show();
                this.Hide();
            }
            // Form == 2 bo'lganda SellerListForm ga o'tadi
            else if (Form == 2)
            {
                SellerListForm form = new SellerListForm();
                form.StartPosition = FormStartPosition.CenterScreen; // bu funksiya Formani o'rtadan chiqaradi
                form.Show();
                this.Hide();
            }
        }

        private void AddSellerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form == 1)
            {
                ManagerForm form = new ManagerForm();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
            else if (Form == 2)
            {
                SellerListForm form = new SellerListForm();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
        }

        private void AddSellerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
