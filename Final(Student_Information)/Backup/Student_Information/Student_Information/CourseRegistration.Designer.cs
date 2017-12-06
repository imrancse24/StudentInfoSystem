namespace Student_Information
{
    partial class CourseRegistration
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFullName = new System.Windows.Forms.ComboBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.txtStdRoll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbCourseCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Sl_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.cmbFullName);
            this.groupBox2.Controls.Add(this.txtSession);
            this.groupBox2.Controls.Add(this.txtStdRoll);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.cmbDept);
            this.groupBox2.Controls.Add(this.cmbSemester);
            this.groupBox2.Controls.Add(this.cmbCourseCode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(26, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courses";
            // 
            // cmbFullName
            // 
            this.cmbFullName.FormattingEnabled = true;
            this.cmbFullName.Location = new System.Drawing.Point(427, 30);
            this.cmbFullName.Name = "cmbFullName";
            this.cmbFullName.Size = new System.Drawing.Size(280, 21);
            this.cmbFullName.TabIndex = 5;
            this.cmbFullName.SelectedIndexChanged += new System.EventHandler(this.cmbFullName_SelectedIndexChanged);
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(152, 204);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(556, 20);
            this.txtSession.TabIndex = 4;
            // 
            // txtStdRoll
            // 
            this.txtStdRoll.Location = new System.Drawing.Point(152, 32);
            this.txtStdRoll.Name = "txtStdRoll";
            this.txtStdRoll.Size = new System.Drawing.Size(179, 20);
            this.txtStdRoll.TabIndex = 4;
            this.txtStdRoll.TextChanged += new System.EventHandler(this.txtStdRoll_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Roll";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(556, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(152, 63);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(556, 21);
            this.cmbDept.TabIndex = 2;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "Fall",
            "Spring",
            "Summer"});
            this.cmbSemester.Location = new System.Drawing.Point(152, 94);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(556, 21);
            this.cmbSemester.TabIndex = 2;
            // 
            // cmbCourseCode
            // 
            this.cmbCourseCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseCode.FormattingEnabled = true;
            this.cmbCourseCode.Location = new System.Drawing.Point(151, 129);
            this.cmbCourseCode.Name = "cmbCourseCode";
            this.cmbCourseCode.Size = new System.Drawing.Size(556, 21);
            this.cmbCourseCode.TabIndex = 2;
            this.cmbCourseCode.SelectedIndexChanged += new System.EventHandler(this.cmbCourseCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dept.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Course Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Course Name";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(238, 279);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl_No,
            this.Student_Roll,
            this.Dept,
            this.Semester_Name,
            this.Course_Code,
            this.Course_Name,
            this.Session});
            this.dataGridView.Location = new System.Drawing.Point(26, 325);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(731, 173);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // Sl_No
            // 
            this.Sl_No.DataPropertyName = "Sl_No";
            this.Sl_No.HeaderText = "Sl_No";
            this.Sl_No.Name = "Sl_No";
            // 
            // Student_Roll
            // 
            this.Student_Roll.DataPropertyName = "Student_Roll";
            this.Student_Roll.HeaderText = "Student_Roll";
            this.Student_Roll.Name = "Student_Roll";
            // 
            // Dept
            // 
            this.Dept.DataPropertyName = "Dept";
            this.Dept.HeaderText = "Dept";
            this.Dept.Name = "Dept";
            // 
            // Semester_Name
            // 
            this.Semester_Name.DataPropertyName = "Semester_Name";
            this.Semester_Name.HeaderText = "Semester_Name";
            this.Semester_Name.Name = "Semester_Name";
            // 
            // Course_Code
            // 
            this.Course_Code.DataPropertyName = "Course_Code";
            this.Course_Code.HeaderText = "Course_Code";
            this.Course_Code.Name = "Course_Code";
            // 
            // Course_Name
            // 
            this.Course_Name.DataPropertyName = "Course_Name";
            this.Course_Name.HeaderText = "Course_Name";
            this.Course_Name.Name = "Course_Name";
            // 
            // Session
            // 
            this.Session.DataPropertyName = "Session";
            this.Session.HeaderText = "Session";
            this.Session.Name = "Session";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(349, 279);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(467, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CourseRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.CourseRegistration_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbCourseCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtStdRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
    }
}