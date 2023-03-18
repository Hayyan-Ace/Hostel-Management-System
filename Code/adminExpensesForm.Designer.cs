
namespace Khali_Wali2
{
    partial class adminExpensesForm
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
            this.txt_inB_ID = new System.Windows.Forms.TextBox();
            this.txt_inExplanation = new System.Windows.Forms.TextBox();
            this.txt_inAmount = new System.Windows.Forms.TextBox();
            this.cbx_inCatagoery = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_insertExpense = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_inDate = new System.Windows.Forms.TextBox();
            this.btn_SearchExpense = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "admin Expenses Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Building ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Catagoery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expalanation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_inB_ID
            // 
            this.txt_inB_ID.Location = new System.Drawing.Point(174, 182);
            this.txt_inB_ID.Name = "txt_inB_ID";
            this.txt_inB_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_inB_ID.TabIndex = 5;
            // 
            // txt_inExplanation
            // 
            this.txt_inExplanation.Location = new System.Drawing.Point(174, 261);
            this.txt_inExplanation.Name = "txt_inExplanation";
            this.txt_inExplanation.Size = new System.Drawing.Size(100, 22);
            this.txt_inExplanation.TabIndex = 6;
            // 
            // txt_inAmount
            // 
            this.txt_inAmount.Location = new System.Drawing.Point(174, 300);
            this.txt_inAmount.Name = "txt_inAmount";
            this.txt_inAmount.Size = new System.Drawing.Size(100, 22);
            this.txt_inAmount.TabIndex = 7;
            // 
            // cbx_inCatagoery
            // 
            this.cbx_inCatagoery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_inCatagoery.FormattingEnabled = true;
            this.cbx_inCatagoery.Items.AddRange(new object[] {
            "Maintenance",
            "Medical",
            "Labour",
            "Equipment",
            "Mess"});
            this.cbx_inCatagoery.Location = new System.Drawing.Point(174, 219);
            this.cbx_inCatagoery.Name = "cbx_inCatagoery";
            this.cbx_inCatagoery.Size = new System.Drawing.Size(100, 24);
            this.cbx_inCatagoery.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_insertExpense
            // 
            this.btn_insertExpense.Location = new System.Drawing.Point(62, 416);
            this.btn_insertExpense.Name = "btn_insertExpense";
            this.btn_insertExpense.Size = new System.Drawing.Size(172, 63);
            this.btn_insertExpense.TabIndex = 10;
            this.btn_insertExpense.Text = "Insert";
            this.btn_insertExpense.UseVisualStyleBackColor = true;
            this.btn_insertExpense.Click += new System.EventHandler(this.btn_insertExpense_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "want to search particular record?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date";
            // 
            // txt_inDate
            // 
            this.txt_inDate.Location = new System.Drawing.Point(174, 341);
            this.txt_inDate.Name = "txt_inDate";
            this.txt_inDate.Size = new System.Drawing.Size(100, 22);
            this.txt_inDate.TabIndex = 13;
            this.txt_inDate.TextChanged += new System.EventHandler(this.txt_inDate_TextChanged);
            // 
            // btn_SearchExpense
            // 
            this.btn_SearchExpense.Location = new System.Drawing.Point(507, 416);
            this.btn_SearchExpense.Name = "btn_SearchExpense";
            this.btn_SearchExpense.Size = new System.Drawing.Size(172, 63);
            this.btn_SearchExpense.TabIndex = 14;
            this.btn_SearchExpense.Text = "Search";
            this.btn_SearchExpense.UseVisualStyleBackColor = true;
            this.btn_SearchExpense.Click += new System.EventHandler(this.btn_SearchExpense_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "want to insert  a record ?";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // adminExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_SearchExpense);
            this.Controls.Add(this.txt_inDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_insertExpense);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_inCatagoery);
            this.Controls.Add(this.txt_inAmount);
            this.Controls.Add(this.txt_inExplanation);
            this.Controls.Add(this.txt_inB_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminExpensesForm";
            this.Text = "adminExpensesForm";
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
        private System.Windows.Forms.TextBox txt_inB_ID;
        private System.Windows.Forms.TextBox txt_inExplanation;
        private System.Windows.Forms.TextBox txt_inAmount;
        private System.Windows.Forms.ComboBox cbx_inCatagoery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insertExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_inDate;
        private System.Windows.Forms.Button btn_SearchExpense;
        private System.Windows.Forms.Label label8;
    }
}