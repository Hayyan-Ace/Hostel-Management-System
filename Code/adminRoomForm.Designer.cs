﻿
namespace Khali_Wali2
{
    partial class adminRoomForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inPersonID = new System.Windows.Forms.TextBox();
            this.txt_inB_ID = new System.Windows.Forms.TextBox();
            this.txt_inRoomNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsertInRoom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_RoomChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(213, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "adminRoomAllocation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(25, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "B_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(25, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Room";
            // 
            // txt_inPersonID
            // 
            this.txt_inPersonID.Location = new System.Drawing.Point(135, 129);
            this.txt_inPersonID.Name = "txt_inPersonID";
            this.txt_inPersonID.Size = new System.Drawing.Size(100, 22);
            this.txt_inPersonID.TabIndex = 7;
            // 
            // txt_inB_ID
            // 
            this.txt_inB_ID.Location = new System.Drawing.Point(135, 182);
            this.txt_inB_ID.Name = "txt_inB_ID";
            this.txt_inB_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_inB_ID.TabIndex = 8;
            // 
            // txt_inRoomNo
            // 
            this.txt_inRoomNo.Location = new System.Drawing.Point(135, 234);
            this.txt_inRoomNo.Name = "txt_inRoomNo";
            this.txt_inRoomNo.Size = new System.Drawing.Size(100, 22);
            this.txt_inRoomNo.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(410, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnInsertInRoom
            // 
            this.btnInsertInRoom.Location = new System.Drawing.Point(44, 439);
            this.btnInsertInRoom.Name = "btnInsertInRoom";
            this.btnInsertInRoom.Size = new System.Drawing.Size(191, 65);
            this.btnInsertInRoom.TabIndex = 12;
            this.btnInsertInRoom.Text = "Insert";
            this.btnInsertInRoom.UseVisualStyleBackColor = true;
            this.btnInsertInRoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Verify !";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_RoomChange
            // 
            this.btn_RoomChange.Location = new System.Drawing.Point(472, 439);
            this.btn_RoomChange.Name = "btn_RoomChange";
            this.btn_RoomChange.Size = new System.Drawing.Size(191, 65);
            this.btn_RoomChange.TabIndex = 14;
            this.btn_RoomChange.Text = "Change Room";
            this.btn_RoomChange.UseVisualStyleBackColor = true;
            this.btn_RoomChange.Click += new System.EventHandler(this.btn_RoomChange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 65);
            this.button1.TabIndex = 15;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // adminRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_RoomChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInsertInRoom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_inRoomNo);
            this.Controls.Add(this.txt_inB_ID);
            this.Controls.Add(this.txt_inPersonID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminRoomForm";
            this.Text = "adminRoom";
            this.Load += new System.EventHandler(this.adminRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_inPersonID;
        private System.Windows.Forms.TextBox txt_inB_ID;
        private System.Windows.Forms.TextBox txt_inRoomNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsertInRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_RoomChange;
        private System.Windows.Forms.Button button1;
    }
}