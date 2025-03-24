namespace ProjectEFCore.Presention
{
    partial class Form1 
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
            pcBox = new PictureBox();
            label1 = new Label();
            btnStudent = new Button();
            btncourse = new Button();
            btnSt_Crs = new Button();
            btnIns = new Button();
            btnDept = new Button();
            btnCr_Sess = new Button();
            btnCr_Sess_Att = new Button();
            labUser = new Label();
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            button1 = new Button();
            back = new Button();
            cros_Stuf3 = new Cros_StuF();
            coursf1 = new CoursF();
            cros_Sessionf1 = new Cros_SessionF();
            crs_Session_Attf1 = new Crs_Session_AttF();
            departmentf1 = new DepartmentF();
            instructorf1 = new InstructorF();
            userControl11 = new UserControl1();
            studentf1 = new StudentF();
            ((System.ComponentModel.ISupportInitialize)pcBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            SuspendLayout();
            // 
            // pcBox
            // 
            pcBox.BackColor = SystemColors.ActiveCaption;
            pcBox.Location = new Point(12, 19);
            pcBox.Margin = new Padding(3, 2, 3, 2);
            pcBox.Name = "pcBox";
            pcBox.Size = new Size(121, 116);
            pcBox.SizeMode = PictureBoxSizeMode.Zoom;
            pcBox.TabIndex = 1;
            pcBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 45F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(289, 5);
            label1.Name = "label1";
            label1.Size = new Size(605, 92);
            label1.TabIndex = 2;
            label1.Text = "Management System";
            // 
            // btnStudent
            // 
            btnStudent.BackColor = SystemColors.ActiveCaption;
            btnStudent.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudent.ForeColor = Color.Navy;
            btnStudent.Location = new Point(12, 168);
            btnStudent.Margin = new Padding(3, 2, 3, 2);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(149, 39);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btncourse
            // 
            btncourse.BackColor = SystemColors.ActiveCaption;
            btncourse.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncourse.ForeColor = Color.Navy;
            btncourse.Location = new Point(12, 229);
            btncourse.Margin = new Padding(3, 2, 3, 2);
            btncourse.Name = "btncourse";
            btncourse.Size = new Size(149, 40);
            btncourse.TabIndex = 4;
            btncourse.Text = "Course";
            btncourse.UseVisualStyleBackColor = false;
            btncourse.Click += btncourse_Click;
            // 
            // btnSt_Crs
            // 
            btnSt_Crs.BackColor = SystemColors.ActiveCaption;
            btnSt_Crs.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSt_Crs.ForeColor = Color.Navy;
            btnSt_Crs.Location = new Point(12, 295);
            btnSt_Crs.Margin = new Padding(3, 2, 3, 2);
            btnSt_Crs.Name = "btnSt_Crs";
            btnSt_Crs.Size = new Size(149, 41);
            btnSt_Crs.TabIndex = 5;
            btnSt_Crs.Text = "Student_course";
            btnSt_Crs.UseVisualStyleBackColor = false;
            btnSt_Crs.Click += btnSt_Crs_Click;
            // 
            // btnIns
            // 
            btnIns.BackColor = SystemColors.ActiveCaption;
            btnIns.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIns.ForeColor = Color.Navy;
            btnIns.Location = new Point(12, 364);
            btnIns.Margin = new Padding(3, 2, 3, 2);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(149, 41);
            btnIns.TabIndex = 6;
            btnIns.Text = "Instructor";
            btnIns.UseVisualStyleBackColor = false;
            btnIns.Click += btnIns_Click;
            // 
            // btnDept
            // 
            btnDept.BackColor = SystemColors.ActiveCaption;
            btnDept.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDept.ForeColor = Color.Navy;
            btnDept.Location = new Point(12, 429);
            btnDept.Margin = new Padding(3, 2, 3, 2);
            btnDept.Name = "btnDept";
            btnDept.Size = new Size(149, 40);
            btnDept.TabIndex = 7;
            btnDept.Text = "Department";
            btnDept.UseVisualStyleBackColor = false;
            btnDept.Click += btnDept_Click;
            // 
            // btnCr_Sess
            // 
            btnCr_Sess.BackColor = SystemColors.ActiveCaption;
            btnCr_Sess.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCr_Sess.ForeColor = Color.Navy;
            btnCr_Sess.Location = new Point(12, 501);
            btnCr_Sess.Margin = new Padding(3, 2, 3, 2);
            btnCr_Sess.Name = "btnCr_Sess";
            btnCr_Sess.Size = new Size(149, 40);
            btnCr_Sess.TabIndex = 8;
            btnCr_Sess.Text = "Cor_Session";
            btnCr_Sess.UseVisualStyleBackColor = false;
            btnCr_Sess.Click += btnCr_Sess_Click;
            // 
            // btnCr_Sess_Att
            // 
            btnCr_Sess_Att.BackColor = SystemColors.ActiveCaption;
            btnCr_Sess_Att.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCr_Sess_Att.ForeColor = Color.Navy;
            btnCr_Sess_Att.Location = new Point(12, 577);
            btnCr_Sess_Att.Margin = new Padding(3, 2, 3, 2);
            btnCr_Sess_Att.Name = "btnCr_Sess_Att";
            btnCr_Sess_Att.Size = new Size(149, 40);
            btnCr_Sess_Att.TabIndex = 9;
            btnCr_Sess_Att.Text = "Cor_Session_attendace";
            btnCr_Sess_Att.UseVisualStyleBackColor = false;
            btnCr_Sess_Att.Click += btnCr_Sess_Att_Click;
            // 
            // labUser
            // 
            labUser.AutoSize = true;
            labUser.BackColor = SystemColors.ActiveCaption;
            labUser.Font = new Font("Monotype Corsiva", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labUser.ForeColor = Color.Navy;
            labUser.Location = new Point(151, 19);
            labUser.Name = "labUser";
            labUser.Size = new Size(0, 41);
            labUser.TabIndex = 24;
            // 
            // stackPanel1
            // 
            stackPanel1.Location = new Point(941, 38);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(8, 8);
            stackPanel1.TabIndex = 26;
            stackPanel1.UseSkinIndents = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(12, 643);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(149, 40);
            button1.TabIndex = 35;
            button1.Text = "Users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // back
            // 
            back.BackColor = Color.SlateGray;
            back.Font = new Font("Mistral", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back.ForeColor = Color.Navy;
            back.Location = new Point(1185, 768);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(149, 40);
            back.TabIndex = 36;
            back.Text = "Back➡️";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // cros_Stuf3
            // 
            cros_Stuf3.BackColor = Color.FromArgb(0, 0, 64);
            cros_Stuf3.Location = new Point(167, 128);
            cros_Stuf3.Margin = new Padding(3, 4, 3, 4);
            cros_Stuf3.Name = "cros_Stuf3";
            cros_Stuf3.Size = new Size(1157, 634);
            cros_Stuf3.TabIndex = 37;
            // 
            // coursf1
            // 
            coursf1.BackColor = Color.FromArgb(0, 0, 64);
            coursf1.Location = new Point(206, 116);
            coursf1.Margin = new Padding(3, 4, 3, 4);
            coursf1.Name = "coursf1";
            coursf1.Size = new Size(1128, 646);
            coursf1.TabIndex = 38;
            // 
            // cros_Sessionf1
            // 
            cros_Sessionf1.BackColor = Color.FromArgb(0, 0, 64);
            cros_Sessionf1.Location = new Point(186, 121);
            cros_Sessionf1.Margin = new Padding(3, 4, 3, 4);
            cros_Sessionf1.Name = "cros_Sessionf1";
            cros_Sessionf1.Size = new Size(1148, 641);
            cros_Sessionf1.TabIndex = 39;
            // 
            // crs_Session_Attf1
            // 
            crs_Session_Attf1.BackColor = Color.FromArgb(0, 0, 64);
            crs_Session_Attf1.Location = new Point(186, 121);
            crs_Session_Attf1.Margin = new Padding(3, 4, 3, 4);
            crs_Session_Attf1.Name = "crs_Session_Attf1";
            crs_Session_Attf1.Size = new Size(1152, 633);
            crs_Session_Attf1.TabIndex = 40;
            // 
            // departmentf1
            // 
            departmentf1.BackColor = Color.FromArgb(0, 0, 64);
            departmentf1.Location = new Point(186, 151);
            departmentf1.Margin = new Padding(3, 4, 3, 4);
            departmentf1.Name = "departmentf1";
            departmentf1.Size = new Size(1148, 611);
            departmentf1.TabIndex = 41;
            // 
            // instructorf1
            // 
            instructorf1.BackColor = Color.FromArgb(0, 0, 64);
            instructorf1.Location = new Point(185, 116);
            instructorf1.Margin = new Padding(3, 4, 3, 4);
            instructorf1.Name = "instructorf1";
            instructorf1.Size = new Size(1149, 638);
            instructorf1.TabIndex = 42;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.FromArgb(0, 0, 64);
            userControl11.Location = new Point(167, 151);
            userControl11.Margin = new Padding(3, 4, 3, 4);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(1157, 584);
            userControl11.TabIndex = 43;
            // 
            // studentf1
            // 
            studentf1.BackColor = Color.FromArgb(0, 0, 64);
            studentf1.Location = new Point(206, 151);
            studentf1.Margin = new Padding(3, 4, 3, 4);
            studentf1.Name = "studentf1";
            studentf1.Size = new Size(1128, 618);
            studentf1.TabIndex = 44;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1346, 809);
            Controls.Add(studentf1);
            Controls.Add(userControl11);
            Controls.Add(instructorf1);
            Controls.Add(departmentf1);
            Controls.Add(crs_Session_Attf1);
            Controls.Add(cros_Sessionf1);
            Controls.Add(coursf1);
            Controls.Add(cros_Stuf3);
            Controls.Add(back);
            Controls.Add(button1);
            Controls.Add(stackPanel1);
            Controls.Add(labUser);
            Controls.Add(btnCr_Sess_Att);
            Controls.Add(btnCr_Sess);
            Controls.Add(btnDept);
            Controls.Add(btnIns);
            Controls.Add(btnSt_Crs);
            Controls.Add(btncourse);
            Controls.Add(btnStudent);
            Controls.Add(label1);
            Controls.Add(pcBox);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Show Data";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcBox;
        private Label label1;
        private Button btnStudent;
        private Button btncourse;
        private Button btnSt_Crs;
        private Button btnIns;
        private Button btnDept;
        private Button btnCr_Sess;
        private Button btnCr_Sess_Att;
        private Label labUser;
        private StudentF studentf1;
        private CoursF coursf1;
        private DepartmentF departmentf1;
        private Cros_StuF cros_Stuf1;
        private InstructorF instructorf1;
        private Crs_Session_AttF crs_Session_Attf1;
        private StudentF studentf2;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private InstructorF instructorf2;
        private StudentF studentf3;
        private InstructorF instructorf3;
        private Cros_SessionF cros_Sessionf1;
        private Cros_StuF cros_Stuf2;
        private CoursF coursf2;
        private DepartmentF departmentf2;
        private StudentF studentf4;
        private UserControl1 userControl11;
        private Button button1;
        private UserControl1 userControl12;
        private Button back;
        private Cros_StuF cros_Stuf3;
    }
}
