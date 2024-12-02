using System.Data.SqlClient;
using System.Data;
using MarketApp.Connection;

namespace MarketApp
{
    public partial class Log : Form
    {
        string username;
        string password;
        int sellerId;
        public Log()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (Seller.Checked)
            {
                username = usernameLogin.Text;
                password = passwordLogin.Text;

                string query = "SELECT * FROM Seller WHERE gmail = @Gmail AND password = @Password";


                DataWork connections = new DataWork();


                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Gmail", username),
                    new SqlParameter("@Password", password)
                };
                DataTable dataTables = connections.ExecuteReader(query, parameters);


                if (dataTables.Rows.Count > 0)
                {
                    sellerId = Convert.ToInt32(dataTables.Rows[0]["id"]);
                    MessageBox.Show("Giriş uğurludur!");
                    ForSeller forSeller = new ForSeller(sellerId);
                    forSeller.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gmail və ya parol yanlışdır.");
                }
            }
            else if(Buyer.Checked)
            {
                username = usernameLogin.Text;
                password = passwordLogin.Text;

                string query = "SELECT * FROM Buyer WHERE gmail = @Gmail AND password = @Password";


                DataWork connections = new DataWork();


                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Gmail", username),
                    new SqlParameter("@Password", password)
                };
                DataTable dataTables = connections.ExecuteReader(query, parameters);


                if (dataTables.Rows.Count > 0)
                {
                    int buyerId = Convert.ToInt32(dataTables.Rows[0]["id"]);
                    MessageBox.Show("Giriş uğurludur!");
                    ForBuyer forBuyer = new ForBuyer(buyerId);
                    forBuyer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gmail və ya parol yanlışdır.");
                }
            }
            else
            {
                MessageBox.Show("Seller ve ya Buyer oldugunu Qeyd edin");
                
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();   
            signUp.Show();
            this.Hide();
        }
    }
}
