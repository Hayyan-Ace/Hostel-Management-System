
namespace Khali_Wali2
{
    partial class adminPerson_Form
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
            this.btnInsertForm = new System.Windows.Forms.Button();
            this.pnlLoader = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDeleteForm = new System.Windows.Forms.Button();
            this.pnlLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(223, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "adminPersonForm";
            // 
            // btnInsertForm
            // 
            this.btnInsertForm.Location = new System.Drawing.Point(62, 364);
            this.btnInsertForm.Name = "btnInsertForm";
            this.btnInsertForm.Size = new System.Drawing.Size(132, 78);
            this.btnInsertForm.TabIndex = 1;
            this.btnInsertForm.Text = "Insert";
            this.btnInsertForm.UseVisualStyleBackColor = true;
            this.btnInsertForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlLoader
            // 
            this.pnlLoader.Controls.Add(this.btnView);
            this.pnlLoader.Controls.Add(this.btnDeleteForm);
            this.pnlLoader.Controls.Add(this.btnInsertForm);
            this.pnlLoader.Controls.Add(this.label1);
            this.pnlLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlLoader.Name = "pnlLoader";
            this.pnlLoader.Size = new System.Drawing.Size(764, 577);
            this.pnlLoader.TabIndex = 4;
            this.pnlLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLoader_Paint);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(551, 364);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(132, 78);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDeleteForm
            // 
            this.btnDeleteForm.Location = new System.Drawing.Point(307, 364);
            this.btnDeleteForm.Name = "btnDeleteForm";
            this.btnDeleteForm.Size = new System.Drawing.Size(132, 78);
            this.btnDeleteForm.TabIndex = 2;
            this.btnDeleteForm.Text = "Delete";
            this.btnDeleteForm.UseVisualStyleBackColor = true;
            this.btnDeleteForm.Click += new System.EventHandler(this.btnDeleteForm_Click);
            // 
            // adminPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.pnlLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminPersonForm";
            this.Text = "adminStudentForm";
            this.pnlLoader.ResumeLayout(false);
            this.pnlLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertForm;
        private System.Windows.Forms.Panel pnlLoader;
        private System.Windows.Forms.Button btnDeleteForm;
        private System.Windows.Forms.Button btnView;
    }
}