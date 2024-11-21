namespace SchoolManagmentSystem
{
    partial class AddStudentForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentDeleteBtn = new System.Windows.Forms.Button();
            this.studentClearBtn = new System.Windows.Forms.Button();
            this.studentUpdateBtn = new System.Windows.Forms.Button();
            this.studentAddBtn = new System.Windows.Forms.Button();
            this.studentImportBtn = new System.Windows.Forms.Button();
            this.studentImagePanel = new System.Windows.Forms.Panel();
            this.studentImage = new System.Windows.Forms.PictureBox();
            this.studentSection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentGrade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.studentStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.studentImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.studentStatus);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.studentDeleteBtn);
            this.panel2.Controls.Add(this.studentClearBtn);
            this.panel2.Controls.Add(this.studentUpdateBtn);
            this.panel2.Controls.Add(this.studentAddBtn);
            this.panel2.Controls.Add(this.studentImportBtn);
            this.panel2.Controls.Add(this.studentImagePanel);
            this.panel2.Controls.Add(this.studentSection);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.studentGrade);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.studentAddress);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.studentGender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.studentName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.studentID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 237);
            this.panel2.TabIndex = 3;
            // 
            // studentDeleteBtn
            // 
            this.studentDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.studentDeleteBtn.FlatAppearance.BorderSize = 0;
            this.studentDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentDeleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.studentDeleteBtn.Location = new System.Drawing.Point(586, 175);
            this.studentDeleteBtn.Name = "studentDeleteBtn";
            this.studentDeleteBtn.Size = new System.Drawing.Size(119, 40);
            this.studentDeleteBtn.TabIndex = 17;
            this.studentDeleteBtn.Text = "Delete";
            this.studentDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // studentClearBtn
            // 
            this.studentClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.studentClearBtn.FlatAppearance.BorderSize = 0;
            this.studentClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentClearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentClearBtn.ForeColor = System.Drawing.Color.White;
            this.studentClearBtn.Location = new System.Drawing.Point(428, 175);
            this.studentClearBtn.Name = "studentClearBtn";
            this.studentClearBtn.Size = new System.Drawing.Size(119, 40);
            this.studentClearBtn.TabIndex = 16;
            this.studentClearBtn.Text = "Clear";
            this.studentClearBtn.UseVisualStyleBackColor = false;
            this.studentClearBtn.Click += new System.EventHandler(this.studentClearBtn_Click);
            // 
            // studentUpdateBtn
            // 
            this.studentUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.studentUpdateBtn.FlatAppearance.BorderSize = 0;
            this.studentUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentUpdateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.studentUpdateBtn.Location = new System.Drawing.Point(268, 175);
            this.studentUpdateBtn.Name = "studentUpdateBtn";
            this.studentUpdateBtn.Size = new System.Drawing.Size(119, 40);
            this.studentUpdateBtn.TabIndex = 15;
            this.studentUpdateBtn.Text = "Update";
            this.studentUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // studentAddBtn
            // 
            this.studentAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.studentAddBtn.FlatAppearance.BorderSize = 0;
            this.studentAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentAddBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAddBtn.ForeColor = System.Drawing.Color.White;
            this.studentAddBtn.Location = new System.Drawing.Point(110, 175);
            this.studentAddBtn.Name = "studentAddBtn";
            this.studentAddBtn.Size = new System.Drawing.Size(119, 40);
            this.studentAddBtn.TabIndex = 14;
            this.studentAddBtn.Text = "Add";
            this.studentAddBtn.UseVisualStyleBackColor = false;
            this.studentAddBtn.Click += new System.EventHandler(this.studentAddBtn_Click);
            // 
            // studentImportBtn
            // 
            this.studentImportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.studentImportBtn.FlatAppearance.BorderSize = 0;
            this.studentImportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentImportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.studentImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentImportBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentImportBtn.ForeColor = System.Drawing.Color.White;
            this.studentImportBtn.Location = new System.Drawing.Point(725, 128);
            this.studentImportBtn.Name = "studentImportBtn";
            this.studentImportBtn.Size = new System.Drawing.Size(121, 28);
            this.studentImportBtn.TabIndex = 13;
            this.studentImportBtn.Text = "Import";
            this.studentImportBtn.UseVisualStyleBackColor = false;
            this.studentImportBtn.Click += new System.EventHandler(this.studentImportBtn_Click);
            // 
            // studentImagePanel
            // 
            this.studentImagePanel.BackColor = System.Drawing.Color.Gray;
            this.studentImagePanel.Controls.Add(this.studentImage);
            this.studentImagePanel.Location = new System.Drawing.Point(725, 19);
            this.studentImagePanel.Name = "studentImagePanel";
            this.studentImagePanel.Size = new System.Drawing.Size(121, 110);
            this.studentImagePanel.TabIndex = 12;
            // 
            // studentImage
            // 
            this.studentImage.Location = new System.Drawing.Point(0, 0);
            this.studentImage.Name = "studentImage";
            this.studentImage.Size = new System.Drawing.Size(121, 110);
            this.studentImage.TabIndex = 0;
            this.studentImage.TabStop = false;
            // 
            // studentSection
            // 
            this.studentSection.FormattingEnabled = true;
            this.studentSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.studentSection.Location = new System.Drawing.Point(569, 19);
            this.studentSection.Name = "studentSection";
            this.studentSection.Size = new System.Drawing.Size(134, 21);
            this.studentSection.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Section:";
            // 
            // studentGrade
            // 
            this.studentGrade.FormattingEnabled = true;
            this.studentGrade.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.studentGrade.Location = new System.Drawing.Point(329, 108);
            this.studentGrade.Name = "studentGrade";
            this.studentGrade.Size = new System.Drawing.Size(134, 21);
            this.studentGrade.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grade:";
            // 
            // studentAddress
            // 
            this.studentAddress.Location = new System.Drawing.Point(329, 21);
            this.studentAddress.Multiline = true;
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.Size = new System.Drawing.Size(134, 67);
            this.studentAddress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address:";
            // 
            // studentGender
            // 
            this.studentGender.FormattingEnabled = true;
            this.studentGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.studentGender.Location = new System.Drawing.Point(103, 110);
            this.studentGender.Name = "studentGender";
            this.studentGender.Size = new System.Drawing.Size(134, 21);
            this.studentGender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(103, 63);
            this.studentName.Multiline = true;
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(134, 25);
            this.studentName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(103, 21);
            this.studentID.Multiline = true;
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(116, 25);
            this.studentID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.studentsGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 298);
            this.panel1.TabIndex = 2;
            // 
            // studentsGridView
            // 
            this.studentsGridView.AllowUserToAddRows = false;
            this.studentsGridView.AllowUserToDeleteRows = false;
            this.studentsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.EnableHeadersVisualStyles = false;
            this.studentsGridView.Location = new System.Drawing.Point(17, 58);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.ReadOnly = true;
            this.studentsGridView.RowHeadersVisible = false;
            this.studentsGridView.Size = new System.Drawing.Size(813, 221);
            this.studentsGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Data";
            // 
            // studentStatus
            // 
            this.studentStatus.FormattingEnabled = true;
            this.studentStatus.Items.AddRange(new object[] {
            "Enrolled",
            "Pending",
            "Graduated"});
            this.studentStatus.Location = new System.Drawing.Point(569, 63);
            this.studentStatus.Name = "studentStatus";
            this.studentStatus.Size = new System.Drawing.Size(134, 21);
            this.studentStatus.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(505, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Status:";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudentForm";
            this.Size = new System.Drawing.Size(875, 575);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.studentImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button studentDeleteBtn;
        private System.Windows.Forms.Button studentClearBtn;
        private System.Windows.Forms.Button studentUpdateBtn;
        private System.Windows.Forms.Button studentAddBtn;
        private System.Windows.Forms.Button studentImportBtn;
        private System.Windows.Forms.Panel studentImagePanel;
        private System.Windows.Forms.ComboBox studentSection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox studentGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox studentGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox studentImage;
        private System.Windows.Forms.ComboBox studentStatus;
        private System.Windows.Forms.Label label8;
    }
}
