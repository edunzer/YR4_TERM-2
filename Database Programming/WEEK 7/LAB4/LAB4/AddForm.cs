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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private Student student = null;

        public Student GetNewStudent()
        {
            this.ShowDialog();
            return student;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtbxName, "Name"))
            {
                student = new Student(txtbxName.Text, tempList);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<int> tempList = new List<int>();

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            tempList.Clear();
            txtbxScores.Text = String.Empty;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                tempList.Add(Convert.ToInt32(txtbxScore.Text));
                string total = "";
                foreach (int scores in tempList)
                {
                    total += Convert.ToString(scores) + " ";
                }
                txtbxScores.Text = total;
            }

        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtbxScore, "Score") &&
                Validator.IsInt32(txtbxScore, "Score") &&
                Validator.IsWithinRange(txtbxScore, "Score", 0, 100);
        }
    }
}
