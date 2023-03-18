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
    public partial class adminBuildingForm : Form
    {
        public adminBuildingForm()
        {
            InitializeComponent();
            label5.Hide();
            btn_deleteBuilding.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
         
            label3.Hide();
            label4.Hide();
           
            label6.Hide();

            txt_inName.Hide();
            txt_inNO_Rooms.Hide();


            btn_InsertBuilding.Hide();
            btn_deleteBuilding.Show();

            label5.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
            label3.Show();
            label4.Show();

            txt_inName.Show();
            txt_inNO_Rooms.Show();

            label5.Hide();

            label6.Show();

            btn_deleteBuilding.Hide();
            btn_InsertBuilding.Show();

        }

        private void btn_InsertBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                string query = "insert into building values('" + txt_inB_ID.Text + "' ,'" + txt_inName.Text + "'," + txt_inNO_Rooms.Text + ")";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                oracleDataAdapter.Fill(dt);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from building", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Person Inserted Successfull", "Notification");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btn_deleteBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                string query = " delete from building where b_id= :txt_inB_ID ";
                DataTable dt = new DataTable();

                OracleCommand cmd = new OracleCommand(query, con);
                con.Open();
                cmd.Parameters.Add("txt_inB_ID ", txt_inB_ID.Text);
                cmd.ExecuteNonQuery();


                OracleDataAdapter adapter = new OracleDataAdapter("select * from building", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                MessageBox.Show("Building go PUFF ", "Notification");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
            DataTable dt = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter("select * from building", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
