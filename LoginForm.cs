using Microsoft.VisualBasic.ApplicationServices;
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
using TechnicalProductsStore.Manager;
using TechnicalProductsStore.Seller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechnicalProductsStore
{
    public partial class LoginForm : Form
    {
        int _sendIdUsers;
        public int sendIdUsers
        {
            get { return _sendIdUsers;}
            set { _sendIdUsers = value; } 
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Mirjahon 
        }


        //test git folders
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting.Qayta urining", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string pathUserList = @"../../../DataBase/Users.json";
            List<Users> userList = new List<Users>();


            if (File.Exists(pathUserList))
            {
                string jsonFormat = File.ReadAllText(pathUserList);
                userList = JsonSerializer.Deserialize<List<Users>>(jsonFormat);
            }

            var user = userList.FirstOrDefault(u => u.UserName == tbUserName.Text && u.Password == tbPassword.Text);

            if (user != null)
            {
                if (user.Role == $"{Role.Manager}")
                {
                    sendIdUsers = user.ID;
                    this.Hide();
                    ManagerForm form = new ManagerForm();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();

                }
                else if (user.Role == $"{Role.Seller}")
                {
                    sendIdUsers = user.ID;
                    this.Hide();
                    SellerForm sellerForm = new SellerForm();
                    sellerForm.StartPosition = FormStartPosition.CenterScreen;
                    sellerForm.Show();

                }
                else
                {
                    MessageBox.Show("Role is Error");
                }
            }
            else
            {
                MessageBox.Show("Bunaqa foydalanuvchi topilmadi. Try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btHideEyes_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                tbPassword.PasswordChar = '\0';
                btHideEyes.BackgroundImage = Properties.Resources.eyehide;
            }
            else if (tbPassword.PasswordChar == '\0')
            {
                tbPassword.PasswordChar = '*';
                btHideEyes.BackgroundImage = Properties.Resources.eyeshow;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
