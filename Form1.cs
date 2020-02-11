using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUI
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent(); 
            connectionString = 
            ConfigurationManager.ConnectionStrings
                ["WindowsFormsAppUI.Properties.Settings.LibraryDBConnectionString"].ConnectionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter
            ("SELECT * FROM Books", conn))
            {
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);
                comboBoxBook.DisplayMember = "Title";
                comboBoxBook.ValueMember = "Title";
                comboBoxBook.DataSource = booksTable;
            }

            /* SPRINT 1 CODE NATHAN MCCABE */
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM Books", conn))
            {
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);
                comboBoxYear.DisplayMember = "BookYear";
                comboBoxYear.ValueMember = "BookYear";
                comboBoxYear.DataSource = booksTable;
            }
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
