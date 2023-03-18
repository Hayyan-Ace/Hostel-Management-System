
namespace Khali_Wali2
{
    partial class adminPerson_Delete
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
            this.personGridView = new System.Windows.Forms.DataGridView();
            this.prsnDeleteHeader = new System.Windows.Forms.Label();
            this.txt_deleteID = new System.Windows.Forms.TextBox();
            this.stdRollNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personGridView
            // 
            this.personGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personGridView.GridColor = System.Drawing.SystemColors.Highlight;
            this.personGridView.Location = new System.Drawing.Point(290, 89);
            this.personGridView.Name = "personGridView";
            this.personGridView.RowHeadersWidth = 51;
            this.personGridView.RowTemplate.Height = 24;
            this.personGridView.Size = new System.Drawing.Size(462, 322);
            this.personGridView.TabIndex = 38;
            // 
            // prsnDeleteHeader
            // 
            this.prsnDeleteHeader.AutoSize = true;
            this.prsnDeleteHeader.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prsnDeleteHeader.Location = new System.Drawing.Point(252, 31);
            this.prsnDeleteHeader.Name = "prsnDeleteHeader";
            this.prsnDeleteHeader.Size = new System.Drawing.Size(196, 30);
            this.prsnDeleteHeader.TabIndex = 33;
            this.prsnDeleteHeader.Text = "Person | Delete";
            this.prsnDeleteHeader.Click += new System.EventHandler(this.prsnInsertHeader_Click);
            // 
            // txt_deleteID
            // 
            this.txt_deleteID.Location = new System.Drawing.Point(132, 91);
            this.txt_deleteID.Name = "txt_deleteID";
            this.txt_deleteID.Size = new System.Drawing.Size(100, 22);
            this.txt_deleteID.TabIndex = 27;
            this.txt_deleteID.TextChanged += new System.EventHandler(this.txt_inID_TextChanged);
            // 
            // stdRollNumber
            // 
            this.stdRollNumber.AutoSize = true;
            this.stdRollNumber.Location = new System.Drawing.Point(12, 94);
            this.stdRollNumber.Name = "stdRollNumber";
            this.stdRollNumber.Size = new System.Drawing.Size(21, 17);
            this.stdRollNumber.TabIndex = 21;
            this.stdRollNumber.Text = "ID";
            this.stdRollNumber.Click += new System.EventHandler(this.stdRollNumber_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 45);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // adminDeletePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.personGridView);
            this.Controls.Add(this.prsnDeleteHeader);
            this.Controls.Add(this.txt_deleteID);
            this.Controls.Add(this.stdRollNumber);
            this.Controls.Add(this.btnDelete);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminDeletePerson";
            this.Text = "adminDeletePerson";
            this.Load += new System.EventHandler(this.adminDeletePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView personGridView;
        private System.Windows.Forms.Label prsnDeleteHeader;
        private System.Windows.Forms.TextBox txt_deleteID;
        private System.Windows.Forms.Label stdRollNumber;
        private System.Windows.Forms.Button btnDelete;
    }
}