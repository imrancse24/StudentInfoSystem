namespace Student_Information
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.courseRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.semesterToolStripMenuItem,
            this.courseSetupToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.courseRegistrationToolStripMenuItem,
            this.accountSectionToolStripMenuItem,
            this.resultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // semesterToolStripMenuItem
            // 
            this.semesterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterToolStripMenuItem.Name = "semesterToolStripMenuItem";
            this.semesterToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.semesterToolStripMenuItem.Text = "Semester";
            this.semesterToolStripMenuItem.Click += new System.EventHandler(this.semesterToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(166, 25);
            this.studentToolStripMenuItem.Text = "Student Admission";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Location = new System.Drawing.Point(1282, -1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "SignOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // courseRegistrationToolStripMenuItem
            // 
            this.courseRegistrationToolStripMenuItem.Name = "courseRegistrationToolStripMenuItem";
            this.courseRegistrationToolStripMenuItem.Size = new System.Drawing.Size(171, 25);
            this.courseRegistrationToolStripMenuItem.Text = "Course Registration";
            this.courseRegistrationToolStripMenuItem.Click += new System.EventHandler(this.courseRegistrationToolStripMenuItem_Click);
            // 
            // accountSectionToolStripMenuItem
            // 
            this.accountSectionToolStripMenuItem.Name = "accountSectionToolStripMenuItem";
            this.accountSectionToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.accountSectionToolStripMenuItem.Text = "Account Section";
            this.accountSectionToolStripMenuItem.Click += new System.EventHandler(this.accountSectionToolStripMenuItem_Click);
            // 
            // courseSetupToolStripMenuItem
            // 
            this.courseSetupToolStripMenuItem.Name = "courseSetupToolStripMenuItem";
            this.courseSetupToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.courseSetupToolStripMenuItem.Text = "Course Setup";
            this.courseSetupToolStripMenuItem.Click += new System.EventHandler(this.courseSetupToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.resultsToolStripMenuItem.Text = "Results";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem courseSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
    }
}