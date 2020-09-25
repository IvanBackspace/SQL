using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Documents;
using System.Windows.Forms;



namespace SQL
{
    public partial class Form1 : Form
    {

        static SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private SqlDataAdapter adapte = null;
        private SqlDataAdapter adapt = null;
        DataTable table;
        public Form1()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=PK-ПК\SQLEXPRESS;Initial Catalog=Sales;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Buyers ", sqlConnection);
            adapte = new SqlDataAdapter("SELECT * FROM Salespeople ", sqlConnection);
            adapt = new SqlDataAdapter("SELECT * FROM Sales ", sqlConnection);
            table = new DataTable();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    table.Clear();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    

                    break;
                case 1:
                    table.Clear();
                    adapte.Fill(table);
                    dataGridView1.DataSource = table;
                    break;
                case 2:
                    table.Clear();
                    adapt.Fill(table);
                    dataGridView1.DataSource = table;
                    break;
            }          
        }
    }
    
    
}
