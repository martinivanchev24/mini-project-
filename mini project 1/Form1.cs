using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace mini_project_1
{
    public partial class Form1 : Form
    {
        string username;
        public Form1(string givenUsername)
        {
            InitializeComponent();
            username = givenUsername;
            if(givenUsername == "admin")
            {
                adminFormButton.Visible = true;
                databaseButton.Visible = true;
                profileButton.Visible = false;
            }
            else
            {
                adminFormButton.Visible = false;
                databaseButton.Visible = true;
                profileButton.Visible = true;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }


        private void adminFormButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TownsID, Town_Name FROM Towns", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable townsTable = new DataTable();
            adapter.Fill(townsTable);
          
            TownsListBox.DataSource = townsTable;
            TownsListBox.DisplayMember = "Town_Name";
            TownsListBox.ValueMember = "TownsID";
            con.Close();

             cmd = new SqlCommand("SELECT CountriesID, CountryName FROM Countries", con);
            adapter.SelectCommand = cmd;
            DataTable countriesTable = new DataTable();
            adapter.Fill(countriesTable);
            CountriesListBox.DataSource = countriesTable;
            CountriesListBox.DisplayMember = "CountryName";
            CountriesListBox.ValueMember = "CountriesID";
            con.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Form4 myForm = new Form4(username);
            myForm.Show();
        }

        private void databaseButton_Click(object sender, EventArgs e)
        {
            Form5 myForm = new Form5();
            myForm.Show();
        }
    }
}