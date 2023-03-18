using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Khali_Wali2
{
    public partial class adminBill_Form : Form
    {
        public adminBill_Form()
        {
            InitializeComponent();
        }

        private void btn_gym_Click(object sender, EventArgs e)
        {
            this.pnlLoader.Controls.Clear();
            adminBill_GYM abg = new adminBill_GYM() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abg.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(abg);
            abg.Show();

        }

        private void btn_mess_Click(object sender, EventArgs e)
        {
            this.pnlLoader.Controls.Clear();
            adminBill_Mess abm = new adminBill_Mess() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abm.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(abm);
            abm.Show();
        }

        private void btn_hostel_Click(object sender, EventArgs e)
        {
            this.pnlLoader.Controls.Clear();
            adminBill_Hostel abh = new adminBill_Hostel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abh.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(abh);
            abh.Show();
        }
    }
}
