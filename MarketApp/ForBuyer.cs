using MarketApp.Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MarketApp
{
    public partial class ForBuyer : Form
    {
        private int buyerId;
        private int totalPrice = 0;

        public ForBuyer(int buyerId)
        {
            InitializeComponent();
            this.buyerId = buyerId;
        }

        private void ForBuyer_Load(object sender, EventArgs e)
        {
            string query = "SELECT id, productName, productPrice, productQuantity FROM Products";
            DataWork connections = new DataWork();
            DataTable dataTable = connections.ExecuteReader(query);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                int productId = Convert.ToInt32(row["id"]);
                string productName = row["productName"].ToString();
                int productPrice = Convert.ToInt32(row["productPrice"]);
                int productQuantity = Convert.ToInt32(row["productQuantity"]);

                CreateProductCard(productName, productPrice, productId, productQuantity);
            }
        }

        private void CreateProductCard(string productName, int productPrice, int productId, int productQuantity)
        {
            Panel productCard = new Panel
            {
                Size = new Size(200, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label nameLabel = new Label
            {
                Text = productName,
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, 10)
            };

            Label priceLabel = new Label
            {
                Text = $"{productPrice} AZN",
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(10, 40)
            };

            Button buyButton = new Button
            {
                Text = "Al",
                Location = new Point(10, 70),
                Size = new Size(75, 23)
            };

            buyButton.Click += (sender, e) =>
            {
                if (productQuantity > 0)
                {

                    listBox1.Items.Add(productName + " " + productPrice);
                    totalPrice += productPrice;
                    totalAmount.Text = $"Cemi məbləğ: {totalPrice} AZN";


                    productQuantity--;
                    UpdateProductQuantityInDatabase(productId, productQuantity);

                    MessageBox.Show($"{productName} uğurla alındı!");
                }
                else
                {
                    MessageBox.Show("Bu məhsul artıq tükənib!");
                }
            };

            productCard.Controls.Add(nameLabel);
            productCard.Controls.Add(priceLabel);
            productCard.Controls.Add(buyButton);

            flowLayoutPanel1.Controls.Add(productCard);
        }

        private void UpdateProductQuantityInDatabase(int productId, int newQuantity)
        {
            string query = "UPDATE Products SET productQuantity = @NewQuantity WHERE id = @ProductId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NewQuantity", newQuantity),
                new SqlParameter("@ProductId", productId)
            };

            DataWork connections = new DataWork();
            connections.ExecuteNonQuery(query, parameters);
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            totalAmount.Text = "Cemi Mebleg : 0 AZN";
            listBox1.Items.Clear();
            MessageBox.Show("Odenis Ugurla Heyata Kecdi :)");
        }
    }
}
