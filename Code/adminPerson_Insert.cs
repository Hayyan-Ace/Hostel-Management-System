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
    public partial class adminPerson_Insert : Form
    {
        public adminPerson_Insert()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stdInsertHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                string query = "insert into person values('" + txt_inID.Text + "' ,'" + txt_inFullName.Text + "'," + txt_inContact.Text + ", '" + txt_inAddress.Text + "','" + txt_inCNIC.Text + "','" + txt_inPassword.Text + "','" + txt_inGender.Text + "','" + txt_inPosition.Text + "' , '"+cbx_inGymBool.Text+"')";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                oracleDataAdapter.Fill(dt);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from person", con);
                adapter.Fill(dt);
                personGridView.DataSource = dt;


                MessageBox.Show("Person Inserted Successfull", "Notification");

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_inGender.Text = comboBox1.Text;
        }

        private void txt_inGender_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
