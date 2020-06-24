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
    public partial class us_pay : UserControl
    {
        string str;
        SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
        SqlCommand cmd;
        public us_pay()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            com.Open();
            
            string update = @"select order_name ,status from Orders where order_id=@id";
            cmd = new SqlCommand(update, com);

            SqlParameter param = new SqlParameter("@id", textBox1.Text);
            cmd.Parameters.Add(param);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label4.Text= reader["status"].ToString();
                if (label4.Text == "Delivered      ")
                {
                    label4.Text = "Your Order has " + label4.Text;
                    pictureBox3.Hide();
                    pictureBox5.Show();
                }
                else
                {
                    label4.Text = "Your Will Prepared Soon ,Wait..";
                    pictureBox5.Hide();
                    pictureBox3.Show();
                }
            }
            label4.Show();
            com.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="")
                MessageBox.Show("Enter Your ID ,Please", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                com.Open();
                string up = @"select status from Orders where order_id=@x";
                cmd = new SqlCommand(up, com);


                SqlParameter param4 = new SqlParameter("@x", textBox2.Text);

                cmd.Parameters.Add(param4);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    str = reader["status"].ToString();

                }
                com.Close();
                if (str == "Delivered      ")
                    MessageBox.Show("Your Order aren't be canceled , It's Done ", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                {
                    DialogResult result = MessageBox.Show("Are you to cancel your order ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        com.Open();
                        string update = @"Delete from Orders where order_id=@id";
                        cmd = new SqlCommand(update, com);
                        SqlParameter param = new SqlParameter("@id", textBox2.Text);
                        cmd.Parameters.Add(param);
                        cmd.ExecuteNonQuery();
                        com.Close();
                        MessageBox.Show("Your Order are canceled ", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBox2.Text = "";
                    }
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
