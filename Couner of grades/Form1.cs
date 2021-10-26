using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couner_of_grades
{
    public partial class FormGrade : Form
    {
        public FormGrade()
        {
            InitializeComponent();
            GradesBox.Text = WriteGradesInBox();
        }

        // Buttons

        private void StartCountButton_Click(object sender, EventArgs e)
        {
            byte Index = 0;

            try
            {
                Array.Clear(Grades, 0, Grades.Length);
                for (byte x = 0; x < BufferGrades.Length; x++) // Convert String in Byte's massive
                {
                    if (BufferGrades[x] == '2' || BufferGrades[x] == '3' || BufferGrades[x] == '4' || BufferGrades[x] == '5')
                    {
                        Grades[Index] = Byte.Parse(BufferGrades[x].ToString());
                        Index++;
                    }
                }

                for (byte x = 0; x < Grades.Length; x++) // If "for" meets grade what is "NULL" the cycle will be end.
                {
                    if (Grades[x] != 0 && x + 1 < Grades.Length)
                        Middle += Grades[x];
                    else
                    {
                        Middle /= x;
                        Count = x; // For "NeedsToBetterGrade"'s function.
                        break;
                    }
                }

                middleGradeNowLabel.Text = "Middle grade now — " + Middle;
                fiveToFour.Text = "[5 → 4]: " + NeedsToBetterGrade(5, 4);
                fourToFour.Text = "[4 → 4]: " + NeedsToBetterGrade(4, 4);
                fiveToFive.Text = "[5 → 5]: " + NeedsToBetterGrade(5, 5);
                treeToTree.Text = "[3 → 3]: " + NeedsToBetterGrade(3, 3);
                twoToTree.Text = "[2 → 3]: " + NeedsToBetterGrade(2, 3);
                twoToTwo.Text = "[2 → 2]: " + NeedsToBetterGrade(2, 2);
                Middle = 0;
            }

            catch (Exception Error)
            {
                BoxOfShowingGrades.Text = Error.ToString();
            }
        }

        private void WriteGradeInBase_Click(object sender, EventArgs e)
        {
            try
            {
                if (WriteGradeInBase.Text != string.Empty)
                {
                    ReadGradesFromFile(BoxOfShowingGrades.Text);
                    GradesBox.Text = WriteGradesInBox();
                }
                else
                    throw new Exception("The string is empty.");
            }
            catch (Exception Error)
            {
                BoxOfShowingGrades.Text = Error.ToString();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // Light
        {
            this.BackColor = DefaultBackColor;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) // Dark
        {
            this.BackColor = Color.FromArgb(59, 59, 59);
        }

        // Functions

        private void ReadGradesFromFile(string GradesString)
        {
            try
            {
                StreamWriter WriteGrades = new StreamWriter(@"Grades.txt");

                if (GradesString != string.Empty)
                {
                    WriteGrades.Write(GradesString);
                    BufferGrades = GradesString;
                }
                else
                    BoxOfShowingGrades.Text = "Error. Uncoorrect input.";

                WriteGrades.Close();
            }

            catch (Exception Error)
            {
                BoxOfShowingGrades.Text = Error.ToString();
            }

            finally
            {
                BoxOfShowingGrades.Text = null;
            }
        }

        private string WriteGradesInBox()
        {
            try
            {
                StreamReader ReadGrades = new StreamReader(@"Grades.txt");
                string GradesString = ReadGrades.ReadLine();
                BufferGrades = string.Empty;
                if (GradesString != string.Empty && GradesString != null)
                    for (byte x = 0; x < GradesString.Length; x++)
                        if (GradesString[x] == '2' || GradesString[x] == '3' || GradesString[x] == '4' || GradesString[x] == '5')
                            BufferGrades += GradesString[x] + " ";

                ReadGrades.Close();

                return BufferGrades;
            }
            catch (Exception Error)
            {
                BoxOfShowingGrades.Text = Error.ToString();
                return null;
            }
        }

        private byte NeedsToBetterGrade(byte typeOfGradeToBeBetterCycle, byte purposeGrade)
        {
            float CopyMiddle = Middle;
            byte CopyCount = Count;

            if (Math.Round(CopyMiddle, MidpointRounding.AwayFromZero) != purposeGrade && typeOfGradeToBeBetterCycle != Math.Round(CopyMiddle, MidpointRounding.AwayFromZero))
                while (Math.Round(CopyMiddle, MidpointRounding.AwayFromZero) != purposeGrade)
                    CopyMiddle = ((CopyMiddle * CopyCount) + typeOfGradeToBeBetterCycle) / (++CopyCount);

            CopyCount -= Count;

            return CopyCount;
        }
        private void russianLanguageMenu_Click(object sender, EventArgs e)
        {

        }

        private void englishLanguageMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
