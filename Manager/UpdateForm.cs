using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalProductsStore.Class;

namespace TechnicalProductsStore.Manager
{
    public partial class UpdateForm : Form
    {
        private Product selectedProduct;
        public UpdateForm(Product product)
        {
            InitializeComponent();
            InitializeUpCountryComboBox();

            selectedProduct = product;
        }
        private void InitializeUpCountryComboBox()
        {
            // Задаем источник данных для ComboBox - значения перечисления Country
            comboUpCountry.DataSource = Enum.GetValues(typeof(Country));

            // Устанавливаем ComboBox так, чтобы он позволял пользовательский ввод
            comboUpCountry.DropDownStyle = ComboBoxStyle.DropDown;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, введены ли все необходимые данные для редактирования продукта
            if (string.IsNullOrWhiteSpace(tbUpProductName.Text) ||
                string.IsNullOrWhiteSpace(tbUpDeccription.Text) ||
                string.IsNullOrWhiteSpace(tbUpPrice.Text) ||
                string.IsNullOrWhiteSpace(tbUpEnterProduct.Text) ||
                string.IsNullOrWhiteSpace(comboUpCountry.Text))
            {
                MessageBox.Show("Please enter all required information");
                return;
            }

            // Проверяем правильность введенных данных
            if (!double.TryParse(tbUpPrice.Text, out double price) ||
                !int.TryParse(tbUpEnterProduct.Text, out int enter_product) ||
                price <= 0 || enter_product <= 0 ||
                !Regex.IsMatch(comboUpCountry.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter valid information");
                return;
            }

            // Обновляем информацию о продукте
            selectedProduct.ProductName = tbUpProductName.Text;
            selectedProduct.ProductCountry = comboUpCountry.Text.ToUpper();
            selectedProduct.ProductDescription = tbUpDeccription.Text;
            selectedProduct.ProductPrice = Convert.ToDouble(tbUpPrice.Text);
            selectedProduct.ProductEnterCount = Convert.ToInt32(tbUpEnterProduct.Text);
            selectedProduct.RemainingProductCount = Convert.ToInt32(tbUpRemaningProduct.Text);
            //selectedProduct.UpProductDataTime = DateTime.Now.ToString();

            // Загружаем данные о продуктах из файла
            string pathProduct = @"../../../DataBase/Products.json";
            List<Product> products = new List<Product>();

            if (File.Exists(pathProduct))
            {
                var existingProductPath = File.ReadAllText(pathProduct);
                products = JsonSerializer.Deserialize<List<Product>>(existingProductPath);
            }
            else
            {
                MessageBox.Show("Product data file not found");
                return;
            }

            // Находим индекс выбранного продукта в списке
            int index = products.FindIndex(p => p.Id == selectedProduct.Id);
            if (index != -1)
            {
                // Заменяем старую версию продукта на обновленную
                products[index] = selectedProduct;

                // Пересохраняем обновленные данные в файл
                string updatedJsonProduct = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(pathProduct, updatedJsonProduct);

                MessageBox.Show("Product updated successfully");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Product not found");
            }
        }
    }
}
