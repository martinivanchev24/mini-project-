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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mini_project_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Countries (CountriesID, CountryName) VALUES (@id,@country)", con);
            cmd.Parameters.AddWithValue("@id", countryIdTextBox.Text); 
            cmd.Parameters.AddWithValue("@country", countryNameTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was inserted");

        }

        private void updateCountryButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Countries SET CountryName = @country WHERE CountriesID = @id", con);
            cmd.Parameters.AddWithValue("@country", countryNameTextBox.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(countryIdTextBox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was updated");

        }

        private void deleteCountryButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from Countries WHERE CountriesID = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(countryIdTextBox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was deleted");
        }

        private void addTownButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Towns (Town_Name) VALUES (@town)", con);
            cmd.Parameters.AddWithValue("@town", townNameTextBox.Text); 
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was inserted");
        }

        private void updateTownButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Towns SET Town_Name = @town WHERE TownsID = @id", con);
            cmd.Parameters.AddWithValue("@town", townNameTextBox.Text); 
            cmd.Parameters.AddWithValue("@id", int.Parse(townIdTextBox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was updated");

        }

        private void deleteTownButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from Towns WHERE TownsID = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(townIdTextBox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was deleted");
        }
    }
}
