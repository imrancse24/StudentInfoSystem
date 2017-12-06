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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateofBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grdBasicInfo = new System.Windows.Forms.DataGridView();
            this.Student_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_DateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.cmbReligion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCGPA = new System.Windows.Forms.TextBox();
            this.txtInstituteName = new System.Windows.Forms.TextBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbBoard = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbExamType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grdAcademicInfo = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBasicInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAcademicInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(676, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 27);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(161, 21);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(188, 20);
            this.txtRoll.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(161, 47);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(246, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 101);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(246, 67);
            this.txtAddress.TabIndex = 3;
            // 
            // dateofBirth
            // 
            this.dateofBirth.CustomFormat = "MM/dd/yyyy";
            this.dateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateofBirth.Location = new System.Drawing.Point(161, 73);
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Size = new System.Drawing.Size(113, 20);
            this.dateofBirth.TabIndex = 4;
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(582, 52);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(214, 21);
            this.cmbSemester.TabIndex = 6;
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(582, 86);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(214, 21);
            this.cmbDept.TabIndex = 7;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student_Roll :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student_Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student_DateofBirth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student_Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student_Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student_Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Student_Dept";
            // 
            // grdBasicInfo
            // 
            this.grdBasicInfo.AllowUserToAddRows = false;
            this.grdBasicInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdBasicInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBasicInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Id,
            this.Student_Roll,
            this.Student_Name,
            this.Student_DateofBirth,
            this.Student_Address,
            this.Student_Gender,
            this.Semester_Name,
            this.Department_Name,
            this.Student_Religion,
            this.Column1});
            this.grdBasicInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdBasicInfo.Location = new System.Drawing.Point(0, 397);
            this.grdBasicInfo.Name = "grdBasicInfo";
            this.grdBasicInfo.Size = new System.Drawing.Size(994, 166);
            this.grdBasicInfo.TabIndex = 15;
            this.grdBasicInfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Student_Id
            // 
            this.Student_Id.DataPropertyName = "Student_Id";
            this.Student_Id.HeaderText = "ID";
            this.Student_Id.Name = "Student_Id";
            this.Student_Id.Width = 50;
            // 
            // Student_Roll
            // 
            this.Student_Roll.DataPropertyName = "Student_Roll";
            this.Student_Roll.HeaderText = "Roll";
            this.Student_Roll.Name = "Student_Roll";
            this.Student_Roll.Width = 50;
            // 
            // Student_Name
            // 
            this.Student_Name.DataPropertyName = "Student_Name";
            this.Student_Name.HeaderText = "Name";
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Width = 200;
            // 
            // Student_DateofBirth
            // 
            this.Student_DateofBirth.DataPropertyName = "Student_DateofBirth";
            this.Student_DateofBirth.HeaderText = "DOB";
            this.Student_DateofBirth.Name = "Student_DateofBirth";
            this.Student_DateofBirth.Width = 80;
            // 
            // Student_Address
            // 
            this.Student_Address.DataPropertyName = "Student_Address";
            this.Student_Address.HeaderText = "Address";
            this.Student_Address.Name = "Student_Address";
            this.Student_Address.Width = 150;
            // 
            // Student_Gender
            // 
            this.Student_Gender.DataPropertyName = "Student_Gender";
            this.Student_Gender.HeaderText = "Gender";
            this.Student_Gender.Name = "Student_Gender";
            this.Student_Gender.Width = 50;
            // 
            // Semester_Name
            // 
            this.Semester_Name.DataPropertyName = "Semester_Name";
            this.Semester_Name.HeaderText = "Semester";
            this.Semester_Name.Name = "Semester_Name";
            this.Semester_Name.Width = 80;
            // 
            // Department_Name
            // 
            this.Department_Name.DataPropertyName = "Department_Name";
            this.Department_Name.HeaderText = "Department";
            this.Department_Name.Name = "Department_Name";
            this.Department_Name.Width = 70;
            // 
            // Student_Religion
            // 
            this.Student_Religion.DataPropertyName = "Student_Religion";
            this.Student_Religion.HeaderText = "Religion";
            this.Student_Religion.Name = "Student_Religion";
            this.Student_Religion.Width = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Student_Image";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "System.Drawing.Bitmap";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Image";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(582, 22);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 16;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(636, 22);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 17;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // cmbReligion
            // 
            this.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Items.AddRange(new object[] {
            "Islam",
            "Hindu",
            "Christain",
            "Bhuddo"});
            this.cmbReligion.Location = new System.Drawing.Point(582, 119);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(214, 21);
            this.cmbReligion.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Religion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(716, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search Someone";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(548, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 27);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(814, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(894, 160);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(37, 25);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(829, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Browse";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(420, 154);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 27);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRoll);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dateofBirth);
            this.groupBox1.Controls.Add(this.cmbSemester);
            this.groupBox1.Controls.Add(this.cmbDept);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbReligion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 189);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtCGPA);
            this.groupBox2.Controls.Add(this.txtInstituteName);
            this.groupBox2.Controls.Add(this.txtSession);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.cmbGrade);
            this.groupBox2.Controls.Add(this.cmbBoard);
            this.groupBox2.Controls.Add(this.cmbGroup);
            this.groupBox2.Controls.Add(this.cmbExamType);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(9, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 159);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Academic Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(205, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "Institute_Name";
            // 
            // label14
            // 
            this.label14.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(255, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Board";
            // 
            // txtCGPA
            // 
            this.txtCGPA.Location = new System.Drawing.Point(144, 81);
            this.txtCGPA.Name = "txtCGPA";
            this.txtCGPA.Size = new System.Drawing.Size(55, 20);
            this.txtCGPA.TabIndex = 5;
            // 
            // txtInstituteName
            // 
            this.txtInstituteName.Location = new System.Drawing.Point(311, 82);
            this.txtInstituteName.Multiline = true;
            this.txtInstituteName.Name = "txtInstituteName";
            this.txtInstituteName.Size = new System.Drawing.Size(222, 38);
            this.txtInstituteName.TabIndex = 5;
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(311, 27);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(222, 20);
            this.txtSession.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(366, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 27);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B",
            "B-",
            "C",
            "C-",
            "D",
            "I",
            "F"});
            this.cmbGrade.Location = new System.Drawing.Point(87, 81);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(51, 21);
            this.cmbGrade.TabIndex = 4;
            // 
            // cmbBoard
            // 
            this.cmbBoard.FormattingEnabled = true;
            this.cmbBoard.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Khulna",
            "Sylhet",
            "Dinajpur",
            "Rangpur",
            "Barishal",
            "Rajshahi"});
            this.cmbBoard.Location = new System.Drawing.Point(311, 54);
            this.cmbBoard.Name = "cmbBoard";
            this.cmbBoard.Size = new System.Drawing.Size(222, 21);
            this.cmbBoard.TabIndex = 4;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "Science",
            "Commerce"});
            this.cmbGroup.Location = new System.Drawing.Point(87, 54);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(112, 21);
            this.cmbGroup.TabIndex = 4;
            // 
            // cmbExamType
            // 
            this.cmbExamType.FormattingEnabled = true;
            this.cmbExamType.Items.AddRange(new object[] {
            "S.S.C",
            "H.S.C",
            "Diploma"});
            this.cmbExamType.Location = new System.Drawing.Point(87, 27);
            this.cmbExamType.Name = "cmbExamType";
            this.cmbExamType.Size = new System.Drawing.Size(112, 21);
            this.cmbExamType.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Grade/CGPA";
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Group";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(244, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Session";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Exam_Type";
            // 
            // grdAcademicInfo
            // 
            this.grdAcademicInfo.AllowUserToAddRows = false;
            this.grdAcademicInfo.AllowUserToDeleteRows = false;
            this.grdAcademicInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdAcademicInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAcademicInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grdAcademicInfo.Location = new System.Drawing.Point(571, 203);
            this.grdAcademicInfo.Name = "grdAcademicInfo";
            this.grdAcademicInfo.ReadOnly = true;
            this.grdAcademicInfo.Size = new System.Drawing.Size(393, 159);
            this.grdAcademicInfo.TabIndex = 8;
            this.grdAcademicInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdAcademicInfo_CellMouseDoubleClick);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Student_Roll";
            this.Column8.HeaderText = "S_Roll";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Exam_Type";
            this.Column2.HeaderText = "ExamType";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Group_Major";
            this.Column3.HeaderText = "Group";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CGPA";
            this.Column4.HeaderText = "CGPA";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Session";
            this.Column5.HeaderText = "Session";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Board";
            this.Column6.HeaderText = "Board";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Institute_Name";
            this.Column7.HeaderText = "Inst_Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // StudentInformation
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 563);
            this.Controls.Add(this.grdAcademicInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdBasicInfo);
            this.Name = "StudentInformation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInformation";
            this.Load += new System.EventHandler(this.StudentInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBasicInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAcademicInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdBasicInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCGPA;
        private System.Windows.Forms.TextBox txtInstituteName;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbExamType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grdAcademicInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbBoard;
        public System.Windows.Forms.TextBox txtRoll;
        public System.Windows.Forms.TextBox txtFullName;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.DateTimePicker dateofBirth;
        public System.Windows.Forms.ComboBox cmbSemester;
        public System.Windows.Forms.ComboBox cmbDept;
        public System.Windows.Forms.RadioButton rdbMale;
        public System.Windows.Forms.RadioButton rdbFemale;
        public System.Windows.Forms.ComboBox cmbReligion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_DateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Religion;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

