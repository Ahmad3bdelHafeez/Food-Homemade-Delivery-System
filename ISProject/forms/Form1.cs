using ISProject.usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISProject
{
    public partial class Form1 : Form
    {
        SqlConnection com = new SqlConnection("Data Source=DESKTOP-581SC5E\\SQLEXPRESS;Initial Catalog=IS project;Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        
        int panelwidth;
        bool iscollapse;
        public Form1()
        {
            InitializeComponent();
            timertime.Start();
            uc_home hh = new uc_home();
            addcontroltopanel(hh);
            panelwidth = panelleft.Width;
            iscollapse = false;

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            movesidepanel(btnhome);
            uc_home hh = new uc_home();
            addcontroltopanel(hh);
            label4.Text = "Home";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollapse)
            {
                panelleft.Width = panelleft.Width + 50;
                if (panelleft.Width >= panelwidth)
                {
                    pictureBox3.Hide();
                    timer1.Stop();
                    iscollapse = false;
                    this.Refresh();
                    label9.Show();

                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 50;
                if (panelleft.Width <= 64)
                {
                    label9.Hide();
                    timer1.Stop();
                    iscollapse = true;
                    this.Refresh();
                    pictureBox3.Show();
                    
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void movesidepanel(Control btn)
        {
            SidePanel.Top = btn.Top;
            SidePanel.Height = btn.Height;
        }

        private void btnoffers_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            movesidepanel(btnoffers);
            uc_offers ff = new uc_offers();
            addcontroltopanel(ff);
            label4.Text = "Offers";
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            movesidepanel(btnmenu);
            uc_menu ff = new uc_menu();
            addcontroltopanel(ff);
            label4.Text = "Menu";
        }

        private void btndelv_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            movesidepanel(btndelv);
            uc_delivery ff = new uc_delivery();
            addcontroltopanel(ff);
            label4.Text = "Delivery";
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            movesidepanel(btnpay);
            us_pay h = new us_pay();
            addcontroltopanel(h);
            label4.Text = "Driver Payment";
        }

        private void btnfeed_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            movesidepanel(btnfeed);
            uc_feed h = new uc_feed();
            addcontroltopanel(h);
            label4.Text = "Feedback";
        }
        

        private void timertime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labeltimer.Text = dt.ToString("HH:MM:ss");
        }
        private void addcontroltopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelcontrol.Controls.Clear();
           panelcontrol.Controls.Add(c);
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            //SidePanel.Show();
            //movesidepanel(btnabout);
            //uc_feed h = new uc_feed();
            //addcontroltopanel(h);
            //label4.Text = "About Us";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        bool x = false;
        bool y = false;
        bool z = false;
        bool d = false;
        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Please Fill all Data!");
            }
            else if (comboBox1.Text == "Admin")
            {
                com.Open();
                SqlCommand cmo = new SqlCommand("select * from Admin");
                cmo.Connection = com;
                SqlDataReader rd = cmo.ExecuteReader();
                while (rd.Read())
                {

                    if (rd[3].ToString() == textBox1.Text && rd[6].ToString() == textBox2.Text)
                    {
                        x = true;
                        break;
                    }
                }
                if (x == true)
                {
                    SidePanel.Hide();
                    uc_Admin h = new uc_Admin();
                    addcontroltopanel(h);
                    label4.Text = "Rule: Admin";
                }

                com.Close();
            }

            else if (comboBox1.Text == "Cooker")
            {
                com.Open();
                SqlCommand cmo1 = new SqlCommand("select * from Cookers");
                cmo1.Connection = com;
                SqlDataReader rd1 = cmo1.ExecuteReader();
                while (rd1.Read())
                {

                    if (rd1[3].ToString() == textBox1.Text && rd1[8].ToString() == textBox2.Text)
                    {
                        z = true;
                        break;
                    }
                }
                if (z == true)
                {
                    SidePanel.Hide();
                    uc_Cooker h = new uc_Cooker();
                    addcontroltopanel(h);
                    label4.Text = "Rule: Cooker";
                }

                com.Close();
            }
            else if (comboBox1.Text == "Driver")
            {

                com.Open();
                SqlCommand cmo2 = new SqlCommand("select * from Drivers");
                cmo2.Connection = com;
                SqlDataReader rd2 = cmo2.ExecuteReader();
                while (rd2.Read())
                {

                    if (rd2[2].ToString() == textBox1.Text && rd2[8].ToString() == textBox2.Text)
                    {
                        y = true;
                        break;
                    }
                }
                if (y == true)
                {
                    SidePanel.Hide();
                    uc_driver h = new uc_driver();
                    addcontroltopanel(h);
                    label4.Text = "Rule: Driver";
                }

                com.Close();
            }
            else if (comboBox1.Text == "Food Quality Checker")
            {
                com.Open();
                SqlCommand cmo3 = new SqlCommand("select * from [Food quality checkers]");
                cmo3.Connection = com;
                SqlDataReader rd3 = cmo3.ExecuteReader();
                while (rd3.Read())
                {

                    if (rd3[1].ToString() == textBox1.Text && rd3[7].ToString() == textBox2.Text)
                    {
                        d = true;
                        break;
                    }
                }
                if (d == true)
                {
                    SidePanel.Hide();
                    uc_FQC h = new uc_FQC();
                    addcontroltopanel(h);
                    label4.Text = "Rule: Food Quality Checker";
                }

                com.Close();

            }
            else
                MessageBox.Show("You entered Thing Incorrect!!");
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WWW.Facebook.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WWW.Twitter.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WWW.instagram.com");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            movesidepanel(button7);
            uc_about h = new uc_about();
            addcontroltopanel(h);
            label4.Text = "About Us";
        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelcontrol_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
