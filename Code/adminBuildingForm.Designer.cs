
namespace Khali_Wali2
{
    partial class adminBuildingForm
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
            this.txt_inB_ID = new System.Windows.Forms.TextBox();
            this.txt_inName = new System.Windows.Forms.TextBox();
            this.txt_inNO_Rooms = new System.Windows.Forms.TextBox();
            this.btn_InsertBuilding = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_deleteBuilding = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Buiding THING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Building ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name of Building";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Rooms";
            // 
            // txt_inB_ID
            // 
            this.txt_inB_ID.Location = new System.Drawing.Point(149, 130);
            this.txt_inB_ID.Name = "txt_inB_ID";
            this.txt_inB_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_inB_ID.TabIndex = 4;
            // 
            // txt_inName
            // 
            this.txt_inName.Location = new System.Drawing.Point(149, 188);
            this.txt_inName.Name = "txt_inName";
            this.txt_inName.Size = new System.Drawing.Size(100, 22);
            this.txt_inName.TabIndex = 5;
            // 
            // txt_inNO_Rooms
            // 
            this.txt_inNO_Rooms.Location = new System.Drawing.Point(149, 245);
            this.txt_inNO_Rooms.Name = "txt_inNO_Rooms";
            this.txt_inNO_Rooms.Size = new System.Drawing.Size(100, 22);
            this.txt_inNO_Rooms.TabIndex = 6;
            // 
            // btn_InsertBuilding
            // 
            this.btn_InsertBuilding.Location = new System.Drawing.Point(64, 403);
            this.btn_InsertBuilding.Name = "btn_InsertBuilding";
            this.btn_InsertBuilding.Size = new System.Drawing.Size(142, 53);
            this.btn_InsertBuilding.TabIndex = 7;
            this.btn_InsertBuilding.Text = "Insert";
            this.btn_InsertBuilding.UseVisualStyleBackColor = true;
            this.btn_InsertBuilding.Click += new System.EventHandler(this.btn_InsertBuilding_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 187);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_deleteBuilding
            // 
            this.btn_deleteBuilding.Location = new System.Drawing.Point(452, 403);
            this.btn_deleteBuilding.Name = "btn_deleteBuilding";
            this.btn_deleteBuilding.Size = new System.Drawing.Size(142, 53);
            this.btn_deleteBuilding.TabIndex = 9;
            this.btn_deleteBuilding.Text = "Delete";
            this.btn_deleteBuilding.UseVisualStyleBackColor = true;
            this.btn_deleteBuilding.Click += new System.EventHandler(this.btn_deleteBuilding_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(61, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Insert a Building ?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(455, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Delete a Building ?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(259, 403);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(142, 53);
            this.btn_view.TabIndex = 12;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // adminBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_deleteBuilding);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_InsertBuilding);
            this.Controls.Add(this.txt_inNO_Rooms);
            this.Controls.Add(this.txt_inName);
            this.Controls.Add(this.txt_inB_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminBuildingForm";
            this.Text = "adminBuildingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_inB_ID;
        private System.Windows.Forms.TextBox txt_inName;
        private System.Windows.Forms.TextBox txt_inNO_Rooms;
        private System.Windows.Forms.Button btn_InsertBuilding;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_deleteBuilding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_view;
    }
}