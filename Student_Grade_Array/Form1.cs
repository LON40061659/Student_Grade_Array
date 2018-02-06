using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade_Array
{
    public partial class frmStudentGrades : Form
    {
        //Variable and Arrays
        const int arraySize = 30;
        private static String[] strStudentName = new String[arraySize];
        private static String[] strStudentNumber = new String[arraySize];
        private static String[] strGroup = new String[arraySize];

        private static int[] intEnglish = new int[arraySize];
        private static int[] intMaths = new int[arraySize];
        private static int[] intScience = new int[arraySize];

        private static int intRecordCount = 0;
        private static int intLoopcounter = 0;
        private static float fAverage = 0;
        private static String strGrade = "";
        public frmStudentGrades()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //calling the hault procedure
            Halt();
        }

        //procedure to exit
        public static void Halt()
        {
            //local variable to store the result
            DialogResult dr;

            //accept response
            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            //if yes then close program
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //enter student details
            EnterDetails();
        }

        //procedure to enter student details
        public void EnterDetails()
        {
            strStudentName[intRecordCount] = txtStudentName.Text;
            strStudentNumber[intRecordCount] = txtStudentNumber.Text;
            strGroup[intRecordCount] = cboGroup.Text;

            intEnglish[intRecordCount] = Convert.ToInt32(txtEnglish.Text);
            intMaths[intRecordCount] = Convert.ToInt32(txtMaths.Text);
            intScience[intRecordCount] = Convert.ToInt32(txtScience.Text);

            //increase counter
            intRecordCount++;

            //display message
            MessageBox.Show("Info Saved");

            //clear form
            ClearDetails();
        }

        //procedure to clear all details
        public void ClearDetails()
        {
            txtEnglish.Text = "";
            txtMaths.Text = "";
            txtScience.Text = "";

            txtStudentName.Text = "";
            txtStudentNumber.Text = "";
            cboGroup.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check records entered
            if (intRecordCount == 0)
            {
                MessageBox.Show("No records entered ");
                return;
            }
            //search through array
            for (int intLoopCounter = 0;
                intLoopCounter < intRecordCount; intLoopCounter++)
            {
                if (txtSearchNumber.Text.Equals
                    (strStudentNumber[intLoopCounter]))
                {
                    txtName.Text = "" + strStudentName[intLoopCounter];
                    txtNumber.Text = "" + strStudentNumber[intLoopCounter];
                    txtGroup.Text = "" + strGroup[intLoopCounter];
                    txtEnglishMark.Text = "" + intEnglish[intLoopCounter];
                    txtMathsMark.Text = "" + intMaths[intLoopCounter];
                    txtScienceMark.Text = "" + intScience[intLoopCounter];
                    //Add additional code to display all values
                    intRecordCount = intLoopCounter;
                    return;
                }
            }
            MessageBox.Show("No match found");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculate the average mark
            fAverage = AverageMark(intEnglish[intRecordCount], intMaths[intRecordCount], intScience[intRecordCount]);

            strGrade = CalculateGrade(fAverage);

            //display results
            DisplayDetails();
        }

        //function to calculate average mark
        public float AverageMark(int intNumber1, int intNumber2, int intNumber3)
        {
            float Average = (float)(intNumber1 + intNumber2 + intNumber3) / 3;
            return Average;
        }

        //function to enter student details
        public string CalculateGrade(float Mark)
        {
            string strFinalGrade = "";
            if (Mark >= 80)
            {
                strFinalGrade = "You achieved a Distnciton";
            }
            else if (Mark >= 60)
            {
                strFinalGrade = "You have achieved a Merit";
            }

            else if (Mark >= 40)
            {
                strFinalGrade = "You achieved a Pass";
            }
            else
            {
                strFinalGrade = "You must Resit";
            }
            return strFinalGrade;
        }

        //procedure to display student details
        public void DisplayDetails()
        {
            lbl_StudentDetails.Text = strGroup[intLoopcounter] + ":     " +
                strStudentNumber[intRecordCount] + ":   " + strStudentName[intRecordCount];
            lbl_AverageMark.Text = fAverage.ToString("#0.00");
            lbl_StudentGrade.Text = strGrade;

        }
    }
}
