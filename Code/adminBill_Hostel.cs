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
    public partial class adminBill_Hostel : Form
    {
        public adminBill_Hostel()
        {
            InitializeComponent();
            label3.Hide();
            label4.Hide();


            textBox1.Hide();
            cbx_inPaid.Hide();
        }

        private void adminBill_Hostel_Load(object sender, EventArgs e)
        {

        }

        private void lbl_verifyID_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                con.Open();
                OracleCommand cmd = new OracleCommand("select person_id from person where person_id = '" + txt_inPersonID.Text + "' ", con);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read() || !dr.Read() )
                {
                    string str = dr["person_id"].ToString();
                    label1.Text = str;
                    
                    if (str != txt_inPersonID.Text )
                    {
                        MessageBox.Show("Not in Hostel Data Base", "Notification");
                    }
                    else
                    {
                        label3.Show();
                        label4.Show();
                  
                        cbx_inPaid.Show();

                        textBox1.Show();

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = System.DateTime.Now.Month.ToString();

            if (textBox1.Text == "1")
            {
                textBox1.Text = "January";
            }
            else if (textBox1.Text == "2")
            {
                textBox1.Text = "February";
            }
            else if (textBox1.Text == "3")
            {
                textBox1.Text = "March";
            }
            else if (textBox1.Text == "4")
            {
                textBox1.Text = "April";
            }
            else if (textBox1.Text == "5")
            {
                textBox1.Text = "May";
            }
            else if (textBox1.Text == "6")
            {
                textBox1.Text = "June";
            }
            else if (textBox1.Text == "7")
            {
                textBox1.Text = "July";
            }
            else if (textBox1.Text == "8")
            {
                textBox1.Text = "August";
            }
            else if (textBox1.Text == "9")
            {
                textBox1.Text = "September";
            }
            else if (textBox1.Text == "10")
            {
                textBox1.Text = "October";
            }
            else if (textBox1.Text == "11")
            {
                textBox1.Text = "November";
            }
            else if (textBox1.Text == "12")
            {
                textBox1.Text = "December";
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                string query = "insert into hostel(person_id, paid, month) values('" + txt_inPersonID.Text + "' ,'" + textBox1.Text + "','" + cbx_inPaid.Text + "')";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                oracleDataAdapter.Fill(dt);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from hostel", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                MessageBox.Show("Hostel fee Successfull", "Notification");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void txt_inPersonID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_inPersonID_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Hide();
            label4.Hide();


            textBox1.Hide();
            cbx_inPaid.Hide();
        }
    }
}
