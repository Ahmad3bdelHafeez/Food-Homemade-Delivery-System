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

    public partial class uc_delivery : UserControl
    {
        string str="";

        SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
        SqlCommand cmd ;
        SqlDataAdapter da,da1,da2;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public uc_delivery()
        {
           
            InitializeComponent();
            com.Open();
            da = new SqlDataAdapter("Select food_name from menu where category_id=1 and status='Available'", com);
            da.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "food_name";
            comboBox3.Text = "";
            com.Close();
            com.Open();
            da1 = new SqlDataAdapter("Select food_name from menu where category_id=2 and status='Available'", com);
            da1.Fill(dt1);
            comboBox4.DataSource = dt1;
            comboBox4.DisplayMember = "food_name";
            comboBox4.Text = "";
            com.Close();
            com.Open();

            da2 = new SqlDataAdapter("Select food_name from menu where category_id=3 and status='Available'", com);
            da2.Fill(dt2);
            comboBox5.DataSource = dt2;
            comboBox5.DisplayMember = "food_name";
            comboBox5.Text = "";
            com.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            com.Open();

            string up = @"select price from menu where food_name=@name";
            cmd = new SqlCommand(up, com);

            SqlParameter param1 = new SqlParameter("@name", listBox1.SelectedItem);

            cmd.Parameters.Add(param1);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox7.Text = Convert.ToString(Convert.ToUInt32(textBox7.Text) - Convert.ToUInt32(reader["price"].ToString()));
            }

            com.Close();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(str == ""||textBox4.Text == ""||
            textBox5.Text == ""||
            textBox6.Text == ""||
            
            
            textBox7.Text == "")
            {
                MessageBox.Show("Please Fill All Data ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                com.Open();
                try
                {

                    cmd = new SqlCommand("insert into Orders(order_name,price,status)values('" + str + "'," + textBox7.Text + ",'Begin')", com);

                    cmd.ExecuteNonQuery();


                    if (radioButton4.Checked)
                    {

                        cmd = new SqlCommand("insert into Clients(phone,name,address)values(" + textBox5.Text + ",'" + textBox6.Text + "','" + textBox4.Text + "')", com);
                        cmd.ExecuteNonQuery();


                    }
                    else if (radioButton3.Checked)
                    {

                        string update = @"update Clients set name=@name ,address=@adress where phone=@phone";
                        cmd = new SqlCommand(update, com);
                        SqlParameter param1 = new SqlParameter("@name", textBox6.Text);
                        cmd.Parameters.Add(param1);
                        SqlParameter param = new SqlParameter("@phone", textBox5.Text);
                        cmd.Parameters.Add(param);
                        SqlParameter param2 = new SqlParameter("@adress", textBox4.Text);
                        cmd.Parameters.Add(param2);
                        cmd.ExecuteNonQuery();
                        
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error accured " + ex, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    com.Close();
                }
                com.Open();
                string up = @"select order_id from Orders where order_name=@x";
                cmd = new SqlCommand(up, com);


                SqlParameter param4 = new SqlParameter("@x", str);

                cmd.Parameters.Add(param4);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Your Order ID: " + reader["order_id"].ToString(), "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                com.Close();
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                listBox1.Text = "";
                comboBox2.Text = "";
                textBox7.Text = "";
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox3.Text);
            com.Open();

            string up = @"select price from menu where food_name=@name";
            cmd = new SqlCommand(up, com);

            SqlParameter param1 = new SqlParameter("@name", comboBox3.Text);

            cmd.Parameters.Add(param1);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                textBox7.Text = Convert.ToString(Convert.ToUInt32(textBox7.Text) + Convert.ToUInt32(reader["price"].ToString()));
            }

            com.Close();
        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox4.Text);

            com.Open();

            string up = @"select price from menu where food_name=@name";
            cmd = new SqlCommand(up, com);

            SqlParameter param1 = new SqlParameter("@name", comboBox4.Text);

            cmd.Parameters.Add(param1);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                textBox7.Text = Convert.ToString(Convert.ToUInt32(textBox7.Text) + Convert.ToUInt32(reader["price"].ToString()));
            }

            com.Close();
        }

        private void pictureBox7_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox5.Text);
            com.Open();

            string up = @"select price from menu where food_name=@name";
            cmd = new SqlCommand(up, com);

            SqlParameter param = new SqlParameter("@name", comboBox5.Text);

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                textBox7.Text = Convert.ToString(Convert.ToUInt32(textBox7.Text) + Convert.ToUInt32(reader["price"].ToString()));
            }

            com.Close();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            str += listBox1.SelectedItem;
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            com.Open();

            string up = @"select price from menu where food_name=@name";
            cmd = new SqlCommand(up, com);

            SqlParameter param1 = new SqlParameter("@name", listBox1.SelectedItem);

            cmd.Parameters.Add(param1);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox7.Text = Convert.ToString(Convert.ToUInt32(textBox7.Text) - Convert.ToUInt32(reader["price"].ToString()));
            }

            com.Close();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            com.Open();

            string up = @"select price from menu where food_name=@name";
            cmd = new SqlCommand(up, com);

            SqlParameter param1 = new SqlParameter("@name", listBox1.SelectedItem);

            cmd.Parameters.Add(param1);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox7.Text = Convert.ToString(Convert.ToUInt32(textBox7.Text) - Convert.ToUInt32(reader["price"].ToString()));
            }

            com.Close();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            
           



        }
    }
}
