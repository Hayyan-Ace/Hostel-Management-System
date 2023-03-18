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
    public partial class adminPerson_View : Form
    {
        public adminPerson_View()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();
                OracleDataAdapter adp = new OracleDataAdapter("select *  from person", con);
                adp.Fill(dt);
                personGridView.DataSource = dt;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void personGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
