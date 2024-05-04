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

namespace TechnicalProductsStore.Manager
{
    public partial class SellerListForm : Form
    {
        List<Users> users = new List<Users>();
        public SellerListForm()
        {
            InitializeComponent();
            string path = @"../../../DataBase/Users.json";

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }

            var filteredUsers = users.Where(u => u.Role != "Manager").ToList();
            dataGridView1.DataSource = filteredUsers;


            // Create ContextMenuStrip
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            // Add "Edit", "Delete" and "Save" options
            menuStrip.Items.Add("Edit");
            menuStrip.Items.Add("Delete");
            menuStrip.Items.Add("Save");
            menuStrip.Items.Add("Create");
            // Assign the ContextMenuStrip to the DataGridView
            dataGridView1.ContextMenuStrip = menuStrip;

            // Add event handlers for the "Edit", "Delete" and "Save" options
            menuStrip.Items[0].Click += new EventHandler(Edit_Click);
            menuStrip.Items[1].Click += new EventHandler(Delete_Click);
            menuStrip.Items[2].Click += new EventHandler(Save_Click);
            menuStrip.Items[3].Click += new EventHandler(CreateUser);

            // Initially hide the "Save" option
            menuStrip.Items[2].Visible = false;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var user = (Users)selectedRow.DataBoundItem;
                UpdateUser(user);
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

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];
                // Get the user from the selected row
                var user = (Users)selectedRow.DataBoundItem;
                // Call the DeleteUser method
                DeleteUser(user.ID);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];
                // Get the user from the selected row
                var user = (Users)selectedRow.DataBoundItem;
                // Call the UpdateUser method
                UpdateUser(user);
                // Save to file
                SaveUsersToFile();

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

        public void CreateUser(object sender, EventArgs e)
        {
            AddSellerForm addUser = new AddSellerForm(2);
            addUser.StartPosition = FormStartPosition.CenterScreen;
            addUser.Show();
            this.Hide();
        }

        // Read operation
        public Users ReadUser(int id)
        {
            return users.FirstOrDefault(u => u.ID == id);
        }

        // Update operation
        public void UpdateUser(Users user)
        {
            // Find the user
            var existingUser = users.FirstOrDefault(u => u.ID == user.ID);
            if (existingUser != null)
            {
                // Update the user
                existingUser.FullName = user.FullName;
                existingUser.Role = user.Role;
                // ... update other properties as needed

                // Update the data source
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = users.Where(u => u.Role != "Manager").ToList();

                // Save to file
                SaveUsersToFile();
            }
        }

        // Delete operation
        public void DeleteUser(int id)
        {
            // Find the user
            var user = users.FirstOrDefault(u => u.ID == id);
            if (user != null)
            {
                // Remove the user from the list
                users.Remove(user);

                // Update the data source
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = users.Where(u => u.Role != "Manager").ToList();

                // Save to file
                SaveUsersToFile();
            }
        }

        // Save users to file
        public void SaveUsersToFile()
        {
            string path = @"../../../DataBase/Users.json";
            var usersJson = System.Text.Json.JsonSerializer.Serialize(users);
            File.WriteAllText(path, usersJson);
        }
        private void SellerListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SellerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }
    }
}
