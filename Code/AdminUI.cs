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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();

            panel3.Height = btnRoom.Height;
            panel3.Top = btnRoom.Top;
            panel3.Left = btnRoom.Left;
            

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            panel3.Height = btnRoom.Height;
            panel3.Top = btnRoom.Top;
            panel3.Left = btnRoom.Left;

            this.pnlFormLoader.Controls.Clear();
            adminRoomForm arf = new adminRoomForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            arf.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(arf);
            arf.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            panel3.Height = btnStudent.Height;
            panel3.Top = btnStudent.Top;

            this.pnlFormLoader.Controls.Clear();
            adminPerson_Form asf = new adminPerson_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            asf.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(asf);
            asf.Show();

            
         
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            panel3.Height = btnExpense.Height;
            panel3.Top = btnExpense.Top;

            this.pnlFormLoader.Controls.Clear();
            adminExpensesForm aef = new adminExpensesForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            aef.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(aef);
            aef.Show();


        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            panel3.Height = btnVisitor.Height;
            panel3.Top = btnVisitor.Top;

            this.pnlFormLoader.Controls.Clear();
            adminVisitorForm avf = new adminVisitorForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            avf.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(avf);
            avf.Show();

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            panel3.Height = btnBills.Height;
            panel3.Top = btnBills.Top;

            this.pnlFormLoader.Controls.Clear();
            adminBill_Form abf = new adminBill_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abf.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(abf);
            abf.Show();


        }



        private void btn_Building_Click(object sender, EventArgs e)
        {
            panel3.Height = btn_Building.Height;
            panel3.Top = btn_Building.Top;

            this.pnlFormLoader.Controls.Clear();
            adminBuildingForm abf = new adminBuildingForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abf.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(abf);
            abf.Show();


        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close This Application :) ?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }




        private void btnRoom_Leave(object sender, EventArgs e)
        {
            btnRoom.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBills_Leave(object sender, EventArgs e)
        {
            btnBills.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStudent_Leave(object sender, EventArgs e)
        {
            btnStudent.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExpense_Leave(object sender, EventArgs e)
        {
            btnExpense.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnVisitor_Leave(object sender, EventArgs e)
        {
            btnVisitor.BackColor = Color.FromArgb(24, 30, 54);
        }

     
        private void btn_Building_Leave(object sender, EventArgs e)
        {
            btnVisitor.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
