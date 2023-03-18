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
    public partial class adminBill_GYM : Form
    {
        public adminBill_GYM()
        {
           
            InitializeComponent();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            txt_inNoDays.Hide();
            txt_inTotalBill.Hide();
            cbx_inPaid.Hide();
            label7.Hide();
            btn_search.Hide();
            label8.Hide();
            textBox1.Hide();
        }

     
        private void adminBill_GYM_Load(object sender, EventArgs e)
        {

        }

        private void txt_inPersonID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_inPersonID_Leave(object sender, EventArgs e)
        {

         

        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                con.Open();
                OracleCommand cmd = new OracleCommand("select gym from person where person_id = '" + txt_inPersonID.Text + "' ", con);
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
                        label3.Show();
                        label4.Show();
                        label5.Show();

                        txt_inNoDays.Show();
                        txt_inTotalBill.Show();
                        cbx_inPaid.Show();

                        btn_insert.Show();
                        label8.Show();
                        textBox1.Show();



                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Does not Exist in DataBase", "Error");
            
            }

            }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
            DataTable dt = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter("select * from gym where person_id = '"+txt_inPersonID.Text+"'", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            txt_inNoDays.Hide();
            txt_inTotalBill.Hide();
            cbx_inPaid.Hide();
            btn_insert.Hide();
            label6.Hide();
            label7.Show();
            btn_search.Show();
            label8.Hide();
            textBox1.Hide();
            lbl_verifyID.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label6.Show();
            label7.Hide();
            btn_insert.Show();
            btn_search.Hide();
            lbl_verifyID.Show();


        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                string days = txt_inNoDays.Text;

                int int_days = int.Parse(days);
                int_days = int_days * 100;
                txt_inTotalBill.Text = int_days.ToString();





                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                string query = "insert into gym values('" + txt_inPersonID.Text + "' ," + txt_inNoDays.Text + "," + txt_inTotalBill.Text + ", '" + cbx_inPaid.Text + "' , '"+textBox1.Text+"')";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                oracleDataAdapter.Fill(dt);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from gym", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                MessageBox.Show("Person Inserted Successfull", "Notification");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            textBox1.Text = System.DateTime.Now.Month.ToString();

            if (textBox1.Text=="1")
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

        private void txt_inPersonID_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            txt_inNoDays.Hide();
            txt_inTotalBill.Hide();
            cbx_inPaid.Hide();
            label7.Hide();
            btn_search.Hide();
            label8.Hide();
            textBox1.Hide();
        }
    }
}
