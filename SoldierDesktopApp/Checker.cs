

namespace SoldierDesktopApp
{
    internal class Checker
    {
        public bool DateFormatChecker(string SDate)
        {
            try
            {
                DateTime date = DateTime.ParseExact(SDate, "yyyy.MM.dd", null);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool IsValidDate(TextBox a, string an)
        {
            string s = RTF(a);
            bool b = IsEmpty(a, an);
            if (b && DateFormatChecker(s))
            {
                return true;
            }
            else
            {
                SM("ERROR: Wrong date format!", 0);
                return false;
            }
        }

        public bool IsEmpty(TextBox a, string an)
        {
            string s = RTF(a);
            if (s.Length > 0)
            {
                return true;
            }
            else
            {
                SM("ERROR: " + an + " field is empty!", 0);
                return false;
            }
        }

        public bool IsNumber(TextBox a, string an)
        {
            string s = RTF(a);
            bool b = IsEmpty(a, an);
            if (b)
            {
                if (int.TryParse(s, out _))
                {
                    return true;
                }
                else
                {
                    SM("ERROR: Wrong number in field: " + an, 0);
                    return false;
                }
            }
            return b;
        }

        public int StringToInt(string s)
        {
            if (int.TryParse(s, out int result))
            {
                return result;
            }
            else
            {
                SM("String to Int: Conversion failed", 0);
                return -1;
            }
        }

        public void SM(string message, int type)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string RTF(TextBox tb)
        {
            return tb.Text;
        }

        public void SuccesfullInsert() {
            string msg = "Data succesfully inserted to the file!";

            MessageBox.Show(msg);
        }
    }
}
