using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB4
{
    public class StudentDB
    {
        private const string dir = @"G:\2-COLLEGE-\YR4_TERM-2\Database Programming\WEEK 7\";
        private const string path = dir + "StudentScores.txt";

        public static void SaveStudents(List<Student> students)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Student student in students)
            {
                string scoresList = "";

                for (int i = 0; i < student.ScoreList.Count(); i++)
                {
                    int value = student.ScoreList[i];

                    scoresList += (value + "|");
                }

                textOut.Write(student.Name + "|");
                textOut.WriteLine(scoresList.TrimEnd(','));
            }
            textOut.Close();
        }

        public static List<Student> GetStudents()
        {
            
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            

            StreamReader textIn =
                new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            List<Student> students = new List<Student>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Student student = new Student();

                List<int> scoreList = new List<int>();

                if (columns[1] != "")
                {
                    int[] scoreArray = columns[1].Split(',').Select(n => Convert.ToInt32(n)).ToArray();

                    scoreList = scoreArray.ToList();
                    student.ScoreList = scoreList;
                }
                else
                {
                    student.ScoreList = new List<int>();
                }

                student.Name = columns[0];
                students.Add(student);

            }

            textIn.Close();

            return students;
        }

        
        public static void LoadSampleStudents()
        {

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(path))
            {

                StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

                textOut.WriteLine("Jeff Dickson|100|97|68");
                textOut.WriteLine("Sharon Beaudry|95|76|87");
                textOut.WriteLine("Hallie Neupert|95|89|94");

                textOut.Close();
            }
        }
        
    }

}
