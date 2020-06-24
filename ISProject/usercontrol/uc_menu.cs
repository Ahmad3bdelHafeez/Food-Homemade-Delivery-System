using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISProject.usercontrol
{
    public partial class uc_menu : UserControl
    {
        public uc_menu()
        {
            InitializeComponent();
            SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
            com.Open();
            SqlCommand cmd = new SqlCommand("select food_name,price from menu  where status='Available'", com);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
               listBox1.Items.Add(reader["food_name"] + "\t\t" + reader["price"]);
            }
            com.Close();
            //DataTable tbl = new DataTable();
            //tbl.Columns.Add("Health food");
            //tbl.Columns.Add("Price");
            //DataRow row;
            //while(reader.Read())
            //{
            //    row = tbl.NewRow();
            //    row["Health food"] = reader["food_name"];
            //    row["Price"] = reader["price"];
            //    tbl.Rows.Add(row);
            //}
            //reader.Close();
            //com.Close();
            //dataGridView1.DataSource = tbl;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uc_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
