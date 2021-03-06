﻿using System;
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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        // ------------------- ALL UNFINSIHED -------------------

        public static List<Student> tmpStudents = null;
        BindingSource bs = new BindingSource();
        public static int selected;

        private void FillStudentListBox()
        {
            lstbxScores.Items.Clear();
            foreach (Student s in tmpStudents)
            {
                lstbxScores.Items.Add(s.GetDisplayText());
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            //txtbxName.Text = Convert.ToString(tmpStudents.ElementAt(ViewForm.selected));
            txtbxName.Text = "Jeff Dickson";


            tmpStudents = StudentDB.GetScores(txtbxName.Text);
            FillStudentListBox();
        }

        private void UpdateForm_Activated(object sender, EventArgs e)
        {
            //txtbxName.Text = tmpStudents.Keys.ElementAt(ViewForm.selected);
            //bs.DataSource = tmpStudents.Values.ElementAt(ViewForm.selected);
            //lstbxScores.DataSource = bs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ScoreForm updateScore = new ScoreForm();
            updateScore.ShowDialog();
            bs.ResetBindings(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selected = lstbxScores.SelectedIndex;
            ScoreForm updateScore = new ScoreForm();
            updateScore.ShowDialog();
            bs.ResetBindings(false);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
