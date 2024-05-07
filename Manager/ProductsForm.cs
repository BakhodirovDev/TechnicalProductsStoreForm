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
using Microsoft.VisualBasic.ApplicationServices;

namespace TechnicalProductsStore.Manager
{
    public partial class ProductsForm : Form
    {
        List<Product> product = new List<Product>();
        public ProductsForm()
        {
            InitializeComponent();
            string path = @"../../../DataBase/Products.json";

            if (File.Exists(path))
            {
                var existingProductJson = File.ReadAllText(path);
                product = JsonSerializer.Deserialize<List<Product>>(existingProductJson);
            }
            dataGridView1.DataSource = product;


            // Create ContextMenuStrip
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            // Add "Edit", "Delete", "Save" and "Create" options
            menuStrip.Items.Add("Edit");
            menuStrip.Items.Add("Delete");
            menuStrip.Items.Add("Save");
            menuStrip.Items.Add("Create");
            // Assign the ContextMenuStrip to the DataGridView
            dataGridView1.ContextMenuStrip = menuStrip;

            dataGridView1.ContextMenuStrip.Items[2].Visible = false;

            // Add event handlers for the "Edit", "Delete" and "Save" options
            menuStrip.Items[0].Click += new EventHandler(Edit_Click);
            menuStrip.Items[1].Click += new EventHandler(Delete_Click);
            menuStrip.Items[2].Click += new EventHandler(Save_Click);
            menuStrip.Items[3].Click += new EventHandler(CreateUser);

        }
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var product = (Product)selectedRow.DataBoundItem;
                UpdateUser(product);
                dataGridView1.ContextMenuStrip.Items[0].Visible = false;
                dataGridView1.ContextMenuStrip.Items[1].Visible = false;
                dataGridView1.ContextMenuStrip.Items[2].Visible = true;
                dataGridView1.ContextMenuStrip.Items[3].Visible = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Yellow;
            }
            catch
            {
                MessageBox.Show("To'liq qatorni tanlab keyin 'Edit' tugmasini bosing.");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];
                // Get the user from the selected row
                var product = (Product)selectedRow.DataBoundItem;
                // Call the UpdateUser method
                UpdateUser(product);
                // Save to file
                SaveProductToFile();

                // Show the "Edit" and "Delete" options and hide the "Save" option
                dataGridView1.ContextMenuStrip.Items[0].Visible = true;
                dataGridView1.ContextMenuStrip.Items[1].Visible = true;
                dataGridView1.ContextMenuStrip.Items[2].Visible = false;
                dataGridView1.ContextMenuStrip.Items[3].Visible = true;
                selectedRow.DefaultCellStyle.BackColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];
                // Get the user from the selected row
                var product = (Product)selectedRow.DataBoundItem;
                // Call the DeleteUser method
                DeleteProduct(product.Id);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void CreateUser(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct(2);
            createProduct.StartPosition = FormStartPosition.CenterScreen;
            createProduct.Show();
            this.Hide();
        }
        
        public void UpdateUser(Product product)
        {
            // Find the product
            var existingProduct = this.product.FirstOrDefault(u => u.Id == product.Id);
            if (existingProduct != null)
            {

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.product.ToList();
                // Save to file
                SaveProductToFile();
            }
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
        public void DeleteProduct(int id)
        {
            // Find the user
            var product = this.product.FirstOrDefault(u => u.Id == id);
            if (product != null)
            {
                // Remove the user from the list
                this.product.Remove(product);

                // Update the data source
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.product.ToList();

                // Save to file
                SaveProductToFile();
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
