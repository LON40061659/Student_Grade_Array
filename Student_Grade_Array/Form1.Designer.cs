namespace Student_Grade_Array
{
    partial class frmStudentGrades
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
            this.tbInformation = new System.Windows.Forms.TabControl();
            this.tbStudentDetails = new System.Windows.Forms.TabPage();
            this.tbGrades = new System.Windows.Forms.TabPage();
            this.tbResults = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.lblStudentMarks = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblStudent_Number = new System.Windows.Forms.Label();
            this.txtSearchNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStudent_Marks = new System.Windows.Forms.Label();
            this.lblStudent_Name = new System.Windows.Forms.Label();
            this.lbl_Student_Number = new System.Windows.Forms.Label();
            this.lbl_Group = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lbl_Student_Marks = new System.Windows.Forms.Label();
            this.lbl_English = new System.Windows.Forms.Label();
            this.lbl_Maths = new System.Windows.Forms.Label();
            this.lbl_Science = new System.Windows.Forms.Label();
            this.txtEnglishMark = new System.Windows.Forms.TextBox();
            this.txtMathsMark = new System.Windows.Forms.TextBox();
            this.txtScienceMark = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblStudentDetails = new System.Windows.Forms.Label();
            this.lblAverageMark = new System.Windows.Forms.Label();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbl_StudentDetails = new System.Windows.Forms.Label();
            this.lbl_AverageMark = new System.Windows.Forms.Label();
            this.lbl_StudentGrade = new System.Windows.Forms.Label();
            this.tbInformation.SuspendLayout();
            this.tbStudentDetails.SuspendLayout();
            this.tbGrades.SuspendLayout();
            this.tbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInformation
            // 
            this.tbInformation.Controls.Add(this.tbStudentDetails);
            this.tbInformation.Controls.Add(this.tbGrades);
            this.tbInformation.Controls.Add(this.tbResults);
            this.tbInformation.Location = new System.Drawing.Point(27, 114);
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.SelectedIndex = 0;
            this.tbInformation.Size = new System.Drawing.Size(741, 344);
            this.tbInformation.TabIndex = 0;
            // 
            // tbStudentDetails
            // 
            this.tbStudentDetails.Controls.Add(this.btnEnter);
            this.tbStudentDetails.Controls.Add(this.txtScience);
            this.tbStudentDetails.Controls.Add(this.txtMaths);
            this.tbStudentDetails.Controls.Add(this.txtEnglish);
            this.tbStudentDetails.Controls.Add(this.lblScience);
            this.tbStudentDetails.Controls.Add(this.lblMaths);
            this.tbStudentDetails.Controls.Add(this.lblEnglish);
            this.tbStudentDetails.Controls.Add(this.lblStudentMarks);
            this.tbStudentDetails.Controls.Add(this.cboGroup);
            this.tbStudentDetails.Controls.Add(this.txtStudentNumber);
            this.tbStudentDetails.Controls.Add(this.txtStudentName);
            this.tbStudentDetails.Controls.Add(this.lblGroup);
            this.tbStudentDetails.Controls.Add(this.lblStudentNumber);
            this.tbStudentDetails.Controls.Add(this.lblStudentName);
            this.tbStudentDetails.Controls.Add(this.lblInstructions);
            this.tbStudentDetails.Location = new System.Drawing.Point(4, 22);
            this.tbStudentDetails.Name = "tbStudentDetails";
            this.tbStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentDetails.Size = new System.Drawing.Size(733, 318);
            this.tbStudentDetails.TabIndex = 0;
            this.tbStudentDetails.Text = "Student Details";
            this.tbStudentDetails.UseVisualStyleBackColor = true;
            // 
            // tbGrades
            // 
            this.tbGrades.Controls.Add(this.txtScienceMark);
            this.tbGrades.Controls.Add(this.txtMathsMark);
            this.tbGrades.Controls.Add(this.txtEnglishMark);
            this.tbGrades.Controls.Add(this.lbl_Science);
            this.tbGrades.Controls.Add(this.lbl_Maths);
            this.tbGrades.Controls.Add(this.lbl_English);
            this.tbGrades.Controls.Add(this.lbl_Student_Marks);
            this.tbGrades.Controls.Add(this.txtGroup);
            this.tbGrades.Controls.Add(this.txtNumber);
            this.tbGrades.Controls.Add(this.txtName);
            this.tbGrades.Controls.Add(this.lbl_Group);
            this.tbGrades.Controls.Add(this.lbl_Student_Number);
            this.tbGrades.Controls.Add(this.lblStudent_Name);
            this.tbGrades.Controls.Add(this.lblStudent_Marks);
            this.tbGrades.Controls.Add(this.btnSearch);
            this.tbGrades.Controls.Add(this.txtSearchNumber);
            this.tbGrades.Controls.Add(this.lblStudent_Number);
            this.tbGrades.Location = new System.Drawing.Point(4, 22);
            this.tbGrades.Name = "tbGrades";
            this.tbGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tbGrades.Size = new System.Drawing.Size(733, 318);
            this.tbGrades.TabIndex = 1;
            this.tbGrades.Text = "Grades";
            this.tbGrades.UseVisualStyleBackColor = true;
            // 
            // tbResults
            // 
            this.tbResults.Controls.Add(this.lbl_StudentGrade);
            this.tbResults.Controls.Add(this.lbl_AverageMark);
            this.tbResults.Controls.Add(this.lbl_StudentDetails);
            this.tbResults.Controls.Add(this.btnCalculate);
            this.tbResults.Controls.Add(this.btnClear);
            this.tbResults.Controls.Add(this.lblStudentGrade);
            this.tbResults.Controls.Add(this.lblAverageMark);
            this.tbResults.Controls.Add(this.lblStudentDetails);
            this.tbResults.Controls.Add(this.lblResults);
            this.tbResults.Location = new System.Drawing.Point(4, 22);
            this.tbResults.Name = "tbResults";
            this.tbResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbResults.Size = new System.Drawing.Size(733, 318);
            this.tbResults.TabIndex = 2;
            this.tbResults.Text = "Results";
            this.tbResults.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Student Grades";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(16, 21);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(183, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please enter the student marks";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(16, 63);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(16, 93);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNumber.TabIndex = 2;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(19, 125);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 3;
            this.lblGroup.Text = "Group";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(130, 63);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(157, 20);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(130, 93);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(157, 20);
            this.txtStudentNumber.TabIndex = 5;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Items.AddRange(new object[] {
            "DPD1A",
            "DPD1B",
            "BMD1A",
            "BMD1B"});
            this.cboGroup.Location = new System.Drawing.Point(130, 125);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(157, 21);
            this.cboGroup.TabIndex = 6;
            // 
            // lblStudentMarks
            // 
            this.lblStudentMarks.AutoSize = true;
            this.lblStudentMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentMarks.Location = new System.Drawing.Point(425, 21);
            this.lblStudentMarks.Name = "lblStudentMarks";
            this.lblStudentMarks.Size = new System.Drawing.Size(183, 13);
            this.lblStudentMarks.TabIndex = 7;
            this.lblStudentMarks.Text = "Please enter the student marks";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(428, 63);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(41, 13);
            this.lblEnglish.TabIndex = 8;
            this.lblEnglish.Text = "English";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(428, 93);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(36, 13);
            this.lblMaths.TabIndex = 9;
            this.lblMaths.Text = "Maths";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Location = new System.Drawing.Point(428, 125);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(46, 13);
            this.lblScience.TabIndex = 10;
            this.lblScience.Text = "Science";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(489, 63);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 20);
            this.txtEnglish.TabIndex = 11;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(489, 93);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(100, 20);
            this.txtMaths.TabIndex = 12;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(489, 125);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(100, 20);
            this.txtScience.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(645, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(598, 270);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(91, 28);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblStudent_Number
            // 
            this.lblStudent_Number.AutoSize = true;
            this.lblStudent_Number.Location = new System.Drawing.Point(23, 25);
            this.lblStudent_Number.Name = "lblStudent_Number";
            this.lblStudent_Number.Size = new System.Drawing.Size(84, 13);
            this.lblStudent_Number.TabIndex = 0;
            this.lblStudent_Number.Text = "Student Number";
            // 
            // txtSearchNumber
            // 
            this.txtSearchNumber.Location = new System.Drawing.Point(136, 23);
            this.txtSearchNumber.Name = "txtSearchNumber";
            this.txtSearchNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNumber.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(275, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStudent_Marks
            // 
            this.lblStudent_Marks.AutoSize = true;
            this.lblStudent_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent_Marks.Location = new System.Drawing.Point(23, 94);
            this.lblStudent_Marks.Name = "lblStudent_Marks";
            this.lblStudent_Marks.Size = new System.Drawing.Size(89, 13);
            this.lblStudent_Marks.TabIndex = 3;
            this.lblStudent_Marks.Text = "Student Marks";
            // 
            // lblStudent_Name
            // 
            this.lblStudent_Name.AutoSize = true;
            this.lblStudent_Name.Location = new System.Drawing.Point(69, 137);
            this.lblStudent_Name.Name = "lblStudent_Name";
            this.lblStudent_Name.Size = new System.Drawing.Size(75, 13);
            this.lblStudent_Name.TabIndex = 4;
            this.lblStudent_Name.Text = "Student Name";
            // 
            // lbl_Student_Number
            // 
            this.lbl_Student_Number.AutoSize = true;
            this.lbl_Student_Number.Location = new System.Drawing.Point(69, 174);
            this.lbl_Student_Number.Name = "lbl_Student_Number";
            this.lbl_Student_Number.Size = new System.Drawing.Size(84, 13);
            this.lbl_Student_Number.TabIndex = 5;
            this.lbl_Student_Number.Text = "Student Number";
            // 
            // lbl_Group
            // 
            this.lbl_Group.AutoSize = true;
            this.lbl_Group.Location = new System.Drawing.Point(71, 214);
            this.lbl_Group.Name = "lbl_Group";
            this.lbl_Group.Size = new System.Drawing.Size(36, 13);
            this.lbl_Group.TabIndex = 6;
            this.lbl_Group.Text = "Group";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(189, 174);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(189, 214);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(100, 20);
            this.txtGroup.TabIndex = 9;
            // 
            // lbl_Student_Marks
            // 
            this.lbl_Student_Marks.AutoSize = true;
            this.lbl_Student_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Marks.Location = new System.Drawing.Point(380, 94);
            this.lbl_Student_Marks.Name = "lbl_Student_Marks";
            this.lbl_Student_Marks.Size = new System.Drawing.Size(89, 13);
            this.lbl_Student_Marks.TabIndex = 10;
            this.lbl_Student_Marks.Text = "Student Marks";
            // 
            // lbl_English
            // 
            this.lbl_English.AutoSize = true;
            this.lbl_English.Location = new System.Drawing.Point(420, 137);
            this.lbl_English.Name = "lbl_English";
            this.lbl_English.Size = new System.Drawing.Size(41, 13);
            this.lbl_English.TabIndex = 11;
            this.lbl_English.Text = "English";
            // 
            // lbl_Maths
            // 
            this.lbl_Maths.AutoSize = true;
            this.lbl_Maths.Location = new System.Drawing.Point(423, 174);
            this.lbl_Maths.Name = "lbl_Maths";
            this.lbl_Maths.Size = new System.Drawing.Size(36, 13);
            this.lbl_Maths.TabIndex = 12;
            this.lbl_Maths.Text = "Maths";
            // 
            // lbl_Science
            // 
            this.lbl_Science.AutoSize = true;
            this.lbl_Science.Location = new System.Drawing.Point(423, 214);
            this.lbl_Science.Name = "lbl_Science";
            this.lbl_Science.Size = new System.Drawing.Size(46, 13);
            this.lbl_Science.TabIndex = 13;
            this.lbl_Science.Text = "Science";
            // 
            // txtEnglishMark
            // 
            this.txtEnglishMark.Location = new System.Drawing.Point(517, 137);
            this.txtEnglishMark.Name = "txtEnglishMark";
            this.txtEnglishMark.Size = new System.Drawing.Size(100, 20);
            this.txtEnglishMark.TabIndex = 14;
            // 
            // txtMathsMark
            // 
            this.txtMathsMark.Location = new System.Drawing.Point(517, 174);
            this.txtMathsMark.Name = "txtMathsMark";
            this.txtMathsMark.Size = new System.Drawing.Size(100, 20);
            this.txtMathsMark.TabIndex = 15;
            // 
            // txtScienceMark
            // 
            this.txtScienceMark.Location = new System.Drawing.Point(517, 214);
            this.txtScienceMark.Name = "txtScienceMark";
            this.txtScienceMark.Size = new System.Drawing.Size(100, 20);
            this.txtScienceMark.TabIndex = 16;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(27, 27);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "Results";
            // 
            // lblStudentDetails
            // 
            this.lblStudentDetails.AutoSize = true;
            this.lblStudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDetails.Location = new System.Drawing.Point(30, 68);
            this.lblStudentDetails.Name = "lblStudentDetails";
            this.lblStudentDetails.Size = new System.Drawing.Size(134, 24);
            this.lblStudentDetails.TabIndex = 1;
            this.lblStudentDetails.Text = "Student Details";
            // 
            // lblAverageMark
            // 
            this.lblAverageMark.AutoSize = true;
            this.lblAverageMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageMark.Location = new System.Drawing.Point(30, 110);
            this.lblAverageMark.Name = "lblAverageMark";
            this.lblAverageMark.Size = new System.Drawing.Size(127, 24);
            this.lblAverageMark.TabIndex = 2;
            this.lblAverageMark.Text = "Average Mark";
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGrade.Location = new System.Drawing.Point(30, 152);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(131, 24);
            this.lblStudentGrade.TabIndex = 3;
            this.lblStudentGrade.Text = "Student Grade";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(468, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(604, 268);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 35);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbl_StudentDetails
            // 
            this.lbl_StudentDetails.AutoSize = true;
            this.lbl_StudentDetails.Location = new System.Drawing.Point(171, 78);
            this.lbl_StudentDetails.Name = "lbl_StudentDetails";
            this.lbl_StudentDetails.Size = new System.Drawing.Size(0, 13);
            this.lbl_StudentDetails.TabIndex = 6;
            // 
            // lbl_AverageMark
            // 
            this.lbl_AverageMark.AutoSize = true;
            this.lbl_AverageMark.Location = new System.Drawing.Point(174, 120);
            this.lbl_AverageMark.Name = "lbl_AverageMark";
            this.lbl_AverageMark.Size = new System.Drawing.Size(0, 13);
            this.lbl_AverageMark.TabIndex = 7;
            // 
            // lbl_StudentGrade
            // 
            this.lbl_StudentGrade.AutoSize = true;
            this.lbl_StudentGrade.Location = new System.Drawing.Point(174, 162);
            this.lbl_StudentGrade.Name = "lbl_StudentGrade";
            this.lbl_StudentGrade.Size = new System.Drawing.Size(0, 13);
            this.lbl_StudentGrade.TabIndex = 8;
            // 
            // frmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbInformation);
            this.Name = "frmStudentGrades";
            this.Text = "Student Grades";
            this.tbInformation.ResumeLayout(false);
            this.tbStudentDetails.ResumeLayout(false);
            this.tbStudentDetails.PerformLayout();
            this.tbGrades.ResumeLayout(false);
            this.tbGrades.PerformLayout();
            this.tbResults.ResumeLayout(false);
            this.tbResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbInformation;
        private System.Windows.Forms.TabPage tbStudentDetails;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblStudentMarks;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TabPage tbGrades;
        private System.Windows.Forms.TabPage tbResults;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl_Group;
        private System.Windows.Forms.Label lbl_Student_Number;
        private System.Windows.Forms.Label lblStudent_Name;
        private System.Windows.Forms.Label lblStudent_Marks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchNumber;
        private System.Windows.Forms.Label lblStudent_Number;
        private System.Windows.Forms.TextBox txtScienceMark;
        private System.Windows.Forms.TextBox txtMathsMark;
        private System.Windows.Forms.TextBox txtEnglishMark;
        private System.Windows.Forms.Label lbl_Science;
        private System.Windows.Forms.Label lbl_Maths;
        private System.Windows.Forms.Label lbl_English;
        private System.Windows.Forms.Label lbl_Student_Marks;
        private System.Windows.Forms.Label lbl_StudentGrade;
        private System.Windows.Forms.Label lbl_AverageMark;
        private System.Windows.Forms.Label lbl_StudentDetails;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.Label lblAverageMark;
        private System.Windows.Forms.Label lblStudentDetails;
        private System.Windows.Forms.Label lblResults;
    }
}

