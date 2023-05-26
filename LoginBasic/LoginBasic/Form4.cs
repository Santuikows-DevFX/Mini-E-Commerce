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
using MySql.Data.MySqlClient;

namespace LoginBasic
{
    public partial class Form4 : Form
    {
        Config dbConfig;
        MySqlConnection conn;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int userID)
        {
            InitializeComponent();
            this.UserID= userID;
        }

        public int UserID { get; set; }

        private void Form4_Load(object sender, EventArgs e)
        {

            saveBtn.Visible = false;
            nameBox.Enabled = false;

            dbConfig= new Config();
            conn = dbConfig.getConnection();

            MySqlCommand fetchImage = new MySqlCommand("SELECT * FROM users WHERE userID = ('"+UserID+"')", conn);

            try
            {

                conn.Open();
                MySqlDataReader getImage = fetchImage.ExecuteReader();
                getImage.Read();

                userPicBox.Image = new Bitmap(getImage.GetString("picture_directory")); //automatically loads the image when form started
                userNameDB.Text = $"Hello, {getImage.GetString("userName")}!";

                nameBox.Text = getImage.GetString("Name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void editNameBtn_Click(object sender, EventArgs e)
        {
            nameBox.Enabled=true;
            saveBtn.Visible=true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            dbConfig = new Config();
            conn = dbConfig.getConnection();    

            string updatedName = nameBox.Text;
            MySqlCommand updateName = new MySqlCommand("UPDATE users SET Name = ('"+updatedName+"') WHERE userID = ('"+UserID+"')",conn);

            try
            {
                conn.Open();
                MySqlDataReader updateShit = updateName.ExecuteReader();
                MessageBox.Show("UPDATED");

                saveBtn.Visible=false;
                nameBox.Enabled= false;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
