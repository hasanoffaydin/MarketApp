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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if (Seller.Checked)
            {
                Seller seller = new Seller()
                {
                    FullName = fullnameSignup.Text,
                    Gmail = gmailSignup.Text,
                    Password = passwordSignup.Text
                };

                string query = "INSERT INTO Seller (fullName, gmail, password) VALUES (@FullName, @Gmail, @Password)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@FullName", seller.FullName),
                    new SqlParameter("@Gmail", seller.Gmail),
                    new SqlParameter("@Password", seller.Password)
                };

                DataWork connections = new DataWork();
                connections.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Satıcı uğurla əlavə olundu.");
            }
            else if (Buyer.Checked)
            {
                Buyer buyer = new Buyer()
                {
                    FullName = fullnameSignup.Text,
                    Gmail = gmailSignup.Text,
                    Password = passwordSignup.Text
                };

                string query = "INSERT INTO Buyer (fullName, gmail, password) VALUES (@FullName, @Gmail, @Password)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@FullName", buyer.FullName),
                    new SqlParameter("@Gmail", buyer.Gmail),
                    new SqlParameter("@Password", buyer.Password)
                };

                DataWork connections = new DataWork();
                connections.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Alıcı uğurla əlavə olundu.");
            }
            else
            {

                MessageBox.Show("Zəhmət olmasa, Satıcı və ya Alıcı seçin.");
                
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Log log = new Log();    
            log.Show();
            this.Hide();
        }
    }
}
