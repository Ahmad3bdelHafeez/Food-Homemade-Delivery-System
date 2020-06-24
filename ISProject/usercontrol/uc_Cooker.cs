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
    public partial class uc_Cooker : UserControl
    {
        SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataAdapter da, da1, da2;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public uc_Cooker()
        {
            InitializeComponent();
            
            com.Open();
            cmd = new SqlCommand("select order_id,order_name,price,status from Orders where status='Begin'", com);
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

            com.Open();
            cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("Food ID");
            tbl1.Columns.Add("Food Name");
            tbl1.Columns.Add("Price");
            tbl1.Columns.Add("Status");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["Food ID"] = reader1["food_id"];
                row1["Food Name"] = reader1["food_name"];
                row1["Price"] = reader1["price"];
                row1["Status"] = reader1["status"];
                tbl1.Rows.Add(row1);
            }
            reader1.Close();
            com.Close();
            dataGridView1.DataSource = tbl1;

            com.Open();
            da = new SqlDataAdapter("Select food_name from menu where category_id=1", com);
            da.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "food_name";
            comboBox3.Text = "";
            com.Close();
            com.Open();
            da1 = new SqlDataAdapter("Select food_name from menu where category_id=2", com);
            da1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "food_name";
            comboBox1.Text = "";
            com.Close();
            com.Open();
            da2 = new SqlDataAdapter("Select food_name from menu where category_id=3", com);
            da2.Fill(dt2);
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "food_name";
            comboBox2.Text = "";
            com.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
                  }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void uc_Cooker_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            com.Open();
            string update = @"update menu set status=@status where food_name=@name";
            cmd = new SqlCommand(update, com);
            SqlParameter param1 = new SqlParameter("@name", comboBox3.Text);
            cmd.Parameters.Add(param1);
            SqlParameter param = new SqlParameter("@status", "Unavailable");
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            com.Close();


            com.Open();
            cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("Food ID");
            tbl1.Columns.Add("Food Name");
            tbl1.Columns.Add("Price");
            tbl1.Columns.Add("Status");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["Food ID"] = reader1["food_id"];
                row1["Food Name"] = reader1["food_name"];
                row1["Price"] = reader1["price"];
                row1["Status"] = reader1["status"];
                tbl1.Rows.Add(row1);
            }
            reader1.Close();
            com.Close();
            dataGridView1.DataSource = tbl1;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            com.Open();
            string update = @"update menu set status=@status where food_name=@name";
            cmd = new SqlCommand(update, com);
            SqlParameter param1 = new SqlParameter("@name", comboBox3.Text);
            cmd.Parameters.Add(param1);
            SqlParameter param = new SqlParameter("@status", "Available");
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            com.Close();


            com.Open();
            cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("Food ID");
            tbl1.Columns.Add("Food Name");
            tbl1.Columns.Add("Price");
            tbl1.Columns.Add("Status");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["Food ID"] = reader1["food_id"];
                row1["Food Name"] = reader1["food_name"];
                row1["Price"] = reader1["price"];
                row1["Status"] = reader1["status"];
                tbl1.Rows.Add(row1);
            }
            reader1.Close();
            com.Close();
            dataGridView1.DataSource = tbl1;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            com.Open();
            string update = @"update menu set status=@status where food_name=@name";
            cmd = new SqlCommand(update, com);
            SqlParameter param1 = new SqlParameter("@name", comboBox2.Text);
            cmd.Parameters.Add(param1);
            SqlParameter param = new SqlParameter("@status", "Available");
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            com.Close();


            com.Open();
            cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("Food ID");
            tbl1.Columns.Add("Food Name");
            tbl1.Columns.Add("Price");
            tbl1.Columns.Add("Status");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["Food ID"] = reader1["food_id"];
                row1["Food Name"] = reader1["food_name"];
                row1["Price"] = reader1["price"];
                row1["Status"] = reader1["status"];
                tbl1.Rows.Add(row1);
            }
            reader1.Close();
            com.Close();
            dataGridView1.DataSource = tbl1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            com.Open();
            string update = @"update menu set status=@status where food_name=@name";
            cmd = new SqlCommand(update, com);
            SqlParameter param1 = new SqlParameter("@name", comboBox1.Text);
            cmd.Parameters.Add(param1);
            SqlParameter param = new SqlParameter("@status", "Available");
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            com.Close();


            com.Open();
            cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("Food ID");
            tbl1.Columns.Add("Food Name");
            tbl1.Columns.Add("Price");
            tbl1.Columns.Add("Status");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["Food ID"] = reader1["food_id"];
                row1["Food Name"] = reader1["food_name"];
                row1["Price"] = reader1["price"];
                row1["Status"] = reader1["status"];
                tbl1.Rows.Add(row1);
            }
            reader1.Close();
            com.Close();
            dataGridView1.DataSource = tbl1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            com.Open();
            string update = @"update menu set status=@status where food_name=@name";
            cmd = new SqlCommand(update, com);
            SqlParameter param1 = new SqlParameter("@name", comboBox1.Text);
            cmd.Parameters.Add(param1);
            SqlParameter param = new SqlParameter("@status", "Unavailable");
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            com.Close();


            com.Open();
            cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("Food ID");
            tbl1.Columns.Add("Food Name");
            tbl1.Columns.Add("Price");
            tbl1.Columns.Add("Status");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["Food ID"] = reader1["food_id"];
                row1["Food Name"] = reader1["food_name"];
                row1["Price"] = reader1["price"];
                row1["Status"] = reader1["status"];
                tbl1.Rows.Add(row1);
            }
            reader1.Close();
            com.Close();
            dataGridView1.DataSource = tbl1;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            com.Open();
            string update = @"update menu set status=@status where food_name=@name";
            cmd = new SqlCommand(update, com);
            SqlParameter param1 = new SqlParameter("@name", comboBox2.Text);
            cmd.Parameters.Add(param1);
            SqlParameter param = new SqlParameter("@status", "Unavailable");
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            com.Close();


            com.Open();
            cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("Food ID");
            tbl1.Columns.Add("Food Name");
            tbl1.Columns.Add("Price");
            tbl1.Columns.Add("Status");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["Food ID"] = reader1["food_id"];
                row1["Food Name"] = reader1["food_name"];
                row1["Price"] = reader1["price"];
                row1["Status"] = reader1["status"];
                tbl1.Rows.Add(row1);
            }
            reader1.Close();
            com.Close();
            dataGridView1.DataSource = tbl1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text=="")
            {
                MessageBox.Show("ERROR", "Fill all Data", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                com.Open();
                string update = @"update menu set price=@price where food_id=@id";
                cmd = new SqlCommand(update, com);
                SqlParameter param1 = new SqlParameter("@id", textBox1.Text);
                cmd.Parameters.Add(param1);
                SqlParameter param = new SqlParameter("@price", textBox2.Text);
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Done", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);
                com.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                com.Open();
                cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
                SqlDataReader reader1 = cmd.ExecuteReader();
                DataTable tbl1 = new DataTable();
                tbl1.Columns.Add("Food ID");
                tbl1.Columns.Add("Food Name");
                tbl1.Columns.Add("Price");
                tbl1.Columns.Add("Status");
                DataRow row1;
                while (reader1.Read())
                {
                    row1 = tbl1.NewRow();
                    row1["Food ID"] = reader1["food_id"];
                    row1["Food Name"] = reader1["food_name"];
                    row1["Price"] = reader1["price"];
                    row1["Status"] = reader1["status"];
                    tbl1.Rows.Add(row1);
                }
                reader1.Close();
                com.Close();
                dataGridView1.DataSource = tbl1;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(comboBox4.Text==""|| textBox3.Text==""|| textBox4.Text=="")
            {
                MessageBox.Show("ERROR", "Fill all Data", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                com.Open();
                if (comboBox4.Text == "1-Healthy Food")
                {
                    cmd = new SqlCommand("insert into menu(food_name,price,category_id)values('" + textBox3.Text + "','" + textBox4.Text + "','1')", com);
                    cmd.ExecuteNonQuery();
                }
                else if (comboBox4.Text == "2-Desert")
                {
                    cmd = new SqlCommand("insert into menu(food_name,price,category_id)values('" + textBox3.Text + "','" + textBox4.Text + "','2')", com);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("insert into menu(food_name,price,category_id)values('" + textBox3.Text + "','" + textBox4.Text + "','3')", com);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Done", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);
                com.Close();
                comboBox4.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";


                com.Open();
                cmd = new SqlCommand("select food_id,food_name,price,status from menu", com);
                SqlDataReader reader1 = cmd.ExecuteReader();
                DataTable tbl1 = new DataTable();
                tbl1.Columns.Add("Food ID");
                tbl1.Columns.Add("Food Name");
                tbl1.Columns.Add("Price");
                tbl1.Columns.Add("Status");
                DataRow row1;
                while (reader1.Read())
                {
                    row1 = tbl1.NewRow();
                    row1["Food ID"] = reader1["food_id"];
                    row1["Food Name"] = reader1["food_name"];
                    row1["Price"] = reader1["price"];
                    row1["Status"] = reader1["status"];
                    tbl1.Rows.Add(row1);
                }
                reader1.Close();
                com.Close();
                dataGridView1.DataSource = tbl1;
                com.Open();

                
                da = new SqlDataAdapter("Select food_name from menu where category_id=1", com);
                da.Fill(dt);
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "food_name";
                comboBox3.Text = "";
                com.Close();
                com.Open();
                
                da1 = new SqlDataAdapter("Select food_name from menu where category_id=2", com);
                da1.Fill(dt1);
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "food_name";
                comboBox1.Text = "";
                com.Close();
                com.Open();
                
                da2 = new SqlDataAdapter("Select food_name from menu where category_id=3", com);
                da2.Fill(dt2);
                comboBox2.DataSource = dt2;
                comboBox2.DisplayMember = "food_name";
                comboBox2.Text = "";
                com.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            com.Open();
            string update = @"update Orders set status=@name where order_id=@id";
            cmd = new SqlCommand(update, com);
            SqlParameter param1 = new SqlParameter("@id", textBox5.Text);
            cmd.Parameters.Add(param1);
            SqlParameter param = new SqlParameter("@name", "Cooker Done");
            cmd.Parameters.Add(param);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Done", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);
            com.Close();


            com.Open();
            cmd = new SqlCommand("select order_id,order_name,price,status from Orders where status='Begin'", com);
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

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
