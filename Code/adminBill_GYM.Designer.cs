
namespace Khali_Wali2
{
    partial class adminBill_GYM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_inPersonID = new System.Windows.Forms.TextBox();
            this.lbl_verifyID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inNoDays = new System.Windows.Forms.TextBox();
            this.txt_inTotalBill = new System.Windows.Forms.TextBox();
            this.cbx_inPaid = new System.Windows.Forms.ComboBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "adminGymThing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person ID";
            // 
            // txt_inPersonID
            // 
            this.txt_inPersonID.Location = new System.Drawing.Point(164, 167);
            this.txt_inPersonID.Name = "txt_inPersonID";
            this.txt_inPersonID.Size = new System.Drawing.Size(100, 22);
            this.txt_inPersonID.TabIndex = 2;
            this.txt_inPersonID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_inPersonID_MouseClick);
            this.txt_inPersonID.TextChanged += new System.EventHandler(this.txt_inPersonID_TextChanged);
            this.txt_inPersonID.Leave += new System.EventHandler(this.txt_inPersonID_Leave);
            // 
            // lbl_verifyID
            // 
            this.lbl_verifyID.AutoSize = true;
            this.lbl_verifyID.Location = new System.Drawing.Point(311, 170);
            this.lbl_verifyID.Name = "lbl_verifyID";
            this.lbl_verifyID.Size = new System.Drawing.Size(126, 17);
            this.lbl_verifyID.TabIndex = 3;
            this.lbl_verifyID.Text = "&Click here to Verify";
            this.lbl_verifyID.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number Of Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Bill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Paid?";
            // 
            // txt_inNoDays
            // 
            this.txt_inNoDays.Location = new System.Drawing.Point(164, 213);
            this.txt_inNoDays.Name = "txt_inNoDays";
            this.txt_inNoDays.Size = new System.Drawing.Size(100, 22);
            this.txt_inNoDays.TabIndex = 7;
            // 
            // txt_inTotalBill
            // 
            this.txt_inTotalBill.Location = new System.Drawing.Point(525, 246);
            this.txt_inTotalBill.Name = "txt_inTotalBill";
            this.txt_inTotalBill.Size = new System.Drawing.Size(100, 22);
            this.txt_inTotalBill.TabIndex = 8;
            // 
            // cbx_inPaid
            // 
            this.cbx_inPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_inPaid.FormattingEnabled = true;
            this.cbx_inPaid.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbx_inPaid.Location = new System.Drawing.Point(164, 260);
            this.cbx_inPaid.Name = "cbx_inPaid";
            this.cbx_inPaid.Size = new System.Drawing.Size(100, 24);
            this.cbx_inPaid.TabIndex = 9;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(41, 445);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(158, 60);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "&Search A Record";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(453, 445);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(158, 60);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "&Insert Record of GYM";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Month";
            // 
            // adminBill_GYM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.cbx_inPaid);
            this.Controls.Add(this.txt_inTotalBill);
            this.Controls.Add(this.txt_inNoDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_verifyID);
            this.Controls.Add(this.txt_inPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminBill_GYM";
            this.Text = "adminBill_GYM";
            this.Load += new System.EventHandler(this.adminBill_GYM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_inPersonID;
        private System.Windows.Forms.Label lbl_verifyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_inNoDays;
        private System.Windows.Forms.TextBox txt_inTotalBill;
        private System.Windows.Forms.ComboBox cbx_inPaid;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}