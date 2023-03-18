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
    public partial class personUI_Home : Form
    {
        public personUI_Home()
        {
            InitializeComponent();
        }

        private void personUI_Home_Load(object sender, EventArgs e)
        {
            try
            {
                personID.Text = LoginPage.str_name;

                OracleConnection con = new OracleConnection();

                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter("select * from gym where person_id = '" + personID.Text + "'", con);
                adapter.Fill(dt);
                con.Open();
                OracleCommand cmd = new OracleCommand("select * from person where person_id = '" + personID.Text + "'  ", con);
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read() || !dr.Read())
                {

                    label5.Text = dr["full_name"].ToString();
                    label7.Text = dr["contact"].ToString();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
    }
}
