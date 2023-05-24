using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Configuration;
using UserInformation;

namespace LoginBasic
{
    public partial class Form1 : Form
    {
        //global obj
        Config dbConnection;
        User user;
        MySqlConnection conn;
        UserInterface userIntef;

      MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            dbConnection = new Config();
            user = new User();

            //get value from text box
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            conn = dbConnection.getConnection();


            //sql command (query, conn)
            cmd = new MySqlCommand("SELECT * FROM users WHERE userName = ('" + username + "') AND userPass = ('" + password + "')", conn);
            try
            {
                //open the connection
                conn.Open();
                MySqlDataReader resultSet = cmd.ExecuteReader();

                resultSet.Read(); //readonce

                if (resultSet.HasRows) //HasRows checks if the data exists in the table
                {

                    user.UserID = resultSet.GetInt32("userID");
                    userIntef = new UserInterface(user.UserID);
                    this.Hide(); //hide current form
                    userIntef.ShowDialog(); //show the next form
                    this.Close();//close this form
                }
                else
                {
                    MessageBox.Show("User Does Not Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
            }

            conn.Close();
        }
    }
}

namespace UserInformation //to get the userID
{
    public class User
    {
        int userID = 0;

        public User()
        {
            this.userID = 0;
        }

        public User(int userID) 
        {
            this.userID = userID;
        }

        public int UserID
        {
            get
            {
                return this.userID;
            }
            set
            {
                this.userID = value;
            }
        }
    }
}

namespace Configuration
{
    public class Config
    {
        MySqlConnection conn;

        public MySqlConnection getConnection()
        {
            try
            {
                conn = new MySqlConnection("datasource=localhost;username=root;password=;Initial Catalog=wanifytest_db");

                return conn;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return null;
        }

    }
} //db config

