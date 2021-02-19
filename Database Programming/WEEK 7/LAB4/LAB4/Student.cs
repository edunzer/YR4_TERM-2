using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Student
    {
        private string name;
        private List<int> scoreList;

        public Student()
        {
        }

        public Student(string name, List<int> scoreList)
        {
            this.Name = name;
            this.ScoreList = scoreList;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<int> ScoreList
        {
            get
            {
                return scoreList;
            }
            set
            {
                scoreList = value;
            }
        }

        public string GetDisplayText()
        {
            string total = "";
            foreach (int score in scoreList)
            {
                total += "|" + score;
            }
            return name + total;
        }
    }
}

