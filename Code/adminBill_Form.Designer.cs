
namespace Khali_Wali2
{
    partial class adminBill_Form
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
            this.btn_gym = new System.Windows.Forms.Button();
            this.btn_mess = new System.Windows.Forms.Button();
            this.btn_hostel = new System.Windows.Forms.Button();
            this.pnlLoader = new System.Windows.Forms.Panel();
            this.pnlLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "admin Billing Area";
            // 
            // btn_gym
            // 
            this.btn_gym.Location = new System.Drawing.Point(73, 392);
            this.btn_gym.Name = "btn_gym";
            this.btn_gym.Size = new System.Drawing.Size(123, 48);
            this.btn_gym.TabIndex = 1;
            this.btn_gym.Text = "GYM";
            this.btn_gym.UseVisualStyleBackColor = true;
            this.btn_gym.Click += new System.EventHandler(this.btn_gym_Click);
            // 
            // btn_mess
            // 
            this.btn_mess.Location = new System.Drawing.Point(310, 392);
            this.btn_mess.Name = "btn_mess";
            this.btn_mess.Size = new System.Drawing.Size(123, 48);
            this.btn_mess.TabIndex = 2;
            this.btn_mess.Text = "Mess";
            this.btn_mess.UseVisualStyleBackColor = true;
            this.btn_mess.Click += new System.EventHandler(this.btn_mess_Click);
            // 
            // btn_hostel
            // 
            this.btn_hostel.Location = new System.Drawing.Point(523, 392);
            this.btn_hostel.Name = "btn_hostel";
            this.btn_hostel.Size = new System.Drawing.Size(123, 48);
            this.btn_hostel.TabIndex = 3;
            this.btn_hostel.Text = "Hostel";
            this.btn_hostel.UseVisualStyleBackColor = true;
            this.btn_hostel.Click += new System.EventHandler(this.btn_hostel_Click);
            // 
            // pnlLoader
            // 
            this.pnlLoader.Controls.Add(this.btn_gym);
            this.pnlLoader.Controls.Add(this.label1);
            this.pnlLoader.Controls.Add(this.btn_hostel);
            this.pnlLoader.Controls.Add(this.btn_mess);
            this.pnlLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlLoader.Name = "pnlLoader";
            this.pnlLoader.Size = new System.Drawing.Size(764, 577);
            this.pnlLoader.TabIndex = 4;
            // 
            // adminBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.pnlLoader);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminBillForm";
            this.Text = "adminBillForm";
            this.pnlLoader.ResumeLayout(false);
            this.pnlLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gym;
        private System.Windows.Forms.Button btn_mess;
        private System.Windows.Forms.Button btn_hostel;
        private System.Windows.Forms.Panel pnlLoader;
    }
}