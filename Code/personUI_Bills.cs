using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace Khali_Wali2
{
    public partial class personUI_Bills : Form
    {
        public personUI_Bills()
        {
            InitializeComponent();
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.BackColor = Color.Black; 
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            try
            {
                label1.Text = LoginPage.str_name;
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter("select * from mess where person_id = '" + label1.Text + "'", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorrroror");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.White;
            try
            {
                label1.Text = LoginPage.str_name;
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter("select * from hostel where person_id = '" + label1.Text + "'", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorrroror");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.Black;
            try
            {
                label1.Text = LoginPage.str_name;
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                con.Open();
                OracleCommand cmd = new OracleCommand("select gym from person where person_id = '" + label1.Text + "' ", con);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read() || !dr.Read())
                {
                    string str = dr["gym"].ToString();


                    if (str == "No" || str == "")
                    {
                        MessageBox.Show("Not A Member of GYM", "Notification");
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        OracleDataAdapter adapter = new OracleDataAdapter("select * from gym where person_id = '" + label1.Text + "'", con);
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorrroror");
            }
        }
    }
}
