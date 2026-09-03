namespace AccountRegistration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            panel1 = new Panel();
            txtLastName = new TextBox();
            btnNext = new Button();
            label1 = new Label();
            txtAddress = new TextBox();
            txtStudentNo = new TextBox();
            label8 = new Label();
            label2 = new Label();
            txtContactNo = new TextBox();
            cbProgram = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(224, 231, 255);
            label9.Location = new Point(23, 17);
            label9.Name = "label9";
            label9.Size = new Size(345, 32);
            label9.TabIndex = 17;
            label9.Text = "👥 Account Registration Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 30, 42);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtStudentNo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtContactNo);
            panel1.Controls.Add(cbProgram);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtMiddleName);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 375);
            panel1.TabIndex = 18;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(11, 13, 20);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(24, 95);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(184, 23);
            txtLastName.TabIndex = 22;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.HotTrack;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(486, 309);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 43);
            btnNext.TabIndex = 33;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(185, 199, 221);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 17;
            label1.Text = "Student No.:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(11, 13, 20);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(24, 195);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(564, 108);
            txtAddress.TabIndex = 32;
            // 
            // txtStudentNo
            // 
            txtStudentNo.BackColor = Color.FromArgb(11, 13, 20);
            txtStudentNo.BorderStyle = BorderStyle.FixedSingle;
            txtStudentNo.ForeColor = Color.White;
            txtStudentNo.Location = new Point(24, 45);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(184, 23);
            txtStudentNo.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(185, 199, 221);
            label8.Location = new Point(24, 171);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 31;
            label8.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(185, 199, 221);
            label2.Location = new Point(214, 21);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 19;
            label2.Text = "Program:";
            // 
            // txtContactNo
            // 
            txtContactNo.BackColor = Color.FromArgb(11, 13, 20);
            txtContactNo.BorderStyle = BorderStyle.FixedSingle;
            txtContactNo.ForeColor = Color.White;
            txtContactNo.Location = new Point(214, 145);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(184, 23);
            txtContactNo.TabIndex = 30;
            // 
            // cbProgram
            // 
            cbProgram.BackColor = Color.FromArgb(11, 13, 20);
            cbProgram.ForeColor = Color.White;
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(214, 45);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(278, 23);
            cbProgram.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(185, 199, 221);
            label7.Location = new Point(214, 121);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 29;
            label7.Text = "Contact No.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(185, 199, 221);
            label3.Location = new Point(24, 71);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 21;
            label3.Text = "Last Name";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(11, 13, 20);
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.ForeColor = Color.White;
            txtAge.Location = new Point(24, 145);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(184, 23);
            txtAge.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(185, 199, 221);
            label4.Location = new Point(214, 71);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 23;
            label4.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(185, 199, 221);
            label6.Location = new Point(24, 121);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 27;
            label6.Text = "Age:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(11, 13, 20);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(214, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(184, 23);
            txtFirstName.TabIndex = 24;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.FromArgb(11, 13, 20);
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.ForeColor = Color.White;
            txtMiddleName.Location = new Point(404, 95);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(184, 23);
            txtMiddleName.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(185, 199, 221);
            label5.Location = new Point(404, 71);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 25;
            label5.Text = "Middle Name";
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 22, 31);
            ClientSize = new Size(636, 457);
            Controls.Add(label9);
            Controls.Add(panel1);
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Panel panel1;
        private TextBox txtLastName;
        private Button btnNext;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtStudentNo;
        private Label label8;
        private Label label2;
        private TextBox txtContactNo;
        private ComboBox cbProgram;
        private Label label7;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private Label label6;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private Label label5;
    }
}
