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
    public partial class adminExpensesForm : Form
    {
        public adminExpensesForm()
        {
            InitializeComponent();
            label8.Hide();
            btn_SearchExpense.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_insertExpense_Click(object sender, EventArgs e)
        {

            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                string query = "insert into Expense values('" + txt_inB_ID.Text + "' ,'" + cbx_inCatagoery.Text + "','" + txt_inExplanation.Text + "', " + txt_inAmount.Text + " , '"+txt_inDate.Text+"')";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                oracleDataAdapter.Fill(dt);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from expense", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void txt_inDate_TextChanged(object sender, EventArgs e)
        {
            txt_inDate.Text = System.DateTime.Now.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txt_inAmount.Hide();
            txt_inDate.Hide();
            txt_inExplanation.Hide();
            cbx_inCatagoery.Hide();

            btn_insertExpense.Hide();
            btn_SearchExpense.Show();

            label8.Show();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label7.Hide();

            label6.Hide();
            label8.Show();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            txt_inAmount.Show();
            txt_inDate.Show();
            txt_inExplanation.Show();
            cbx_inCatagoery.Show();

            label3.Show();
            label4.Show();
            label5.Show();
            label7.Show();


            btn_insertExpense.Show();
            btn_SearchExpense.Hide();
            label8.Hide();
            label6.Show();

        }

        private void btn_SearchExpense_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                OracleDataAdapter adapter = new OracleDataAdapter("select * from visitor where b_id = '" + txt_inB_ID + "' ", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }

        }
    }
}
