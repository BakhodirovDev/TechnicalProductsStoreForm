using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalProductsStore.Class;
using System.Text.Json;

namespace TechnicalProductsStore.Manager
{
    public partial class ProductsForm : Form
    {
        List<Product> users = new List<Product>();
        public ProductsForm()
        {
            InitializeComponent();
            string path = @"../../../DataBase/Products.json";

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<Product>>(existingUsersJson);
            }
            dataGridView1.DataSource = users;


            // Create ContextMenuStrip
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            // Add "Edit", "Delete" and "Save" options
            menuStrip.Items.Add("Edit");
            menuStrip.Items.Add("Delete");
            menuStrip.Items.Add("Save");
            menuStrip.Items.Add("Create");
            // Assign the ContextMenuStrip to the DataGridView
            dataGridView1.ContextMenuStrip = menuStrip;


        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {


        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
            this.Hide();
        }
    }
}
