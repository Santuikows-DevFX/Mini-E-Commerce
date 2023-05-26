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
using Configuration;
using UserInformation;
using LoginBasic;

namespace LoginBasic
{
    public partial class UserInterface : Form
    {

        UserCart cart;
        Form4 userDash;

        Config dbConfig;
        MySqlConnection conn;

        public UserInterface()
        {
            InitializeComponent();
        }

        public UserInterface(int userID) //starting a session from form1(userID) -> form2
        {
            InitializeComponent();
            this.UserID= userID;
        }

        public int UserID { get; set; } //property

        private void UserInterface_Load(object sender, EventArgs e)
        {
            productPicBox.Image = new Bitmap("C:\\Users\\joshu\\OneDrive\\Desktop\\pants.png"); //automatically loads the image when form started


        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {

            dbConfig = new Config();
            conn = dbConfig.getConnection();

            string pName = productName.Text;
            int uPrice = Convert.ToInt32(unitPrice.Text);
            int defaultQuantity = 1;
            
            //insert into the db
            MySqlCommand insertQuery = new MySqlCommand("INSERT INTO cart (productName, unitPrice, productQuantity, totalPrice, userID) VALUES ('"+pName+"', '"+uPrice+"','"+defaultQuantity+"', '"+uPrice+"', '"+UserID+"')", conn);
            try
            {

                conn.Open();
                MySqlDataReader reader = insertQuery.ExecuteReader();
                MessageBox.Show("Added To Cart!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information); //prompt

                this.Hide();
                cart = new UserCart(UserID);
                cart.ShowDialog();
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            cart = new UserCart(UserID);
            cart.ShowDialog();
            this.Close();
        }

        private void dashBoardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userDash = new Form4(UserID);
            userDash.ShowDialog();
            this.Close();
        }
    }
}

