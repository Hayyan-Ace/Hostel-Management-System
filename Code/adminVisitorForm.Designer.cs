
namespace Khali_Wali2
{
    partial class adminVisitorForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inPersonID = new System.Windows.Forms.TextBox();
            this.txt_inVisitorCNIC = new System.Windows.Forms.TextBox();
            this.txt_inTime = new System.Windows.Forms.TextBox();
            this.txt_inOutTime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_inVisitorRec = new System.Windows.Forms.Button();
            this.btn_searchVisitor = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "admin Visitor log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visitior CNIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "In Date/Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Person ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Out Date/Time";
            // 
            // txt_inPersonID
            // 
            this.txt_inPersonID.Location = new System.Drawing.Point(146, 123);
            this.txt_inPersonID.Name = "txt_inPersonID";
            this.txt_inPersonID.Size = new System.Drawing.Size(100, 22);
            this.txt_inPersonID.TabIndex = 5;
            // 
            // txt_inVisitorCNIC
            // 
            this.txt_inVisitorCNIC.Location = new System.Drawing.Point(146, 161);
            this.txt_inVisitorCNIC.Name = "txt_inVisitorCNIC";
            this.txt_inVisitorCNIC.Size = new System.Drawing.Size(100, 22);
            this.txt_inVisitorCNIC.TabIndex = 6;
            // 
            // txt_inTime
            // 
            this.txt_inTime.Location = new System.Drawing.Point(146, 205);
            this.txt_inTime.Name = "txt_inTime";
            this.txt_inTime.Size = new System.Drawing.Size(100, 22);
            this.txt_inTime.TabIndex = 7;
            this.txt_inTime.TextChanged += new System.EventHandler(this.txt_inTime_TextChanged);
            this.txt_inTime.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_inTime_MouseDoubleClick);
            // 
            // txt_inOutTime
            // 
            this.txt_inOutTime.Location = new System.Drawing.Point(146, 252);
            this.txt_inOutTime.Name = "txt_inOutTime";
            this.txt_inOutTime.Size = new System.Drawing.Size(100, 22);
            this.txt_inOutTime.TabIndex = 8;
            this.txt_inOutTime.TextChanged += new System.EventHandler(this.txt_outTime_TextChanged);
            this.txt_inOutTime.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(330, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_inVisitorRec
            // 
            this.btn_inVisitorRec.Location = new System.Drawing.Point(35, 339);
            this.btn_inVisitorRec.Name = "btn_inVisitorRec";
            this.btn_inVisitorRec.Size = new System.Drawing.Size(184, 66);
            this.btn_inVisitorRec.TabIndex = 10;
            this.btn_inVisitorRec.Text = "Insert";
            this.btn_inVisitorRec.UseVisualStyleBackColor = true;
            this.btn_inVisitorRec.Click += new System.EventHandler(this.btn_inVisitorRec_Click);
            // 
            // btn_searchVisitor
            // 
            this.btn_searchVisitor.Location = new System.Drawing.Point(411, 339);
            this.btn_searchVisitor.Name = "btn_searchVisitor";
            this.btn_searchVisitor.Size = new System.Drawing.Size(184, 66);
            this.btn_searchVisitor.TabIndex = 11;
            this.btn_searchVisitor.Text = "Search";
            this.btn_searchVisitor.UseVisualStyleBackColor = true;
            this.btn_searchVisitor.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(417, 422);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(161, 17);
            this.lblsearch.TabIndex = 12;
            this.lblsearch.Text = "Want to Search Visitor ?";
            this.lblsearch.Click += new System.EventHandler(this.lblsearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Want to insert into Visitor ?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // adminVisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btn_searchVisitor);
            this.Controls.Add(this.btn_inVisitorRec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_inOutTime);
            this.Controls.Add(this.txt_inTime);
            this.Controls.Add(this.txt_inVisitorCNIC);
            this.Controls.Add(this.txt_inPersonID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminVisitorForm";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_inPersonID;
        private System.Windows.Forms.TextBox txt_inVisitorCNIC;
        private System.Windows.Forms.TextBox txt_inTime;
        private System.Windows.Forms.TextBox txt_inOutTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_inVisitorRec;
        private System.Windows.Forms.Button btn_searchVisitor;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label label6;
    }
}