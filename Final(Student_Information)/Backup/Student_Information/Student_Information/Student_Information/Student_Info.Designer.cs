namespace Student_Information
{
    partial class StudentInformation
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateofBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_DateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_InfoDataSet = new Student_Information.Student_InfoDataSet();
            this.tblSemeseterInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SemeseterInfoTableAdapter = new Student_Information.Student_InfoDataSetTableAdapters.tbl_SemeseterInfoTableAdapter();
            this.radiobtnMale = new System.Windows.Forms.RadioButton();
            this.radiobtnFemale = new System.Windows.Forms.RadioButton();
            this.comboBoxReligion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSemester = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSemeseterInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(472, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(321, 13);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(226, 20);
            this.txtRoll.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(321, 39);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(226, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(321, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(226, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // dateofBirth
            // 
            this.dateofBirth.Location = new System.Drawing.Point(321, 65);
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Size = new System.Drawing.Size(226, 20);
            this.dateofBirth.TabIndex = 4;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(321, 144);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(226, 21);
            this.comboBoxSemester.TabIndex = 6;
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(321, 171);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(226, 21);
            this.comboBoxDept.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student_Roll :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student_Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student_DateofBirth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student_Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student_Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student_Semester:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Student_Dept.:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Id,
            this.Student_Roll,
            this.Student_Name,
            this.Student_DateofBirth,
            this.Student_Gender,
            this.Student_Semester,
            this.Student_Department,
            this.Student_Religion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(713, 140);
            this.dataGridView1.TabIndex = 15;
            // 
            // Student_Id
            // 
            this.Student_Id.DataPropertyName = "Student_Id";
            this.Student_Id.HeaderText = "Id";
            this.Student_Id.Name = "Student_Id";
            this.Student_Id.ReadOnly = true;
            this.Student_Id.Width = 50;
            // 
            // Student_Roll
            // 
            this.Student_Roll.DataPropertyName = "Student_Roll";
            this.Student_Roll.HeaderText = "Roll";
            this.Student_Roll.Name = "Student_Roll";
            this.Student_Roll.ReadOnly = true;
            this.Student_Roll.Width = 50;
            // 
            // Student_Name
            // 
            this.Student_Name.DataPropertyName = "Student_Name";
            this.Student_Name.HeaderText = "Name";
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.ReadOnly = true;
            this.Student_Name.Width = 150;
            // 
            // Student_DateofBirth
            // 
            this.Student_DateofBirth.DataPropertyName = "Student_DateofBirth";
            this.Student_DateofBirth.HeaderText = "DateofBirth";
            this.Student_DateofBirth.Name = "Student_DateofBirth";
            this.Student_DateofBirth.ReadOnly = true;
            // 
            // Student_Gender
            // 
            this.Student_Gender.DataPropertyName = "Student_Gender";
            this.Student_Gender.HeaderText = "Gender";
            this.Student_Gender.Name = "Student_Gender";
            this.Student_Gender.ReadOnly = true;
            this.Student_Gender.Width = 50;
            // 
            // Student_Semester
            // 
            this.Student_Semester.DataPropertyName = "Student_Semester";
            this.Student_Semester.HeaderText = "Semester";
            this.Student_Semester.Name = "Student_Semester";
            this.Student_Semester.ReadOnly = true;
            // 
            // Student_Department
            // 
            this.Student_Department.DataPropertyName = "Student_Department";
            this.Student_Department.HeaderText = "Dept.";
            this.Student_Department.Name = "Student_Department";
            this.Student_Department.ReadOnly = true;
            // 
            // Student_Religion
            // 
            this.Student_Religion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student_Religion.DataPropertyName = "Student_Religion";
            this.Student_Religion.HeaderText = "Religion";
            this.Student_Religion.Name = "Student_Religion";
            this.Student_Religion.ReadOnly = true;
            // 
            // student_InfoDataSet
            // 
            this.student_InfoDataSet.DataSetName = "Student_InfoDataSet";
            this.student_InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSemeseterInfoBindingSource
            // 
            this.tblSemeseterInfoBindingSource.DataMember = "tbl_SemeseterInfo";
            this.tblSemeseterInfoBindingSource.DataSource = this.student_InfoDataSet;
            // 
            // tbl_SemeseterInfoTableAdapter
            // 
            this.tbl_SemeseterInfoTableAdapter.ClearBeforeFill = true;
            // 
            // radiobtnMale
            // 
            this.radiobtnMale.AutoSize = true;
            this.radiobtnMale.Location = new System.Drawing.Point(321, 118);
            this.radiobtnMale.Name = "radiobtnMale";
            this.radiobtnMale.Size = new System.Drawing.Size(48, 17);
            this.radiobtnMale.TabIndex = 16;
            this.radiobtnMale.TabStop = true;
            this.radiobtnMale.Text = "Male";
            this.radiobtnMale.UseVisualStyleBackColor = true;
            this.radiobtnMale.CheckedChanged += new System.EventHandler(this.radiobtnMale_CheckedChanged);
            // 
            // radiobtnFemale
            // 
            this.radiobtnFemale.AutoSize = true;
            this.radiobtnFemale.Location = new System.Drawing.Point(375, 118);
            this.radiobtnFemale.Name = "radiobtnFemale";
            this.radiobtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radiobtnFemale.TabIndex = 17;
            this.radiobtnFemale.TabStop = true;
            this.radiobtnFemale.Text = "Female";
            this.radiobtnFemale.UseVisualStyleBackColor = true;
            this.radiobtnFemale.CheckedChanged += new System.EventHandler(this.radiobtnFemale_CheckedChanged);
            // 
            // comboBoxReligion
            // 
            this.comboBoxReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReligion.FormattingEnabled = true;
            this.comboBoxReligion.Items.AddRange(new object[] {
            "Islam",
            "Hindu",
            "Christain",
            "Bhuddo"});
            this.comboBoxReligion.Location = new System.Drawing.Point(321, 198);
            this.comboBoxReligion.Name = "comboBoxReligion";
            this.comboBoxReligion.Size = new System.Drawing.Size(226, 21);
            this.comboBoxReligion.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Religion:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(247, 225);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(207, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSemester
            // 
            this.btnSemester.Location = new System.Drawing.Point(69, 225);
            this.btnSemester.Name = "btnSemester";
            this.btnSemester.Size = new System.Drawing.Size(75, 23);
            this.btnSemester.TabIndex = 22;
            this.btnSemester.Text = "Semester";
            this.btnSemester.UseVisualStyleBackColor = true;
            this.btnSemester.Click += new System.EventHandler(this.btnSemester_Click);
            // 
            // StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(737, 409);
            this.Controls.Add(this.btnSemester);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxReligion);
            this.Controls.Add(this.radiobtnFemale);
            this.Controls.Add(this.radiobtnMale);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.dateofBirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "StudentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInformation";
            this.Load += new System.EventHandler(this.StudentInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSemeseterInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dateofBirth;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Student_InfoDataSet student_InfoDataSet;
        private System.Windows.Forms.BindingSource tblSemeseterInfoBindingSource;
        private Student_InfoDataSetTableAdapters.tbl_SemeseterInfoTableAdapter tbl_SemeseterInfoTableAdapter;
        private System.Windows.Forms.RadioButton radiobtnMale;
        private System.Windows.Forms.RadioButton radiobtnFemale;
        private System.Windows.Forms.ComboBox comboBoxReligion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_DateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Religion;
        private System.Windows.Forms.Button btnSemester;
    }
}

