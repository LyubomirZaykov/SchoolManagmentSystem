namespace SchoolManagmentSystem
{
    partial class AddTeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacherStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teacherDelBtn = new System.Windows.Forms.Button();
            this.teacherClearBtn = new System.Windows.Forms.Button();
            this.teacherUpdateBtn = new System.Windows.Forms.Button();
            this.teacherAddBtn = new System.Windows.Forms.Button();
            this.teacherImportBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teacherImage = new System.Windows.Forms.PictureBox();
            this.teacherAddress = new System.Windows.Forms.TextBox();
            this.teacherAddressLabel = new System.Windows.Forms.Label();
            this.teacherGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherID = new System.Windows.Forms.TextBox();
            this.teacherIdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teachersGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.teacherStatus);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.teacherDelBtn);
            this.panel2.Controls.Add(this.teacherClearBtn);
            this.panel2.Controls.Add(this.teacherUpdateBtn);
            this.panel2.Controls.Add(this.teacherAddBtn);
            this.panel2.Controls.Add(this.teacherImportBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.teacherAddress);
            this.panel2.Controls.Add(this.teacherAddressLabel);
            this.panel2.Controls.Add(this.teacherGender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacherName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teacherID);
            this.panel2.Controls.Add(this.teacherIdLabel);
            this.panel2.Location = new System.Drawing.Point(12, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 237);
            this.panel2.TabIndex = 5;
            // 
            // teacherStatus
            // 
            this.teacherStatus.FormattingEnabled = true;
            this.teacherStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.teacherStatus.Location = new System.Drawing.Point(575, 22);
            this.teacherStatus.Name = "teacherStatus";
            this.teacherStatus.Size = new System.Drawing.Size(134, 21);
            this.teacherStatus.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Status:";
            // 
            // teacherDelBtn
            // 
            this.teacherDelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacherDelBtn.FlatAppearance.BorderSize = 0;
            this.teacherDelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherDelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherDelBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherDelBtn.ForeColor = System.Drawing.Color.White;
            this.teacherDelBtn.Location = new System.Drawing.Point(586, 175);
            this.teacherDelBtn.Name = "teacherDelBtn";
            this.teacherDelBtn.Size = new System.Drawing.Size(119, 40);
            this.teacherDelBtn.TabIndex = 17;
            this.teacherDelBtn.Text = "Delete";
            this.teacherDelBtn.UseVisualStyleBackColor = false;
            this.teacherDelBtn.Click += new System.EventHandler(this.teacherDelBtn_Click);
            // 
            // teacherClearBtn
            // 
            this.teacherClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacherClearBtn.FlatAppearance.BorderSize = 0;
            this.teacherClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherClearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherClearBtn.ForeColor = System.Drawing.Color.White;
            this.teacherClearBtn.Location = new System.Drawing.Point(428, 175);
            this.teacherClearBtn.Name = "teacherClearBtn";
            this.teacherClearBtn.Size = new System.Drawing.Size(119, 40);
            this.teacherClearBtn.TabIndex = 16;
            this.teacherClearBtn.Text = "Clear";
            this.teacherClearBtn.UseVisualStyleBackColor = false;
            this.teacherClearBtn.Click += new System.EventHandler(this.teacherClearBtn_Click);
            // 
            // teacherUpdateBtn
            // 
            this.teacherUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacherUpdateBtn.FlatAppearance.BorderSize = 0;
            this.teacherUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherUpdateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.teacherUpdateBtn.Location = new System.Drawing.Point(268, 175);
            this.teacherUpdateBtn.Name = "teacherUpdateBtn";
            this.teacherUpdateBtn.Size = new System.Drawing.Size(119, 40);
            this.teacherUpdateBtn.TabIndex = 15;
            this.teacherUpdateBtn.Text = "Update";
            this.teacherUpdateBtn.UseVisualStyleBackColor = false;
            this.teacherUpdateBtn.Click += new System.EventHandler(this.teacherUpdateBtn_Click);
            // 
            // teacherAddBtn
            // 
            this.teacherAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacherAddBtn.FlatAppearance.BorderSize = 0;
            this.teacherAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherAddBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherAddBtn.ForeColor = System.Drawing.Color.White;
            this.teacherAddBtn.Location = new System.Drawing.Point(110, 175);
            this.teacherAddBtn.Name = "teacherAddBtn";
            this.teacherAddBtn.Size = new System.Drawing.Size(119, 40);
            this.teacherAddBtn.TabIndex = 14;
            this.teacherAddBtn.Text = "Add";
            this.teacherAddBtn.UseVisualStyleBackColor = false;
            this.teacherAddBtn.Click += new System.EventHandler(this.teacherAddBtn_Click);
            // 
            // teacherImportBtn
            // 
            this.teacherImportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacherImportBtn.FlatAppearance.BorderSize = 0;
            this.teacherImportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherImportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacherImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherImportBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherImportBtn.ForeColor = System.Drawing.Color.White;
            this.teacherImportBtn.Location = new System.Drawing.Point(725, 128);
            this.teacherImportBtn.Name = "teacherImportBtn";
            this.teacherImportBtn.Size = new System.Drawing.Size(121, 28);
            this.teacherImportBtn.TabIndex = 13;
            this.teacherImportBtn.Text = "Import";
            this.teacherImportBtn.UseVisualStyleBackColor = false;
            this.teacherImportBtn.Click += new System.EventHandler(this.teacherImportBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.teacherImage);
            this.panel3.Location = new System.Drawing.Point(725, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 110);
            this.panel3.TabIndex = 12;
            // 
            // teacherImage
            // 
            this.teacherImage.Location = new System.Drawing.Point(0, 0);
            this.teacherImage.Name = "teacherImage";
            this.teacherImage.Size = new System.Drawing.Size(121, 110);
            this.teacherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherImage.TabIndex = 20;
            this.teacherImage.TabStop = false;
            // 
            // teacherAddress
            // 
            this.teacherAddress.Location = new System.Drawing.Point(329, 21);
            this.teacherAddress.Multiline = true;
            this.teacherAddress.Name = "teacherAddress";
            this.teacherAddress.Size = new System.Drawing.Size(134, 67);
            this.teacherAddress.TabIndex = 7;
            // 
            // teacherAddressLabel
            // 
            this.teacherAddressLabel.AutoSize = true;
            this.teacherAddressLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherAddressLabel.Location = new System.Drawing.Point(265, 25);
            this.teacherAddressLabel.Name = "teacherAddressLabel";
            this.teacherAddressLabel.Size = new System.Drawing.Size(66, 16);
            this.teacherAddressLabel.TabIndex = 6;
            this.teacherAddressLabel.Text = "Address:";
            // 
            // teacherGender
            // 
            this.teacherGender.FormattingEnabled = true;
            this.teacherGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.teacherGender.Location = new System.Drawing.Point(103, 110);
            this.teacherGender.Name = "teacherGender";
            this.teacherGender.Size = new System.Drawing.Size(134, 21);
            this.teacherGender.TabIndex = 5;
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
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(103, 63);
            this.teacherName.Multiline = true;
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(134, 25);
            this.teacherName.TabIndex = 3;
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
            // teacherID
            // 
            this.teacherID.Location = new System.Drawing.Point(103, 21);
            this.teacherID.Multiline = true;
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(116, 25);
            this.teacherID.TabIndex = 1;
            // 
            // teacherIdLabel
            // 
            this.teacherIdLabel.AutoSize = true;
            this.teacherIdLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIdLabel.Location = new System.Drawing.Point(17, 25);
            this.teacherIdLabel.Name = "teacherIdLabel";
            this.teacherIdLabel.Size = new System.Drawing.Size(82, 16);
            this.teacherIdLabel.TabIndex = 0;
            this.teacherIdLabel.Text = "Teacher ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.teachersGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 298);
            this.panel1.TabIndex = 4;
            // 
            // teachersGridView
            // 
            this.teachersGridView.AllowUserToAddRows = false;
            this.teachersGridView.AllowUserToDeleteRows = false;
            this.teachersGridView.AllowUserToResizeRows = false;
            this.teachersGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.teachersGridView.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teachersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teachersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersGridView.EnableHeadersVisualStyles = false;
            this.teachersGridView.Location = new System.Drawing.Point(17, 58);
            this.teachersGridView.Name = "teachersGridView";
            this.teachersGridView.ReadOnly = true;
            this.teachersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.teachersGridView.RowHeadersVisible = false;
            this.teachersGridView.Size = new System.Drawing.Size(813, 221);
            this.teachersGridView.TabIndex = 1;
            this.teachersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teachersGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher\'s Data";
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTeacherForm";
            this.Size = new System.Drawing.Size(875, 575);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button teacherDelBtn;
        private System.Windows.Forms.Button teacherClearBtn;
        private System.Windows.Forms.Button teacherUpdateBtn;
        private System.Windows.Forms.Button teacherAddBtn;
        private System.Windows.Forms.Button teacherImportBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox teacherAddress;
        private System.Windows.Forms.Label teacherAddressLabel;
        private System.Windows.Forms.ComboBox teacherGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacherID;
        private System.Windows.Forms.Label teacherIdLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teachersGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacherStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox teacherImage;
    }
}
