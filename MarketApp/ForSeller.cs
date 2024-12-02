using MarketApp.Connection;
using MarketApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp
{
    public partial class ForSeller : Form
    {
        private int sellerId;
        public ForSeller(int id)
        {
            InitializeComponent();
            sellerId = id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {


            Product product = new Product()
            {
                ProductSellerId = sellerId,
                ProductName = productName.Text,
                ProductPrice = Convert.ToInt32(productPrice.Text),
                ProductQuantity = Convert.ToInt32(productQuantity.Text),
                PurchasePrice = Convert.ToInt32(purchasePrice.Text)
            };


            string query = "INSERT INTO Products (sellerId, productName, productPrice, productQuantity, purchasePrice) " +
                           "VALUES (@SellerId, @ProductName, @ProductPrice, @ProductQuantity, @PurchasePrice)";


            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SellerId", product.ProductSellerId),
                new SqlParameter("@ProductName", product.ProductName),
                new SqlParameter("@ProductPrice", product.ProductPrice),
                new SqlParameter("@ProductQuantity", product.ProductQuantity),
                new SqlParameter("@PurchasePrice", product.PurchasePrice)
            };


            DataWork connections = new DataWork();
            connections.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Məhsul uğurla əlavə olundu.");


            LoadProductsToDataGrid();
        }

        private void LoadProductsToDataGrid()
        {

            string query = "SELECT productName, productPrice, productQuantity, purchasePrice FROM Products WHERE sellerId = @SellerId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SellerId", sellerId)
            };

            DataWork connections = new DataWork();
            DataTable dataTable = connections.ExecuteReader(query, parameters);
            melumatlar.DataSource = dataTable;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.Show();
            this.Hide();
        }

        private void ShowAllData_Click(object sender, EventArgs e)
        {
            LoadProductsToDataGrid();
        }
    }
}
