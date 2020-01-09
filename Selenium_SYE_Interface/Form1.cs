using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium_SYE_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var energyType = Get_Fuel.Text;

            var firstName = Get_FirstName.Text;
            var surname = Get_Surname.Text;
            var phone = Int32.Parse(Get_Phone.Text);
            var jobTitle = Get_Job.Text;

            var email = Get_Email.Text;
            var mprn = Get_MPRN.Text;
            var mpan = Get_MPAN.Text;

            ValidateEmail(email);

            //throw new Exception($"{firstName} {surname} {phone} {jobTitle} {email} {mprn} {mpan}, {energyType}");
        }

        /// <summary>
        /// Checks Email Input to make sure the email address is valid
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private void ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch (Exception)
            {
                MessageBox.Show($" Email: '{email}' is not valid. \n Please enter a valid Email Address", "Invalid Input");
            }
        }

        private void ValidateMPAN(string mpan)
        {
            if (mpan.Length != 21)
                MessageBox.Show("Invalid Input", $"Please enter a valid MPAN");
        }

        private void ValidateMPRN(string mprn)
        {
            if (mprn.Length < 6) 
                MessageBox.Show("Invalid Input", $"Please enter a valid MPRN");
        }
    }
}
