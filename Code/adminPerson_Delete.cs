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
    public partial class adminPerson_Delete : Form
    {
        public adminPerson_Delete()
        {
            InitializeComponent();
        }

        private void prsnInsertHeader_Click(object sender, EventArgs e)
        {

        }

        private void adminDeletePerson_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                string query = " delete from person where person_id = :txt_deleteID ";
                DataTable dt = new DataTable();
               
                OracleCommand cmd = new OracleCommand(query, con);
                con.Open();
                cmd.Parameters.Add("txt_deleteID ", txt_deleteID.Text);
                cmd.ExecuteNonQuery();
                

                OracleDataAdapter adapter = new OracleDataAdapter("select * from person", con);
                adapter.Fill(dt);
                personGridView.DataSource = dt;


                MessageBox.Show("Person DELETED Successfull", "Notification");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void txt_inID_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdRollNumber_Click(object sender, EventArgs e)
        {
            
        }
    }
}
