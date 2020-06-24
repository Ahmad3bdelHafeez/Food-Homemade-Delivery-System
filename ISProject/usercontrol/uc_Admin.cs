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
    public partial class uc_Admin : UserControl
    {
        SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
        SqlCommand cmd;
        //SqlDataAdapter d1,d2,d3;
        //DataTable dd = new DataTable();

        public uc_Admin()
        {
            
            InitializeComponent();

            com.Open();
            cmd = new SqlCommand("select order_id,order_name,price,status from Orders", com);
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

            //cmd1 = new SqlCommand("DisplayCookers", com);
            //cmd1.CommandType = CommandType.StoredProcedure;
            //d1 = new SqlDataAdapter(cmd1);
            //dd.Clear();

            //d1.Fill(dd);
            //this.dataGridView7.DataSource = dd;

            //cmd2 = new SqlCommand("DisplayDrivers", com);
            //cmd2.CommandType = CommandType.StoredProcedure;
            //d2 = new SqlDataAdapter(cmd2);
            //dd.Clear();
            //d2.Fill(dd);
            //this.dataGridView8.DataSource = dd;


            //cmd3 = new SqlCommand("DisplayFQC", com);
            //cmd3.CommandType = CommandType.StoredProcedure;
            //d3 = new SqlDataAdapter(cmd3);
            //dd.Clear();
            //d3.Fill(dd);
            //this.dataGridView9.DataSource = dd;

            com.Open();
            cmd = new SqlCommand("select cooker_ID,age,phone,name,address,gender,password from Cookers", com);
            SqlDataReader reader5 = cmd.ExecuteReader();
            DataTable tbl5 = new DataTable();
            tbl5.Columns.Add("ID");
            tbl5.Columns.Add("Name");
            tbl5.Columns.Add("Password");
            tbl5.Columns.Add("Age");
            tbl5.Columns.Add("Phone");
            
            tbl5.Columns.Add("Adress");
            tbl5.Columns.Add("Sex");
            DataRow row5;
            while (reader5.Read())
            {
                row5 = tbl5.NewRow();
                row5["ID"] = reader5["cooker_ID"];
                row5["Name"] = reader5["name"];
                row5["Password"] = reader5["password"];
                row5["Age"] = reader5["age"];
                row5["Phone"] = reader5["phone"];
                
                row5["Adress"] = reader5["address"];
                row5["Sex"] = reader5["gender"];
                tbl5.Rows.Add(row5);
            }
            com.Close();
            dataGridView7.DataSource = tbl5;

            //////////////////////////////////////////////
            
            com.Open();
            cmd = new SqlCommand("select driver_ID,phone,name,address,gender,civil_ID,password from Drivers", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("ID");

            tbl1.Columns.Add("Phone");
            tbl1.Columns.Add("Name");
            tbl1.Columns.Add("Password");
            tbl1.Columns.Add("Adress");
            tbl1.Columns.Add("Sex");
            tbl1.Columns.Add("Civil ID");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["ID"] = reader1["driver_ID"];

                row1["Phone"] = reader1["phone"];
                row1["Name"] = reader1["name"];
                row1["Password"] = reader1["password"];
                row1["Adress"] = reader1["address"];

                row1["Sex"] = reader1["gender"];
                row1["Civil ID"] = reader1["civil_ID"];
                tbl1.Rows.Add(row1);
            }
            com.Close();
            dataGridView8.DataSource = tbl1;


            //////////////////////////////////////////////
            
            com.Open();
            cmd = new SqlCommand("select food_checker_ID,phone,name,address,gender,age,password from [Food quality checkers]", com);
            SqlDataReader reader2 = cmd.ExecuteReader();
            DataTable tbl2 = new DataTable();
            tbl2.Columns.Add("ID");

            tbl2.Columns.Add("Phone");
            tbl2.Columns.Add("Name");
            tbl2.Columns.Add("Password");
            tbl2.Columns.Add("Adress");
            tbl2.Columns.Add("Sex");
            tbl2.Columns.Add("Age");
            DataRow row2;
            while (reader2.Read())
            {
                row2 = tbl2.NewRow();
                row2["ID"] = reader2["food_checker_ID"];

                row2["Phone"] = reader2["phone"];
                row2["Name"] = reader2["name"];
                row2["Password"] = reader2["password"];
                row2["Adress"] = reader2["address"];

                row2["Sex"] = reader2["gender"];
                row2["Age"] = reader2["age"];
                tbl2.Rows.Add(row2);
            }
            com.Close();
            dataGridView9.DataSource = tbl2;
        }

        private void uc_Admin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand("insertCooker", com);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter[] param = new SqlParameter[5];
            //param[0] = new SqlParameter("@name",SqlDbType.VarChar, 50);
            //param[0].Value = textBox1.Text;

            //param[1] = new SqlParameter("@address", SqlDbType.VarChar, 50);
            //param[1].Value = textBox3.Text;

            //param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            //param[2].Value = textBox2.Text;

            //param[3] = new SqlParameter("@gender", SqlDbType.VarChar, 50);
            //param[3].Value = comboBox1.Text;

            //param[4] = new SqlParameter("@age", SqlDbType.VarChar, 50);
            //param[4].Value = textBox4.Text;

            //textBox4.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox1.Text = "";
            //comboBox1.Text = "";
            //MessageBox.Show("Done", "Add", MessageBoxButtons.OK, MessageBoxIcon.None);
            //pictureBox1.Show();

            if(textBox4.Text==""|| textBox2.Text == "" || textBox3.Text == "" || textBox13.Text == "" || textBox1.Text == ""||comboBox1.Text == "")
                MessageBox.Show("Fill Data Please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
            else
            {
                SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
                SqlCommand cm;
                try
                {

                    cm = new SqlCommand("insert into Cookers(age,phone,name,address,gender,password)values(" + textBox4.Text + ",'" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox13.Text + "')", com);
                    com.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Done", "Add", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textBox4.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox1.Text = "";
                    textBox13.Text = "";
                    comboBox1.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error accured " + ex, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    com.Close();
                }
            }
            
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
            SqlCommand cm;
            try
            {

                cm = new SqlCommand("delete from Cookers where cooker_ID='"+ textBox8.Text+"'", com);
                com.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Done", "Delete Cooker", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBox8.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An Error accured " + ex, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                com.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            //cmd = new SqlCommand("InsertDriver", com);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter[] param = new SqlParameter[5];
            //param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            //param[0].Value = textBox8.Text;

            //param[1] = new SqlParameter("@address", SqlDbType.VarChar, 50);
            //param[1].Value = textBox6.Text;

            //param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            //param[2].Value = textBox7.Text;

            //param[3] = new SqlParameter("@gender", SqlDbType.VarChar, 50);
            //param[3].Value = comboBox2.Text;

            //param[4] = new SqlParameter("@civil_ID", SqlDbType.VarChar, 50);
            //param[4].Value = textBox9.Text;

            //textBox8.Text = "";
            //textBox6.Text = "";
            //textBox7.Text = "";
            //textBox9.Text = "";
            //comboBox2.Text = "";
            //MessageBox.Show("Done", "Add", MessageBoxButtons.OK, MessageBoxIcon.None);


            if(textBox7.Text == ""||
            textBox8.Text ==""||
            textBox6.Text == ""||
            textBox9.Text == ""||
            comboBox2.Text == ""||
            textBox14.Text == "")
                MessageBox.Show("Fill Data Please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
            else
            {
                SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
                SqlCommand cm;
                try
                {

                    cm = new SqlCommand("insert into Drivers(phone,name,address,gender,civil_ID,password)values(" + textBox7.Text + ",'" + textBox8.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "'," + textBox9.Text + ",'" + textBox14.Text + "')", com);
                    com.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Done", "Add", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox6.Text = "";
                    textBox9.Text = "";
                    textBox14.Text = "";
                    comboBox2.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error accured " + ex, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    com.Close();
                }
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
            SqlCommand cm;
            try
            {

                cm = new SqlCommand("insert into [Food quality checkers](phone,name,address,gender,age)values(" + textBox11.Text + ",'" + textBox12.Text + "','" + textBox10.Text + "','" + comboBox3.Text + "'," + textBox5.Text + ")", com);
                com.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Done", "Add", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBox5.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox10.Text = "";
                comboBox3.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An Error accured " + ex, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                com.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            com.Open();
            cmd = new SqlCommand("select cooker_ID,age,phone,name,address,gender from Cookers", com);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID");
            tbl.Columns.Add("Age");
            tbl.Columns.Add("Phone");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Adress");
            tbl.Columns.Add("Sex");
            DataRow row;
            while (reader.Read())
            {
                row = tbl.NewRow();
                row["ID"] = reader["cooker_ID"];
                row["Age"] = reader["age"];
                row["Phone"] = reader["phone"];
                row["Name"] = reader["name"];
                row["Adress"] = reader["address"];
                row["Sex"] = reader["gender"];
                tbl.Rows.Add(row);
            }
            com.Close();
            dataGridView7.DataSource = tbl;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            com.Open();
            cmd = new SqlCommand("select cooker_ID,age,phone,name,address,gender,password from Cookers", com);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Password");
            tbl.Columns.Add("Age");
            tbl.Columns.Add("Phone");
            
            tbl.Columns.Add("Adress");
            tbl.Columns.Add("Sex");
            DataRow row;
            while (reader.Read())
            {
                row = tbl.NewRow();
                row["ID"] = reader["cooker_ID"];
                row["Name"] = reader["name"];
                row["Password"] = reader["password"];
                row["Age"] = reader["age"];
                row["Phone"] = reader["phone"];
                
                row["Adress"] = reader["address"];
                row["Sex"] = reader["gender"];
                tbl.Rows.Add(row);
            }
            com.Close();
            dataGridView7.DataSource = tbl;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(textBox5.Text == ""||
            textBox11.Text == ""||
            textBox12.Text == ""||
            textBox10.Text == ""||
            textBox15.Text == "" ||
            comboBox3.Text == "")
                MessageBox.Show("Fill Data Please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
            else
            {
                SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
                SqlCommand cm;
                try
                {

                    cm = new SqlCommand("insert into [Food quality checkers](phone,name,address,gender,age,password)values(" + textBox11.Text + ",'" + textBox12.Text + "','" + textBox10.Text + "','" + comboBox3.Text + "'," + textBox5.Text + ",'" + textBox15.Text + "')", com);
                    com.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Done", "Add", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textBox5.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox10.Text = "";
                    textBox15.Text = "";
                    comboBox3.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error accured " + ex, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    com.Close();
                }
            }
            
          


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
           com.Open();
            cmd = new SqlCommand("select driver_ID,phone,name,address,gender,civil_ID,password from Drivers", com);
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable tbl1 = new DataTable();
            tbl1.Columns.Add("ID");

            tbl1.Columns.Add("Phone");
            tbl1.Columns.Add("Name");
            tbl1.Columns.Add("Password");
            tbl1.Columns.Add("Adress");
            tbl1.Columns.Add("Sex");
            tbl1.Columns.Add("Civil ID");
            DataRow row1;
            while (reader1.Read())
            {
                row1 = tbl1.NewRow();
                row1["ID"] = reader1["driver_ID"];

                row1["Phone"] = reader1["phone"];
                row1["Name"] = reader1["name"];
                row1["Password"] = reader1["password"];
                row1["Adress"] = reader1["address"];

                row1["Sex"] = reader1["gender"];
                row1["Civil ID"] = reader1["civil_ID"];
                tbl1.Rows.Add(row1);
            }
            com.Close();
            dataGridView8.DataSource = tbl1;
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            com.Open();
            cmd = new SqlCommand("select food_checker_ID,phone,name,address,gender,age,password from [Food quality checkers]", com);
            SqlDataReader reader2 = cmd.ExecuteReader();
            DataTable tbl2 = new DataTable();
            tbl2.Columns.Add("ID");

            tbl2.Columns.Add("Phone");
            tbl2.Columns.Add("Name");
            tbl2.Columns.Add("Password");
            tbl2.Columns.Add("Adress");
            tbl2.Columns.Add("Sex");
            tbl2.Columns.Add("Age");
            DataRow row2;
            while (reader2.Read())
            {
                row2 = tbl2.NewRow();
                row2["ID"] = reader2["food_checker_ID"];

                row2["Phone"] = reader2["phone"];
                row2["Name"] = reader2["name"];
                row2["Password"] = reader2["password"];
                row2["Adress"] = reader2["address"];

                row2["Sex"] = reader2["gender"];
                row2["Age"] = reader2["age"];
                tbl2.Rows.Add(row2);
            }
            com.Close();
            dataGridView9.DataSource = tbl2;
        }
    }
    
}
