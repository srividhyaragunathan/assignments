using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace SutherLand_Assignment.PageObjects
{
    public class User_Registration
    {
        private IWebDriver driver;
        public static readonly User_Registration Instance = new User_Registration();

      

        public static By signUpBtn_HomePage = By.XPath(".//div[@class='tnb-right-section']/a[contains(text(),'Sign Up')]");
        public static By slogInBtn = By.XPath(".//div[@class='tnb-right-section']/a[contains(text(),'Log in')]");
        public static By emailTxt = By.XPath(".//input[@placeholder='email']");
        public static By passwordTxt = By.XPath(".//input[@placeholder='password']");
        public static By fnameTxt = By.XPath(".//input[@placeholder='first name']");
        public static By lnameTxt = By.XPath(".//input[@placeholder='last name']");
        public static By signUpBtn_RegPage = By.XPath("button[type='submit']");
        public static By errorMessage = By.CssSelector(".//div[@class='SignUpForm_error_text__vt1BO']");

        public static string landingPage = "https://www.w3schools.com/";
        public static string email = "ecesrivi@gmail.com";
        public static string password = "Aqwerty@123";
        public static string fname = "Srividhya";
        public static string lname = "Ragunathan";
        public static string errorMessage_ExistingUser = "Looks like you already have a user. Did you try logging in?";
        public static string errorMessage_MissingFields = "Please fill in all fields";
        public void LaunchAppUrl()
        {
            
            driver =new ChromeDriver();
            
        }
        public void NavigateToUrl()
        {
            driver.Url= landingPage;
            driver.Manage().Window.Maximize();
        }

        public void SignUpBtnClick()
        {
            driver.FindElement(signUpBtn_HomePage).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            
        }

        public void UserRegistration()
        {
            driver.FindElement(emailTxt).SendKeys(email);
            driver.FindElement(passwordTxt).SendKeys(password);
            driver.FindElement(fnameTxt).SendKeys(fname);
            driver.FindElement(lnameTxt).SendKeys(lname);
            Thread.Sleep(15000);
            
            driver.FindElement(signUpBtn_RegPage).Click();
           
        }

        public void SuccessfullRegistration()
        {

        }

        public void duplicateEntry()
        {
            var text = driver.FindElement(errorMessage).Text;
            if(text.Equals(errorMessage_ExistingUser))
            {
                Console.WriteLine("Duplicate Entry");
            }
        }

        public void missingFields()
        {
            driver.FindElement(emailTxt).SendKeys(email);
            driver.FindElement(passwordTxt).SendKeys(password);
            driver.FindElement(fnameTxt).SendKeys(fname);
            driver.FindElement(signUpBtn_RegPage).Click();
        }

        public void ErrorMessage(string validation)
        {
            string criteria= validation;
            string errorValidationRule = string.Empty;

            string actualText = driver.FindElement(errorMessage).Text;
            if (criteria.ToLower().Contains("missing"))
            {
                 errorValidationRule = "missing";
            }
            else if(criteria.ToLower().Contains("existing"))
            {
                errorValidationRule = "existing";
            }

            switch(errorValidationRule)
            {
                case "missing":
                    
                        if (actualText.Equals(errorMessage_MissingFields))
                    {
                        Console.WriteLine("Error message displayed for missing fields");
                    }
                    else
                    {
                        Console.WriteLine("Error message is not displayed for missing fields");
                    }
                    break;
                case "existing":
                    if(actualText.Equals(errorMessage_ExistingUser))
                    {
                        Console.WriteLine("Error message displayed for existing user");
                    }
                    else
                    {
                        Console.WriteLine("Error message is not displayed for existing user");
                    }
                    break;
            }
        }

        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
