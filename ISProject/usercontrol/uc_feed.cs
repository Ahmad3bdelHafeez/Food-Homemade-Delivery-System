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
    public partial class uc_feed : UserControl
    {
        SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
        SqlCommand cmd;
        public uc_feed()
        {
            InitializeComponent();
            //com.Open();
            //cmd = new SqlCommand("select order_name ,Feedback from Orders", com);
            //SqlDataReader reader2 = cmd.ExecuteReader();
            //DataTable tbl2 = new DataTable();
            //tbl2.Columns.Add("Order");

            //tbl2.Columns.Add("Rate");

            //DataRow row2;
            //while (reader2.Read())
            //{
            //    row2 = tbl2.NewRow();
            //    row2["Order"] = reader2["order_name"];
            //    row2["Rate"] = reader2["Feedback"];
            //    tbl2.Rows.Add(row2);
            //}
            //com.Close();
            //dataGridView1.DataSource = tbl2;
        }

        private void btnfeed_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                com.Open();
                string update = @"update Orders set feedback=@name  where order_id=@id";
                cmd = new SqlCommand(update, com);

                SqlParameter param = new SqlParameter("@id", textBox1.Text);
                cmd.Parameters.Add(param);
                SqlParameter param1;
                if (radioButton1.Checked)
                {
                    param1 = new SqlParameter("@name", "Excellant");
                    cmd.Parameters.Add(param1);
                    MessageBox.Show("Done", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (radioButton2.Checked)
                {
                    param1 = new SqlParameter("@name", "Very Good");
                    cmd.Parameters.Add(param1);
                    MessageBox.Show("Done", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else if (radioButton3.Checked)
                {
                    param1 = new SqlParameter("@name", "Good");
                    cmd.Parameters.Add(param1);
                    MessageBox.Show("Done", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else if (radioButton5.Checked)
                {
                    param1 = new SqlParameter("@name", "Normal");
                    cmd.Parameters.Add(param1);
                    MessageBox.Show("Done", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else if (radioButton4.Checked)
                {
                    param1 = new SqlParameter("@name", "Bad");
                    cmd.Parameters.Add(param1);
                    MessageBox.Show("Done", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                    MessageBox.Show("Please Select From Options", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.ExecuteNonQuery();

                textBox1.Text = "";
                com.Close();
                //com.Open();
                //cmd = new SqlCommand("select order_name ,Feedback from Orders", com);
                //SqlDataReader reader2 = cmd.ExecuteReader();
                //DataTable tbl2 = new DataTable();
                //tbl2.Columns.Add("Order");

                //tbl2.Columns.Add("Rate");

                //DataRow row2;
                //while (reader2.Read())
                //{
                //    row2 = tbl2.NewRow();
                //    row2["Order"] = reader2["order_name"];
                //    row2["Rate"] = reader2["Feedback"];
                //    tbl2.Rows.Add(row2);
                //}
                //com.Close();
                //dataGridView1.DataSource = tbl2;
            }
            else
                MessageBox.Show("Please Enter Your Order ID","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void uc_feed_Load(object sender, EventArgs e)
        {

        }
    }
}
