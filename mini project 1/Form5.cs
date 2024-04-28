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
    public partial class Form5 : Form
    {

        private string connectionString = @"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True";
        private DataTable resultTable;
        private string filters = "";
        public Form5()
        {
            InitializeComponent();
        
     


          
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ORDINAL_POSITION,COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'User_Profiles'", con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable townsTable = new DataTable();

                    adapter.Fill(townsTable);
                    //columnsComboBox.DataSource = townsTable;
                    comboBox1.DisplayMember = "COLUMN_NAME";
                comboBox1.ValueMember = "ORDINAL_POSITION";
                comboBox1.DataSource = townsTable;
                comboBox1.Enabled = true;
                    textBox2.Enabled = false;
                    filters = string.Empty;
                    //columnsComboBox.SelectedIndexChanged += columnsComboBox_SelectedIndexChanged_1;
                }

            }
        private void Form5_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from User_Profiles", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                resultTable = new DataTable();
                adapter.Fill(resultTable);
                dataGridView1.DataSource = resultTable;
            }

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("SELECT ORDINAL_POSITION,COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Photos'", con);
            //    SqlDataAdapter adapter = new SqlDataAdapter();
            //    adapter.SelectCommand = cmd;
            //    DataTable townsTable = new DataTable();

            //    adapter.Fill(townsTable);
            //    columnsComboBox.DataSource = townsTable;
            //    columnsComboBox.DisplayMember = "COLUMN_NAME";
            //    columnsComboBox.ValueMember = "ORDINAL_POSITION";
            //    columnsComboBox.Enabled = true;
            //    textBox2.Enabled = false;
            //}
            filters = string.Empty;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            andButton.Enabled = true;
            orButton.Enabled = true;

        }


        private void clearFiltersButton_Click(object sender, EventArgs e)
        {


            textBox2.Text = string.Empty;
            filters = string.Empty;
            textBox2.Enabled = false;
            andButton.Enabled = false;
            orButton.Enabled = false;
            comboBox1.Enabled = true;
        }

        private void andButton_Click(object sender, EventArgs e)
        {

            if (!filters.Equals(""))
            {
                filters += " Like '%" + textBox2.Text + "%'";
                MessageBox.Show(filters);
                filters += " AND ";
                textBox2.Text = "";
                textBox2.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                comboBox1.Enabled = true;

            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            filters += comboBox1.GetItemText(comboBox1.SelectedItem).Trim();
            comboBox1.Enabled = false;
            textBox2.Enabled = true;

        }
        private void orButton_Click(object sender, EventArgs e)
        {

            if (!filters.Equals(""))
            {
                filters += " Like '%" + textBox2.Text + "%'";
                MessageBox.Show(filters);
                filters += " OR ";
                textBox2.Text = "";
                textBox2.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                comboBox1.Enabled = true;

            }
        }

        //private void columnsComboBox_SelectedIndexChanged(object sender, EventArgs e)


        private void filterButton_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show(filters);
            if (!filters.Equals(string.Empty))
            {
                filters += " Like '%" + textBox2.Text + "%'";
                MessageBox.Show(filters);
                DataView dv = resultTable.DefaultView;
                dv.RowFilter = filters;

                textBox2.Text = string.Empty;
                //filters = string.Empty;
                textBox2.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                comboBox1.Enabled = true;
            }

        }

      
    }
    }
    


