using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium_SYE_Interface
{
    public class Validation
    {
        /// <summary>
        /// Checks Email Input to make sure the email address is valid
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch (Exception)
            {
                MessageBox.Show($" Email: '{email}' is not valid. \n Please enter a valid Email Address", "Invalid Input");
            }
            return email;
        }

        public string ValidateMPAN(string mpan)
        {
            if (mpan.Length != 21)
                MessageBox.Show($" MPAN: '{mpan}' is not valid. \n Please enter a valid MPAN", "Invalid Input");
            return mpan;
        }

        public string ValidateMPRN(string mprn)
        {
            if (mprn.Length < 6)
                MessageBox.Show($" MPRN: '{mprn}' is not valid. \n Please enter a valid MPRN", "Invalid Input");
            return mprn;
        }

        public string ValidatePhone(int phone)
        {
            var phoneNum = phone.ToString();

            if (phoneNum.Length < 11)
                MessageBox.Show($" Phone Number: '{phoneNum}' is not valid. \n Please enter a valid Phone Number", "Invalid Input");

            return phoneNum;
        }

        public string ValidateFuel(string fuel)
        {
            var isFuelCorrect = false;
            do
            {
                switch (fuel)
                {
                    case "Electricity":
                        isFuelCorrect = true;
                        break;
                    case "Gas":
                        isFuelCorrect = true;
                        break;
                    case "Dual Energy":
                        isFuelCorrect = true;
                        break;
                    default:
                        MessageBox.Show($" Energy Type: '{fuel}' is not valid. \n Please pick a valid Energy Type", "Invalid Input");
                        break;
                }
            } while (isFuelCorrect != true);

            return fuel;
        }

        public string ValidateIsText(string text)
        {
            var t = true;
            do
            {
                if (Regex.IsMatch(text, @"^[a-zA-Z]+$"))
                    t = false;
            } while (t);
            return text;            
        }

        public string ValidateIsNumber(string num)
        {
            var t = true;
            do
            {
                if (Regex.IsMatch(num, @"^[1-9]+$"))
                    t = false;
            } while (t);
            return num;
        }
    }
}
