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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace mini_project_1
{
    public partial class Form4 : Form
    {
        string username;
        public Form4(string givenUsername)
        {
            username = givenUsername;
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        // Method to upload the photo to the database
      private void  uploadPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string picturePath = openFileDialog.FileName;
                    Image selectedPicture = Image.FromFile(picturePath);
                    byte[] pictureData = ImageToByteArray(selectedPicture);
                    pictureBox1.Image = selectedPicture;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Method to upload additional information to the database
        //private void UploadAdditionalInfo()
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
        //    con.Open();
        //    byte[] pictureData = ImageToByteArray(selectedPicture);

        //    SqlCommand cmd = new SqlCommand("UPDATE User_Profiles SET firstName=@firstname, lastName=@lastname, country=@country, gender=@gender WHERE username=@username", con);
        //    cmd.Parameters.AddWithValue("@picture", pictureData);
        //    cmd.Parameters.AddWithValue("@firstname", firstNameTextBox.Text);
        //    cmd.Parameters.AddWithValue("@lastname", lastNameTextBox.Text);
        //    cmd.Parameters.AddWithValue("@country", countryTextBox.Text);
        //    cmd.Parameters.AddWithValue("@gender", genderTextBox.Text);
        //    cmd.Parameters.AddWithValue("@username", username);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

    



        private byte[] ImageToByteArray(Image picture)
{
    using (MemoryStream stream = new MemoryStream())
    {
        picture.Save(stream, picture.RawFormat);
        return stream.ToArray();
    }
}
private Image ByteArrayToImage(byte[] data)
{
    using (MemoryStream stream = new MemoryStream(data))
    {
        return Image.FromStream(stream);
    }
}
//private void loadButton_Click(object sender, EventArgs e)
//{
//    SqlConnection con = new SqlConnection(@"Data Source=IDEAPAD-SNOZM;Initial Catalog=Login;Integrated Security=True;");
//    con.Open();
//    SqlCommand cmd = new SqlCommand("SELECT * FROM UserProfiles WHERE username=@username", con);
//    cmd.Parameters.AddWithValue("@username", username);
//    SqlDataAdapter adapter = new SqlDataAdapter();
//    adapter.SelectCommand = cmd;
//    DataTable table = new DataTable();
//    adapter.Fill(table);
//    pictureBox1.Image = ByteArrayToImage((byte[])table.Rows[0]["picture"]);
//    firstNameTextBox.Text = table.Rows[0]["firstName"].ToString();
//    lastNameTextBox.Text = table.Rows[0]["lastName"].ToString();
//    countryTextBox.Text = table.Rows[0]["country"].ToString();
//    genderTextBox.Text = table.Rows[0]["gender"].ToString();
//    con.Close();
//}

        private void profileButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM User_Profiles WHERE username=@username", con);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            pictureBox1.Image = ByteArrayToImage((byte[])table.Rows[0]["picture"]);
            firstNameTextBox.Text = table.Rows[0]["firstName"].ToString();
            lastNameTextBox.Text = table.Rows[0]["lastName"].ToString();
            countryTextBox.Text = table.Rows[0]["country"].ToString();
            genderTextBox.Text = table.Rows[0]["gender"].ToString();
            con.Close();

        }

        private void uploadInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(username + "");
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True"))
                {
                    con.Open();
                    byte[] pictureData = ImageToByteArray(pictureBox1.Image);

                    SqlCommand cmd = new SqlCommand("UPDATE User_Profiles SET picture=@picture, firstName=@firstname, lastName=@lastname, country=@country, gender=@gender WHERE username=@username", con);
                    cmd.Parameters.AddWithValue("@picture", pictureData);
                    cmd.Parameters.AddWithValue("@firstname", firstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@lastname", lastNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@country", countryTextBox.Text);
                    cmd.Parameters.AddWithValue("@gender", genderTextBox.Text);
                    cmd.Parameters.AddWithValue("@username", username);
                   int result= cmd.ExecuteNonQuery();
                    MessageBox.Show(result+"");
                    
                }

                MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private byte[] savePhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }


    }
}

