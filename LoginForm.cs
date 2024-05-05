﻿using System;
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

namespace TechnicalProductsStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Mirjahon 
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbPassword.Text)) 
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting.Qayta urining","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            string pathUserList = @"../../../Database/User.json";
            List<Users> userList = new List<Users>();

            if(File.Exists(pathUserList))
            {
                string jsonFormat = File.ReadAllText(pathUserList);
                userList = JsonSerializer.Deserialize<List<Users>>(jsonFormat);
            }
            if(userList.Any(item=>item.UserName == tbUserName.Text && item.Password == tbPassword.Text))
            {
                if(userList.Any(m=>m.Role.ToLower() == "manager"))
                {
                    this.Hide();
                    MessageBox.Show("Succesfully");
                    new ManagerForm();
                }
                else
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Bunaqa foydalanuvchi topilmadi.Try again","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
