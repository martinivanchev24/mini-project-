using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace mini_project_1
{
    public partial class Form3 : Form
    {
        private const string connectionString = @"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();


        }
        private string hashPassword(string password)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);

        }
        private void logInButton_Click(object sender, EventArgs e)
        {

            string password = passwordTextBox.Text;
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            // Define your password pattern, it seems you want to match an 8 character long password with at least one uppercase, one lowercase, one digit, and one special character

            if (Regex.IsMatch(password, pattern))
            {
                //Console.WriteLine("Valid");
                MessageBox.Show("Valid");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                Form1 form1 = new Form1("admin");
                form1.ShowDialog();
            }
            else
            {
                Form1 form1 = new Form1(usernameTextBox.Text);
                form1.ShowDialog();
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT date from Users where username = @username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                string date = Convert.ToString(cmd.ExecuteScalar());
                cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE username = @username AND hash = @hash", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@hash", hashPassword($"{passwordTextBox.Text}{date}"));
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Form1 myForm = new Form1(usernameTextBox.Text);
                    myForm.Show();
                    return;
                }
                MessageBox.Show("Wrong username or password");
            }





        }


    

        private void registerButton_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            if (!usernameTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Invalid username, it should be your personal email");
                return;
            }
            if (!Regex.IsMatch(passwordTextBox.Text, pattern))
            {
                MessageBox.Show("Password needs more special characters");
                return;
            }
                if (passwordTextBox.Text!=passwordTextBox2.Text)
            {
                MessageBox.Show("Passwords don't match");
                return;
            }

            string date = DateTime.Now.ToString();
            string hash = hashPassword($"{passwordTextBox.Text}{date}");
            
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE username=@username", con);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = usernameTextBox.Text;
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("You have already been signed up.");
                return;
            }

                cmd = new SqlCommand("INSERT INTO Users (username, date, hash) VALUES(@username, @date, @hash)", con);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = usernameTextBox.Text;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
                cmd.Parameters.Add("@hash", SqlDbType.NVarChar).Value = hash;
                cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO User_Profiles(username) VALUES(@username)", con);
           
            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User was successfully added");


            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Users ON", con);
            //cmd.ExecuteNonQuery();
            //cmd = new SqlCommand("INSERT INTO Users (UserID, Username, Password) VALUES(@id, @name, @pass)", con);
            //cmd.Parameters.Add("@id", SqlDbType.Int).Value = users;
            //cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = usernameTextBox.Text;
            //cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = passwordTextBox.Text;
            //cmd.ExecuteNonQuery();
            //cmd = new SqlCommand("SET IDENTITY_INSERT Users OFF", con);
            //cmd.ExecuteNonQuery();


        }
    }
}
