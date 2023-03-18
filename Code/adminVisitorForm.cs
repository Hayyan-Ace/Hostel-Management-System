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
    public partial class adminVisitorForm : Form
    {
        public adminVisitorForm()
        {
            InitializeComponent();
            btn_searchVisitor.Hide();
            label6.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_inTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_inTime_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_inTime.Text = System.DateTime.Now.ToString();

        }
        private void txt_outTime_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void textBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_inOutTime.Text = System.DateTime.Now.ToString();
        }

        private void btn_inVisitorRec_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                string query = "insert into visitor values('" + txt_inPersonID.Text + "' ,'" + txt_inVisitorCNIC.Text + "','" + txt_inTime.Text + "', '" + txt_inOutTime.Text + "')";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                oracleDataAdapter.Fill(dt);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from visitor", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Person Inserted Successfull", "Notification");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                OracleDataAdapter adapter = new OracleDataAdapter("select * from visitor where person_id = '" + txt_inPersonID.Text + "'", con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void lblsearch_Click(object sender, EventArgs e)
        {
            txt_inOutTime.Hide();
            txt_inTime.Hide();
            txt_inVisitorCNIC.Hide();
            label2.Hide();
            label3.Hide();
            label5.Hide();
            btn_inVisitorRec.Hide();
            btn_searchVisitor.Show();
            lblsearch.Hide();
            label6.Show();


        }

        private void label6_Click(object sender, EventArgs e)
        {
            txt_inOutTime.Show();
            txt_inTime.Show();
            txt_inVisitorCNIC.Show();
            label2.Show();
            label3.Show();
            label5.Show();
            btn_searchVisitor.Hide();
            btn_inVisitorRec.Show();
            lblsearch.Show();
            label6.Hide();
        }
    }
}
