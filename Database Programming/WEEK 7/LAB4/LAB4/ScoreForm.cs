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
    public partial class ScoreForm : Form
    {

        private int score = -1;

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                score = Convert.ToInt32(txtbxScore.Text);
                this.Close();
            }
        }

        public int GetNewScore()
        {
            this.ShowDialog();
            return score;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtbxScore, "Score") &&
                Validator.IsInt32(txtbxScore, "Score") &&
                Validator.IsWithinRange(txtbxScore, "Score", 0, 100);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
