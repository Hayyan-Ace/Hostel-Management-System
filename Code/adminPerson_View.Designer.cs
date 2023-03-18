
namespace Khali_Wali2
{
    partial class adminPerson_View
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
            this.btnView = new System.Windows.Forms.Button();
            this.personGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.personGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(286, 374);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(149, 71);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // personGridView
            // 
            this.personGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personGridView.Location = new System.Drawing.Point(12, 12);
            this.personGridView.Name = "personGridView";
            this.personGridView.RowHeadersWidth = 51;
            this.personGridView.RowTemplate.Height = 24;
            this.personGridView.Size = new System.Drawing.Size(685, 210);
            this.personGridView.TabIndex = 1;
            this.personGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personGridView_CellContentClick);
            // 
            // adminViewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(746, 530);
            this.Controls.Add(this.personGridView);
            this.Controls.Add(this.btnView);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminViewPerson";
            this.Text = "adminViewPerson";
            ((System.ComponentModel.ISupportInitialize)(this.personGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView personGridView;
    }
}