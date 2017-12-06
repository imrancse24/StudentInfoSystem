namespace Student_Information
{
    partial class Search_Student
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgbSearch = new System.Windows.Forms.DataGridView();
            this.Student_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_DateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnStudentprofile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(203, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(475, 26);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(72, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgbSearch
            // 
            this.dgbSearch.AllowUserToAddRows = false;
            this.dgbSearch.AllowUserToDeleteRows = false;
            this.dgbSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Id,
            this.Student_Roll,
            this.Student_Name,
            this.Student_DateofBirth,
            this.Student_Address,
            this.Student_Gender,
            this.Semester_Name,
            this.Department_Name,
            this.Student_Religion,
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgbSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgbSearch.Location = new System.Drawing.Point(0, 57);
            this.dgbSearch.Name = "dgbSearch";
            this.dgbSearch.ReadOnly = true;
            this.dgbSearch.Size = new System.Drawing.Size(1079, 593);
            this.dgbSearch.TabIndex = 2;
            this.dgbSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgbSearch_CellMouseDoubleClick);
            // 
            // Student_Id
            // 
            this.Student_Id.DataPropertyName = "Student_Id";
            this.Student_Id.HeaderText = "Id";
            this.Student_Id.Name = "Student_Id";
            this.Student_Id.ReadOnly = true;
            this.Student_Id.Width = 20;
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
            this.Student_DateofBirth.HeaderText = "DOB";
            this.Student_DateofBirth.Name = "Student_DateofBirth";
            this.Student_DateofBirth.ReadOnly = true;
            this.Student_DateofBirth.Width = 50;
            // 
            // Student_Address
            // 
            this.Student_Address.DataPropertyName = "Student_Address";
            this.Student_Address.HeaderText = "Address";
            this.Student_Address.Name = "Student_Address";
            this.Student_Address.ReadOnly = true;
            // 
            // Student_Gender
            // 
            this.Student_Gender.DataPropertyName = "Student_Gender";
            this.Student_Gender.HeaderText = "Gender";
            this.Student_Gender.Name = "Student_Gender";
            this.Student_Gender.ReadOnly = true;
            this.Student_Gender.Width = 50;
            // 
            // Semester_Name
            // 
            this.Semester_Name.DataPropertyName = "Semester_Name";
            this.Semester_Name.HeaderText = "Semester";
            this.Semester_Name.Name = "Semester_Name";
            this.Semester_Name.ReadOnly = true;
            this.Semester_Name.Width = 50;
            // 
            // Department_Name
            // 
            this.Department_Name.DataPropertyName = "Department_Name";
            this.Department_Name.HeaderText = "Department";
            this.Department_Name.Name = "Department_Name";
            this.Department_Name.ReadOnly = true;
            this.Department_Name.Width = 50;
            // 
            // Student_Religion
            // 
            this.Student_Religion.DataPropertyName = "Student_Religion";
            this.Student_Religion.HeaderText = "Religion";
            this.Student_Religion.Name = "Student_Religion";
            this.Student_Religion.ReadOnly = true;
            this.Student_Religion.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Exam_Type";
            this.Column1.HeaderText = "Exam_Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Session";
            this.Column2.HeaderText = "Session";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Group_Major";
            this.Column6.HeaderText = "Group";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Grade";
            this.Column7.HeaderText = "Grade";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CGPA";
            this.Column3.HeaderText = "CGPA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Board";
            this.Column4.HeaderText = "Board";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Institute_Name";
            this.Column5.HeaderText = "Institute_Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Location = new System.Drawing.Point(701, 11);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(159, 28);
            this.btnPrintPreview.TabIndex = 3;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnStudentprofile
            // 
            this.btnStudentprofile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStudentprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentprofile.Location = new System.Drawing.Point(881, 11);
            this.btnStudentprofile.Name = "btnStudentprofile";
            this.btnStudentprofile.Size = new System.Drawing.Size(136, 28);
            this.btnStudentprofile.TabIndex = 4;
            this.btnStudentprofile.Text = "Print Profile";
            this.btnStudentprofile.UseVisualStyleBackColor = false;
            this.btnStudentprofile.Click += new System.EventHandler(this.btnStudentprofile_Click);
            // 
            // Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1079, 650);
            this.Controls.Add(this.btnStudentprofile);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.dgbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "Search_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Student";
            this.Load += new System.EventHandler(this.Search_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgbSearch;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_DateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnStudentprofile;
    }
}