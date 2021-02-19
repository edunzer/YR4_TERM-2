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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public static Dictionary<string, List<int>> tmpStudents;
        BindingSource bs = new BindingSource();
        public static int selected;

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateForm_Activated(object sender, EventArgs e)
        {
            txtbxName.Text = tmpStudents.Keys.ElementAt(ViewForm.selected);
            bs.DataSource = tmpStudents.Values.ElementAt(ViewForm.selected);
            lstbxScores.DataSource = bs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addScore = new AddForm();
            addScore.ShowDialog();
            bs.ResetBindings(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selected = lstbxScores.SelectedIndex;
            Form updateScore = new ScoreForm();
            updateScore.ShowDialog();
            bs.ResetBindings(false);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tmpStudents.Values.ElementAt(ViewForm.selected).RemoveAt(lstbxScores.SelectedIndex);
            bs.ResetBindings(false);
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            tmpStudents.Values.ElementAt(ViewForm.selected).RemoveRange(0, tmpStudents.Values.ElementAt(ViewForm.selected).Count);
            bs.ResetBindings(false);
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
