
namespace Khali_Wali2
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Building = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoom
            // 
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRoom.Location = new System.Drawing.Point(3, 150);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(180, 54);
            this.btnRoom.TabIndex = 3;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            this.btnRoom.Leave += new System.EventHandler(this.btnRoom_Leave);
            // 
            // btnBills
            // 
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBills.Location = new System.Drawing.Point(3, 210);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(180, 54);
            this.btnBills.TabIndex = 5;
            this.btnBills.Text = "Bill";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            this.btnBills.Leave += new System.EventHandler(this.btnBills_Leave);
            // 
            // btnStudent
            // 
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStudent.Location = new System.Drawing.Point(3, 270);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(180, 54);
            this.btnStudent.TabIndex = 6;
            this.btnStudent.Text = "Person";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            this.btnStudent.Leave += new System.EventHandler(this.btnStudent_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_Building);
            this.panel1.Controls.Add(this.btnVisitor);
            this.panel1.Controls.Add(this.btnExpense);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 7;
            // 
            // btn_Building
            // 
            this.btn_Building.FlatAppearance.BorderSize = 0;
            this.btn_Building.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Building.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Building.Location = new System.Drawing.Point(0, 441);
            this.btn_Building.Name = "btn_Building";
            this.btn_Building.Size = new System.Drawing.Size(180, 54);
            this.btn_Building.TabIndex = 11;
            this.btn_Building.Text = "Building";
            this.btn_Building.UseVisualStyleBackColor = true;
            this.btn_Building.Click += new System.EventHandler(this.btn_Building_Click);
            this.btn_Building.Leave += new System.EventHandler(this.btn_Building_Leave);
            // 
            // btnVisitor
            // 
            this.btnVisitor.FlatAppearance.BorderSize = 0;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVisitor.Location = new System.Drawing.Point(3, 390);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(180, 54);
            this.btnVisitor.TabIndex = 10;
            this.btnVisitor.Text = "Visitor";
            this.btnVisitor.UseVisualStyleBackColor = true;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            this.btnVisitor.Leave += new System.EventHandler(this.btnVisitor_Leave);
            // 
            // btnExpense
            // 
            this.btnExpense.FlatAppearance.BorderSize = 0;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExpense.Location = new System.Drawing.Point(3, 330);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(180, 54);
            this.btnExpense.TabIndex = 9;
            this.btnExpense.Text = "Expenses";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            this.btnExpense.Leave += new System.EventHandler(this.btnExpense_Leave);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Location = new System.Drawing.Point(0, 523);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "ADMIN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(0, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 100);
            this.panel3.TabIndex = 8;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormLoader.Location = new System.Drawing.Point(186, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(764, 577);
            this.pnlFormLoader.TabIndex = 9;
            this.pnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormLoader_Paint);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 577);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUI";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Button btn_Building;
    }
}