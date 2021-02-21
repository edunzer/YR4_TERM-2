using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB4
{
    class Validator
    {
        public static string title = "Entry Error";

        public static bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == String.Empty)
            {
                MessageBox.Show(name + " is a required field.", title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox textBox, string name, int min, int max)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", title);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
