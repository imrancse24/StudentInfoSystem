namespace Student_Information
{
    partial class AccountSection
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
            this.txtStdRoll = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbFullName = new System.Windows.Forms.ComboBox();
            this.Session = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgb_Accounts = new System.Windows.Forms.DataGridView();
            this.Course_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit_Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TotalCredit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_TotalFee = new System.Windows.Forms.Label();
            this.lbl_Due = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Redue = new System.Windows.Forms.Label();
            this.Student_Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Roll";
            // 
            // txtStdRoll
            // 
            this.txtStdRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdRoll.Location = new System.Drawing.Point(105, 22);
            this.txtStdRoll.Name = "txtStdRoll";
            this.txtStdRoll.Size = new System.Drawing.Size(229, 20);
            this.txtStdRoll.TabIndex = 1;
            this.txtStdRoll.TextChanged += new System.EventHandler(this.txtStdRoll_TextChanged);
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(105, 116);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(229, 21);
            this.cmbDept.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dept.";
            // 
            // cmbSemester
            // 
            this.cmbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "Fall",
            "Summer",
            "Spring"});
            this.cmbSemester.Location = new System.Drawing.Point(105, 163);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(229, 21);
            this.cmbSemester.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Semester";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.cmbFullName);
            this.groupBox1.Controls.Add(this.cmbDept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Session);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSession);
            this.groupBox1.Controls.Add(this.cmbSemester);
            this.groupBox1.Controls.Add(this.txtStdRoll);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 261);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(259, 228);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbFullName
            // 
            this.cmbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFullName.FormattingEnabled = true;
            this.cmbFullName.Location = new System.Drawing.Point(105, 70);
            this.cmbFullName.Name = "cmbFullName";
            this.cmbFullName.Size = new System.Drawing.Size(229, 21);
            this.cmbFullName.TabIndex = 2;
            // 
            // Session
            // 
            this.Session.AutoSize = true;
            this.Session.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Session.Location = new System.Drawing.Point(26, 205);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(51, 13);
            this.Session.TabIndex = 0;
            this.Session.Text = "Session";
            // 
            // txtSession
            // 
            this.txtSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSession.Location = new System.Drawing.Point(105, 202);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(229, 20);
            this.txtSession.TabIndex = 1;
            this.txtSession.TextChanged += new System.EventHandler(this.txtStdRoll_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Name";
            // 
            // dgb_Accounts
            // 
            this.dgb_Accounts.AllowUserToAddRows = false;
            this.dgb_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course_Code,
            this.Course_Name,
            this.Credit_Hour});
            this.dgb_Accounts.Location = new System.Drawing.Point(369, 12);
            this.dgb_Accounts.Name = "dgb_Accounts";
            this.dgb_Accounts.Size = new System.Drawing.Size(407, 155);
            this.dgb_Accounts.TabIndex = 5;
            this.dgb_Accounts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_Accounts_CellEndEdit);
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
            this.Course_Name.Width = 160;
            // 
            // Credit_Hour
            // 
            this.Credit_Hour.DataPropertyName = "Credit_Hour";
            this.Credit_Hour.HeaderText = "Credit_Hour";
            this.Credit_Hour.Name = "Credit_Hour";
            // 
            // lbl_TotalCredit
            // 
            this.lbl_TotalCredit.AutoSize = true;
            this.lbl_TotalCredit.Location = new System.Drawing.Point(455, 202);
            this.lbl_TotalCredit.Name = "lbl_TotalCredit";
            this.lbl_TotalCredit.Size = new System.Drawing.Size(0, 13);
            this.lbl_TotalCredit.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Credit = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Per Credit Fee = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_TotalFee
            // 
            this.lbl_TotalFee.AutoSize = true;
            this.lbl_TotalFee.Location = new System.Drawing.Point(618, 195);
            this.lbl_TotalFee.Name = "lbl_TotalFee";
            this.lbl_TotalFee.Size = new System.Drawing.Size(0, 13);
            this.lbl_TotalFee.TabIndex = 10;
            // 
            // lbl_Due
            // 
            this.lbl_Due.AutoSize = true;
            this.lbl_Due.Location = new System.Drawing.Point(618, 239);
            this.lbl_Due.Name = "lbl_Due";
            this.lbl_Due.Size = new System.Drawing.Size(0, 13);
            this.lbl_Due.TabIndex = 12;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(744, 214);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(71, 20);
            this.txtPaid.TabIndex = 13;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Fee = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Due = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Paid = ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(740, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(433, 290);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(537, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(628, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Roll,
            this.Dept,
            this.Semester,
            this.Column3,
            this.Total_Credit,
            this.Total_Fee,
            this.Total_due});
            this.dataGridView1.Location = new System.Drawing.Point(12, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(924, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // lbl_Redue
            // 
            this.lbl_Redue.AutoSize = true;
            this.lbl_Redue.Location = new System.Drawing.Point(618, 239);
            this.lbl_Redue.Name = "lbl_Redue";
            this.lbl_Redue.Size = new System.Drawing.Size(0, 13);
            this.lbl_Redue.TabIndex = 18;
            // 
            // Student_Roll
            // 
            this.Student_Roll.DataPropertyName = "Student_Roll";
            this.Student_Roll.HeaderText = "Student_Roll";
            this.Student_Roll.Name = "Student_Roll";
            this.Student_Roll.ReadOnly = true;
            // 
            // Dept
            // 
            this.Dept.DataPropertyName = "Dept";
            this.Dept.HeaderText = "Dept";
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Session";
            this.Column3.HeaderText = "Session";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Total_Credit
            // 
            this.Total_Credit.DataPropertyName = "Total_Credit";
            this.Total_Credit.HeaderText = "Total_Credit";
            this.Total_Credit.Name = "Total_Credit";
            this.Total_Credit.ReadOnly = true;
            // 
            // Total_Fee
            // 
            this.Total_Fee.DataPropertyName = "Total_Fee";
            this.Total_Fee.HeaderText = "Total_Fee";
            this.Total_Fee.Name = "Total_Fee";
            this.Total_Fee.ReadOnly = true;
            // 
            // Total_due
            // 
            this.Total_due.DataPropertyName = "Total_due";
            this.Total_due.HeaderText = "Total_due";
            this.Total_due.Name = "Total_due";
            this.Total_due.ReadOnly = true;
            // 
            // AccountSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 513);
            this.Controls.Add(this.lbl_Redue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.lbl_Due);
            this.Controls.Add(this.lbl_TotalFee);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_TotalCredit);
            this.Controls.Add(this.dgb_Accounts);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountSection";
            this.Load += new System.EventHandler(this.AccountSection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStdRoll;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label Session;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.DataGridView dgb_Accounts;
        private System.Windows.Forms.Label lbl_TotalCredit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_TotalFee;
        private System.Windows.Forms.Label lbl_Due;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit_Hour;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Redue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_due;
    }
}