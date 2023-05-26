using Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBasic
{
    public partial class Form5 : Form
    {

        Config dbConfig;
        MySqlConnection conn;

        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form5(int userID)
        {
            InitializeComponent();
            this.UserID= userID;
        }

        public int UserID { get; set; }

        private void Form5_Load(object sender, EventArgs e)
        {

            dbConfig = new Config();
            conn = dbConfig.getConnection();

            try
            {


                MySqlCommand fetchQuery = new MySqlCommand("SELECT * FROM cart WHERE userID = '" + UserID + "'", conn);

                MySqlCommand fetchUser = new MySqlCommand("SELECT * FROM users WHERE userID = '" + UserID + "'", conn);

                conn.Open();
                MySqlDataReader getCartTable = fetchQuery.ExecuteReader();
                while (getCartTable.Read())
                {
                    string prodName = getCartTable.GetString("productName");
                    int quantity = getCartTable.GetInt32("productQuantity");
                    int totalPrice = getCartTable.GetInt32("totalPrice");
                    

                    lblProdName.Text = prodName;
                    txtQuantity.Text = quantity.ToString();
                    txtAmount.Text = totalPrice.ToString();


                }

                getCartTable.Close();

                MySqlDataReader getUserTable = fetchUser.ExecuteReader();

                getUserTable.Read();

                string fullName = getUserTable.GetString("Name");
                lblName.Text = fullName;

                getUserTable.Close();



            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConfig = new Config();
            conn = dbConfig.getConnection();
            MessageBox.Show("Order has been placed!");

            conn.Open();
            MySqlCommand fetchQuery = new MySqlCommand("SELECT * FROM cart WHERE userID = '" + UserID + "'", conn);
            MySqlDataReader getCartTable = fetchQuery.ExecuteReader();

            getCartTable.Read();
            string prodName = getCartTable.GetString("productName");
            int quantity = getCartTable.GetInt32("productQuantity");
            int totalPrice = getCartTable.GetInt32("totalPrice");
            int proId = getCartTable.GetInt32("productID");

            getCartTable.Close();


            

            MySqlCommand addOrder = new MySqlCommand("INSERT INTO orders(orderName, orderQuantity, orderTotalPrice, orderDate, productID, userID) VALUES('"+prodName+"','"+quantity + "','"+totalPrice+"','5-25-2023'"+",'"+proId+"','" +UserID+"')", conn);
            MySqlDataReader startAddOrder = addOrder.ExecuteReader();

        }
    }
}
