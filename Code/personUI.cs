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
    public partial class personUI : Form
    {

       
        public personUI()
        {
            InitializeComponent();
            panel3.Height = btnBills.Height;
            panel3.Top = btnBills.Top;
            panel3.Left = btnBills.Left;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

       

        private void btnBills_Click(object sender, EventArgs e)
        {
            panel3.Height = btnBills.Height;
            panel3.Top = btnBills.Top;

            this.pnlFormLoader.Controls.Clear();
            personUI_Bills ph = new personUI_Bills() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ph.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(ph);
            ph.Show();



        }

        private void btnBills_Leave(object sender, EventArgs e)
        {
            btnBills.BackColor = Color.FromArgb(24, 30, 54);
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
         

            this.pnlFormLoader.Controls.Clear();
            personUI_Home ph = new personUI_Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ph.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(ph);
            ph.Show();


        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void personUI_Load(object sender, EventArgs e)
        {
            try
            {
                personID.Text = LoginPage.str_name;

                OracleConnection con = new OracleConnection();
                
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter("select * from gym where person_id = '" + personID.Text + "'", con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Open();
                OracleCommand cmd = new OracleCommand("select full_name, contact from person where person_id = '" + personID.Text + "'  ", con);
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read() || !dr.Read())
                {

                    label5.Text = dr["full_name"].ToString();
                    label7.Text = dr["contact"].ToString();
                }
            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close This Application :) ?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    

        private void label3_Click(object sender, EventArgs e)
        {

        }

     
    }
}
