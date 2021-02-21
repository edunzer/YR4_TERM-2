using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB4
{
    public partial class ViewForm : Form
    {

        public ViewForm()
        {
            InitializeComponent();
        }

        public static List<Student> students = null;
        public static int selected;

        private void FillStudentListBox()
        {
            lstbxStudents.Items.Clear();
            foreach (Student s in students)
            {
                lstbxStudents.Items.Add(s.GetDisplayText());
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            /*StudentDB.LoadSampleStudents();*/
            students = StudentDB.GetStudents();
            FillStudentListBox();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddForm addStudentForm = new AddForm();
            Student student = addStudentForm.GetNewStudent();

            if (student != null)
            {
                students.Add(student);
                StudentDB.SaveStudents(students);
                FillStudentListBox();
                int i = students.Count - 1;
                lstbxStudents.SetSelected(i, true);
            }
        }

        // -------------------  UNFINSIHED -------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateScores = new UpdateForm();
            selected = lstbxStudents.SelectedIndex;
            
            if (lstbxStudents.Items.Count > 0)
            {
                updateScores.ShowDialog(); 
            }
            lstbxStudents.Items.Clear(); 
            StudentDB.SaveStudents(students); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstbxStudents.SelectedIndex;

            if (i != -1)
            {
                Student student = students[i];
                students.Remove(student);
                StudentDB.SaveStudents(students);
                FillStudentListBox();
                txtboxScoreTotal.Text = String.Empty;
                txtbxScoreCount.Text = String.Empty;
                txtbxAverage.Text = String.Empty;
            }
        }

        private void lstBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void Calculations()
        {
            int i = lstbxStudents.SelectedIndex;

            if (i != -1)
            {
                Student selectedStudent = students[i];
                if (selectedStudent.ScoreList.Count() == 0)
                {
                    txtboxScoreTotal.Text = "n/a";
                    txtbxScoreCount.Text = "0";
                    txtbxAverage.Text = "n/a";
                }
                else
                {
                    int total = 0;
                    foreach (int score in selectedStudent.ScoreList)
                    {
                        total += score;
                    }
                    int count = selectedStudent.ScoreList.Count();
                    decimal average = Convert.ToDecimal(total) / Convert.ToDecimal(count);

                    txtboxScoreTotal.Text = Convert.ToString(total);
                    txtbxScoreCount.Text = Convert.ToString(count);
                    txtbxAverage.Text = average.ToString("#.##");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
