using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Oracle.ManagedDataAccess.Client;

namespace Khali_Wali2
{
   
    public partial class LoginPage : Form
    {
        public static string str_name;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            textBox1.BackColor = SystemColors.Control;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totheadmin_Click(object sender, EventArgs e)
        {
       
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminUI adminUIForm = new AdminUI();
                adminUIForm.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                    DataTable dt = new DataTable();
                    con.Open();
                    OracleCommand cmd = new OracleCommand("select p_password from person where person_id = '" + textBox1.Text + "'  ", con);
                    OracleDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() || !dr.Read())
                    {

                        string str = dr["p_password"].ToString();
                        int currcap = int.Parse(str);

                        if (str == textBox2.Text)
                        {
                            personUI person_UI = new personUI();
                            str_name = textBox1.Text;
                            person_UI.Show();
                            this.Hide();



                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }


            }
           // else if ()
            
            
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
