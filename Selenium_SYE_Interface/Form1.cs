using Selenium_SYE_Classes;
using Selenium_SYE_Interface;
using System;

using System.Windows.Forms;

namespace Selenium_SYE_Interface
{
    public partial class Form1 : Form
    {
        private readonly Validation val = new Validation();
        private readonly Quote_Elements element = new Quote_Elements();

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var firstName = val.ValidateIsText(Get_FirstName.Text);
            var surname = val.ValidateIsText(Get_Surname.Text);
            var phone = val.ValidatePhone(Int32.Parse(Get_Phone.Text));
            var jobTitle = val.ValidateIsText(Get_Job.Text);

            var mprn = val.ValidateMPRN(Get_MPRN.Text);
            var mpan = val.ValidateMPAN(Get_MPAN.Text);


   
            // Get Choice Of Energy
            ChooseFuel(val.ValidateFuel(Get_Fuel.Text));

            element.Email_Input(val.ValidateEmail(Get_Email.Text));
            CheckConsent();
            element.ClickNext();

            element.MPAN_Input(val.ValidateMPAN(Get_MPAN.Text));
            element.Usage_Input(val.ValidateIsNumber(Usage_Input.Text), false);
            element.Current_Supplier_Input(0);
            element.ContractEnd_Input(DatePicker.Value.ToString("dd-MM-yyyy"));
            element.ClickNext();


        }

        private void ChooseFuel(string fuel)
        {
            switch (fuel)
            {
                case "Electricity":
                    element.Electricity();
                    break;
                case "Gas":
                    element.Gas();
                    break;
                case "Dual Energy":
                    element.DualEnergy();
                    break;
            }
        }

        private void CheckConsent()
        {
            if (Consent_Input.Checked) element.ConsentBox_Clicker();
        }
    }
}
