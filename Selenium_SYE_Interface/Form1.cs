using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_SYE_Classes;
using Selenium_SYE_Interface;
using System;

using System.Windows.Forms;

namespace Selenium_SYE_Interface
{
    public partial class Form1 : Form
    {
        private readonly IWebDriver _driver = new ChromeDriver();

        private readonly Selenium_Setup browser = new Selenium_Setup();
        private readonly Validation val = new Validation();
        private readonly Quote_Elements element = new Quote_Elements();

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            HomePage(val.ValidateFuel(Get_Fuel.Text));

            PageOne();
            PageTwo();

            // Do a check to see whether to do gas or elec quote
            ElecQuote();
            ContactDetailsAndQuote();
            BankDetails();
            
            browser.KillBrowser();
        }

        private void BankDetails()
        {
            element.BankName_Input(val.ValidateIsText(Get_BankName.Text));
            element.AccountName_Input(val.ValidateIsText(Get_AccountName.Text));
            element.SortCode_Input(val.ValidateSortCode(Get_SortCode.Text));
            element.AccountNumber_Input(val.ValidateAccountNum(Get_AccountNumber.Text));
            element.ClickNext();
        }

        private void ContactDetailsAndQuote()
        {
            element.SelectQuote(0);
            element.Title_Picker(0);

            element.FirstName_Input(val.ValidateIsText(Get_FirstName.Text));
            element.Surname_Input(val.ValidateIsText(Get_Surname.Text));
            element.Job_Input(val.ValidateIsText(Get_Job.Text));
            element.PhoneNumber_Input(val.ValidatePhone(Int32.Parse(Get_Phone.Text)));
        }

        private void PageTwo()
        {
            element.CompanyChoice_Input(Company_Input.Text, 0);
            element.ClickNext();
        }

        private void ElecQuote()
        {
            element.MPAN_Input(val.ValidateMPAN(Get_MPAN.Text));
            element.Usage_Input(val.ValidateIsNumber(Usage_Input.Text), false);
            element.Current_Supplier_Input(0);
            element.ContractEnd_Input(DatePicker.Value.ToString("dd-MM-yyyy"));
            element.ClickNext();
        }

        private void PageOne()
        {
            element.Email_Input(val.ValidateEmail(Get_Email.Text));
            CheckConsent();
            element.ClickNext();
        }

        private void HomePage(string fuel)
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
