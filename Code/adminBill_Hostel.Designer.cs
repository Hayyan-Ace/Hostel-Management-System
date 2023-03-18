
namespace Khali_Wali2
{
    partial class adminBill_Hostel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_inPaid = new System.Windows.Forms.ComboBox();
            this.txt_inPersonID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_verifyID = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "adminHostelT‌hing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Month";
            // 
            // cbx_inPaid
            // 
            this.cbx_inPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_inPaid.FormattingEnabled = true;
            this.cbx_inPaid.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbx_inPaid.Location = new System.Drawing.Point(122, 234);
            this.cbx_inPaid.Name = "cbx_inPaid";
            this.cbx_inPaid.Size = new System.Drawing.Size(100, 24);
            this.cbx_inPaid.TabIndex = 27;
            // 
            // txt_inPersonID
            // 
            this.txt_inPersonID.Location = new System.Drawing.Point(122, 128);
            this.txt_inPersonID.Name = "txt_inPersonID";
            this.txt_inPersonID.Size = new System.Drawing.Size(100, 22);
            this.txt_inPersonID.TabIndex = 28;
            this.txt_inPersonID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_inPersonID_MouseClick);
            this.txt_inPersonID.TextChanged += new System.EventHandler(this.txt_inPersonID_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 33;
            this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // lbl_verifyID
            // 
            this.lbl_verifyID.AutoSize = true;
            this.lbl_verifyID.Location = new System.Drawing.Point(238, 131);
            this.lbl_verifyID.Name = "lbl_verifyID";
            this.lbl_verifyID.Size = new System.Drawing.Size(126, 17);
            this.lbl_verifyID.TabIndex = 35;
            this.lbl_verifyID.Text = "&Click here to Verify";
            this.lbl_verifyID.Click += new System.EventHandler(this.lbl_verifyID_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(54, 411);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(158, 60);
            this.btn_insert.TabIndex = 36;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // adminBill_Hostel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_verifyID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_inPersonID);
            this.Controls.Add(this.cbx_inPaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminBill_Hostel";
            this.Text = "adminBill_Hostel";
            this.Load += new System.EventHandler(this.adminBill_Hostel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_inPaid;
        private System.Windows.Forms.TextBox txt_inPersonID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_verifyID;
        private System.Windows.Forms.Button btn_insert;
    }
}