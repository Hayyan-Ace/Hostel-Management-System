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
    public partial class adminPerson_Form : Form
    {
        
        public adminPerson_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.pnlLoader.Controls.Clear();
            adminPerson_Insert aip = new adminPerson_Insert() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            aip.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(aip);
            aip.Show();


        }

        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            this.pnlLoader.Controls.Clear();
            adminPerson_Delete adp = new adminPerson_Delete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            adp.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(adp);
            adp.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.pnlLoader.Controls.Clear();
            adminPerson_View avp = new adminPerson_View() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            avp.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(avp);
            avp.Show();
        }

        private void pnlLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
