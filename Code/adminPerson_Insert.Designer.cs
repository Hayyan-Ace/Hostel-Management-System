
namespace Khali_Wali2
{
    partial class adminPerson_Insert
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.stdRollNumber = new System.Windows.Forms.Label();
            this.stdName = new System.Windows.Forms.Label();
            this.stdContact = new System.Windows.Forms.Label();
            this.stdCNIC = new System.Windows.Forms.Label();
            this.stdGender = new System.Windows.Forms.Label();
            this.stdPassword = new System.Windows.Forms.Label();
            this.txt_inID = new System.Windows.Forms.TextBox();
            this.txt_inFullName = new System.Windows.Forms.TextBox();
            this.txt_inContact = new System.Windows.Forms.TextBox();
            this.txt_inCNIC = new System.Windows.Forms.TextBox();
            this.txt_inPassword = new System.Windows.Forms.TextBox();
            this.txt_inGender = new System.Windows.Forms.TextBox();
            this.prsnInsertHeader = new System.Windows.Forms.Label();
            this.inPosition = new System.Windows.Forms.Label();
            this.inAddress = new System.Windows.Forms.Label();
            this.txt_inAddress = new System.Windows.Forms.TextBox();
            this.txt_inPosition = new System.Windows.Forms.TextBox();
            this.personGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_inGymBool = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(47, 499);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(217, 45);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // stdRollNumber
            // 
            this.stdRollNumber.AutoSize = true;
            this.stdRollNumber.Location = new System.Drawing.Point(12, 98);
            this.stdRollNumber.Name = "stdRollNumber";
            this.stdRollNumber.Size = new System.Drawing.Size(21, 17);
            this.stdRollNumber.TabIndex = 1;
            this.stdRollNumber.Text = "ID";
            // 
            // stdName
            // 
            this.stdName.AutoSize = true;
            this.stdName.Location = new System.Drawing.Point(12, 138);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(75, 17);
            this.stdName.TabIndex = 2;
            this.stdName.Text = "Full Name ";
            this.stdName.Click += new System.EventHandler(this.label2_Click);
            // 
            // stdContact
            // 
            this.stdContact.AutoSize = true;
            this.stdContact.Location = new System.Drawing.Point(12, 180);
            this.stdContact.Name = "stdContact";
            this.stdContact.Size = new System.Drawing.Size(68, 17);
            this.stdContact.TabIndex = 3;
            this.stdContact.Text = "Contact #";
            this.stdContact.Click += new System.EventHandler(this.label3_Click);
            // 
            // stdCNIC
            // 
            this.stdCNIC.AutoSize = true;
            this.stdCNIC.Location = new System.Drawing.Point(12, 270);
            this.stdCNIC.Name = "stdCNIC";
            this.stdCNIC.Size = new System.Drawing.Size(39, 17);
            this.stdCNIC.TabIndex = 4;
            this.stdCNIC.Text = "CNIC";
            // 
            // stdGender
            // 
            this.stdGender.AutoSize = true;
            this.stdGender.Location = new System.Drawing.Point(12, 346);
            this.stdGender.Name = "stdGender";
            this.stdGender.Size = new System.Drawing.Size(56, 17);
            this.stdGender.TabIndex = 5;
            this.stdGender.Text = "Gender";
            // 
            // stdPassword
            // 
            this.stdPassword.AutoSize = true;
            this.stdPassword.Location = new System.Drawing.Point(12, 312);
            this.stdPassword.Name = "stdPassword";
            this.stdPassword.Size = new System.Drawing.Size(69, 17);
            this.stdPassword.TabIndex = 6;
            this.stdPassword.Text = "Password";
            // 
            // txt_inID
            // 
            this.txt_inID.Location = new System.Drawing.Point(151, 98);
            this.txt_inID.Name = "txt_inID";
            this.txt_inID.Size = new System.Drawing.Size(100, 22);
            this.txt_inID.TabIndex = 7;
            // 
            // txt_inFullName
            // 
            this.txt_inFullName.Location = new System.Drawing.Point(151, 138);
            this.txt_inFullName.Name = "txt_inFullName";
            this.txt_inFullName.Size = new System.Drawing.Size(100, 22);
            this.txt_inFullName.TabIndex = 8;
            // 
            // txt_inContact
            // 
            this.txt_inContact.Location = new System.Drawing.Point(151, 180);
            this.txt_inContact.Name = "txt_inContact";
            this.txt_inContact.Size = new System.Drawing.Size(100, 22);
            this.txt_inContact.TabIndex = 9;
            // 
            // txt_inCNIC
            // 
            this.txt_inCNIC.Location = new System.Drawing.Point(151, 265);
            this.txt_inCNIC.Name = "txt_inCNIC";
            this.txt_inCNIC.Size = new System.Drawing.Size(100, 22);
            this.txt_inCNIC.TabIndex = 10;
            // 
            // txt_inPassword
            // 
            this.txt_inPassword.Location = new System.Drawing.Point(151, 307);
            this.txt_inPassword.Name = "txt_inPassword";
            this.txt_inPassword.Size = new System.Drawing.Size(100, 22);
            this.txt_inPassword.TabIndex = 11;
            // 
            // txt_inGender
            // 
            this.txt_inGender.Location = new System.Drawing.Point(151, 343);
            this.txt_inGender.Name = "txt_inGender";
            this.txt_inGender.Size = new System.Drawing.Size(79, 22);
            this.txt_inGender.TabIndex = 12;
            this.txt_inGender.TextChanged += new System.EventHandler(this.txt_inGender_TextChanged);
            // 
            // prsnInsertHeader
            // 
            this.prsnInsertHeader.AutoSize = true;
            this.prsnInsertHeader.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prsnInsertHeader.Location = new System.Drawing.Point(252, 29);
            this.prsnInsertHeader.Name = "prsnInsertHeader";
            this.prsnInsertHeader.Size = new System.Drawing.Size(187, 30);
            this.prsnInsertHeader.TabIndex = 13;
            this.prsnInsertHeader.Text = "Person | Insert";
            this.prsnInsertHeader.Click += new System.EventHandler(this.stdInsertHeader_Click);
            // 
            // inPosition
            // 
            this.inPosition.AutoSize = true;
            this.inPosition.Location = new System.Drawing.Point(12, 387);
            this.inPosition.Name = "inPosition";
            this.inPosition.Size = new System.Drawing.Size(134, 17);
            this.inPosition.TabIndex = 14;
            this.inPosition.Text = "Postion/Designation";
            // 
            // inAddress
            // 
            this.inAddress.AutoSize = true;
            this.inAddress.Location = new System.Drawing.Point(12, 220);
            this.inAddress.Name = "inAddress";
            this.inAddress.Size = new System.Drawing.Size(60, 17);
            this.inAddress.TabIndex = 15;
            this.inAddress.Text = "Address";
            // 
            // txt_inAddress
            // 
            this.txt_inAddress.Location = new System.Drawing.Point(151, 220);
            this.txt_inAddress.Name = "txt_inAddress";
            this.txt_inAddress.Size = new System.Drawing.Size(100, 22);
            this.txt_inAddress.TabIndex = 16;
            // 
            // txt_inPosition
            // 
            this.txt_inPosition.Location = new System.Drawing.Point(151, 382);
            this.txt_inPosition.Name = "txt_inPosition";
            this.txt_inPosition.Size = new System.Drawing.Size(100, 22);
            this.txt_inPosition.TabIndex = 17;
            // 
            // personGridView
            // 
            this.personGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personGridView.GridColor = System.Drawing.SystemColors.Highlight;
            this.personGridView.Location = new System.Drawing.Point(290, 87);
            this.personGridView.Name = "personGridView";
            this.personGridView.RowHeadersWidth = 51;
            this.personGridView.RowTemplate.Height = 24;
            this.personGridView.Size = new System.Drawing.Size(462, 322);
            this.personGridView.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(230, 341);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(21, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "GYM";
            // 
            // cbx_inGymBool
            // 
            this.cbx_inGymBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_inGymBool.FormattingEnabled = true;
            this.cbx_inGymBool.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbx_inGymBool.Location = new System.Drawing.Point(151, 421);
            this.cbx_inGymBool.Name = "cbx_inGymBool";
            this.cbx_inGymBool.Size = new System.Drawing.Size(100, 24);
            this.cbx_inGymBool.TabIndex = 21;
            // 
            // adminInsertPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.cbx_inGymBool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.personGridView);
            this.Controls.Add(this.txt_inPosition);
            this.Controls.Add(this.txt_inAddress);
            this.Controls.Add(this.inAddress);
            this.Controls.Add(this.inPosition);
            this.Controls.Add(this.prsnInsertHeader);
            this.Controls.Add(this.txt_inGender);
            this.Controls.Add(this.txt_inPassword);
            this.Controls.Add(this.txt_inCNIC);
            this.Controls.Add(this.txt_inContact);
            this.Controls.Add(this.txt_inFullName);
            this.Controls.Add(this.txt_inID);
            this.Controls.Add(this.stdPassword);
            this.Controls.Add(this.stdGender);
            this.Controls.Add(this.stdCNIC);
            this.Controls.Add(this.stdContact);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.stdRollNumber);
            this.Controls.Add(this.btnInsert);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminInsertPerson";
            this.Text = "adminInsertStudent";
            ((System.ComponentModel.ISupportInitialize)(this.personGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label stdRollNumber;
        private System.Windows.Forms.Label stdName;
        private System.Windows.Forms.Label stdContact;
        private System.Windows.Forms.Label stdCNIC;
        private System.Windows.Forms.Label stdGender;
        private System.Windows.Forms.Label stdPassword;
        private System.Windows.Forms.TextBox txt_inID;
        private System.Windows.Forms.TextBox txt_inFullName;
        private System.Windows.Forms.TextBox txt_inContact;
        private System.Windows.Forms.TextBox txt_inCNIC;
        private System.Windows.Forms.TextBox txt_inPassword;
        private System.Windows.Forms.TextBox txt_inGender;
        private System.Windows.Forms.Label prsnInsertHeader;
        private System.Windows.Forms.Label inPosition;
        private System.Windows.Forms.Label inAddress;
        private System.Windows.Forms.TextBox txt_inAddress;
        private System.Windows.Forms.TextBox txt_inPosition;
        private System.Windows.Forms.DataGridView personGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_inGymBool;
    }
}