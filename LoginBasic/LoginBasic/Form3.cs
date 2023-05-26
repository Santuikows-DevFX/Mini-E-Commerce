using System;

using System.Windows.Forms;
using Configuration;
using MySql.Data.MySqlClient;



namespace LoginBasic
{
    public partial class UserCart : Form
    {

        Form5 checkOut;
        Config dbConfig;
        MySqlConnection conn;

        public UserCart()
        {
            InitializeComponent();
        }

        public UserCart(int userID) //accepts argument from form1(userID) -> form2(userID) -> form3
        {
            InitializeComponent();
            this.UserID= userID;
        }

        public int UserID { get; set; }
        private void UserCart_Load(object sender, EventArgs e)
        {
            //refresh the data grid
            cartDataGrid.Rows.Clear();
            cartDataGrid.Refresh();

            dbConfig = new Config();
            conn = dbConfig.getConnection();

            MySqlCommand fetchQuery = new MySqlCommand("SELECT * FROM cart WHERE userID = '"+UserID+"'", conn);

            //add fetch items into the data grid 
            try
            {
                conn.Open();
                MySqlDataReader resultSet = fetchQuery.ExecuteReader();
                while(resultSet.Read())
                {
                    string productName = resultSet.GetString("productName");
                    int unitPrice = resultSet.GetInt32("unitPrice");
                    int quantity = resultSet.GetInt32("productQuantity");
                    int totalPrice = resultSet.GetInt32("totalPrice");

                    cartDataGrid.Rows.Add(productName, unitPrice, quantity, totalPrice);

                    qntBox.Text = resultSet.GetString("productQuantity");

                }

                resultSet.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void decrementQnt_Click(object sender, EventArgs e)
        {
            int currentQnt = Convert.ToInt32(qntBox.Text); //get first the current qnt value of the text box
            if(currentQnt == 1) //check if 1 then dont allow to decrement
            {
                decrementQnt.Enabled = false;
            }else
            {
                decrementQnt.Enabled = true;
                currentQnt--;

            }
            qntBox.Text = currentQnt.ToString(); //set the qnt box to the updated value of the currentQnt variable

            int newQnt = Convert.ToInt32(qntBox.Text); //storing the new qnt of the qnt text box

            dbConfig = new Config();
            conn = dbConfig.getConnection();

            MySqlCommand previousPrice = new MySqlCommand("SELECT * FROM cart WHERE userID = ('" + UserID + "')", conn); //filters the cart by userID

            try
            {
                conn.Open();
                MySqlDataReader fetchtest = previousPrice.ExecuteReader(); 
                fetchtest.Read();
                int prevPrice = fetchtest.GetInt32("unitPrice"); //get the unit price as a reference

                int newPrice = prevPrice * newQnt; //multiplying the unitprice to the number of quantity
                fetchtest.Close();

                //update query
                MySqlCommand updateQuery = new MySqlCommand("UPDATE cart SET totalPrice = ('" + newPrice + "'), productQuantity = ('" + newQnt + "') WHERE userID = ('" + UserID + "')", conn);
                MySqlDataReader updateProduct = updateQuery.ExecuteReader();
                updateProduct.Close();
                UserCart_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void incremenetQnt_Click(object sender, EventArgs e)
        {
            int currentQnt = Convert.ToInt32(qntBox.Text);
            currentQnt++;
            qntBox.Text = currentQnt.ToString();

            int newQnt = Convert.ToInt32(qntBox.Text);

            dbConfig = new Config();
            conn = dbConfig.getConnection();

            MySqlCommand previousPrice = new MySqlCommand("SELECT * FROM cart WHERE userID = ('" + UserID + "')", conn);

            try
            {
                conn.Open();
                MySqlDataReader fetchtest = previousPrice.ExecuteReader();  
                fetchtest.Read();
                int prevPrice = fetchtest.GetInt32("unitPrice");

                int newPrice = prevPrice * newQnt;
                fetchtest.Close();

                MySqlCommand updateQuery = new MySqlCommand("UPDATE cart SET totalPrice = ('" + newPrice + "'), productQuantity = ('"+ newQnt + "') WHERE userID = ('"+UserID+"')", conn);
                MySqlDataReader updateProduct = updateQuery.ExecuteReader();
                updateProduct.Close();
                UserCart_Load(sender, e);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

    
        } //same on decerement but this time it adds

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkOut = new Form5(UserID);
            checkOut.ShowDialog();
            this.Close();
        }
    }
}
