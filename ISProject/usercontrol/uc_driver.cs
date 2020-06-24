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
    public partial class uc_driver : UserControl
    {
        SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
        SqlCommand cmd;
        public uc_driver()
        {

            InitializeComponent();
            com.Open();
            cmd = new SqlCommand("select order_id,order_name,price,status from Orders where status='FQC Done'", com);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Price");
            tbl.Columns.Add("Status");
            DataRow row;
            while (reader.Read())
            {
                row = tbl.NewRow();
                row["ID"] = reader["order_id"];
                row["Name"] = reader["order_name"];
                row["Price"] = reader["price"];
                row["Status"] = reader["status"];
                tbl.Rows.Add(row);
            }
            reader.Close();
            com.Close();
            dataGridView2.DataSource = tbl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            com.Open();
            string update = @"update Orders set status=@name where order_id=@id";
            cmd = new SqlCommand(update, com);
            SqlParameter param1 = new SqlParameter("@id", textBox5.Text);
            cmd.Parameters.Add(param1);
            SqlParameter param = new SqlParameter("@name", "Delivered");
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Done", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);
            com.Close();


            com.Open();
            cmd = new SqlCommand("select order_id,order_name,price,status from Orders where status='FQC Done'", com);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Price");
            tbl.Columns.Add("Status");
            DataRow row;
            while (reader.Read())
            {
                row = tbl.NewRow();
                row["ID"] = reader["order_id"];
                row["Name"] = reader["order_name"];
                row["Price"] = reader["price"];
                row["Status"] = reader["status"];
                tbl.Rows.Add(row);
            }
            reader.Close();
            com.Close();
            dataGridView2.DataSource = tbl;
        }
    }
    
}
