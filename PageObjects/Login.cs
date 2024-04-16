using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutherLand_Assignment.PageObjects
{
    
    public class Login
    {
        private IWebDriver driver;

        public static readonly Login Instance = new Login();

        public static By loginBtn_HomePage = By.XPath(".//div[@class='tnb-right-section']/a[contains(text(),'Log in')]");
        public static By emailTxt = By.XPath(".//input[@placeholder='email']");
        public static By passwordTxt = By.XPath(".//input[@placeholder='password']");
        public static By loginBtn_LoginPage =By.XPath(".//button[text()='Login']");
        public static By errorMessage = By.XPath(".//div[@class='LoginForm_error_text__4fzmN']");

        public static string email = "ecesrivi@gmail.com";
        public static string password = "Aqwerty@123";
        public static string errorMessageTxt = "Sorry, looks like that’s the wrong email or password.";
       
        public void LoginPage()
        {
            Thread.Sleep(1000);
            driver.FindElement(loginBtn_HomePage).Click();
            Thread.Sleep(1000);
        }
        public void loginValidation(string loginType, string status)
        {
           

            if(loginType.ToLower().Equals("valid")) 
            {
                driver.FindElement(emailTxt).SendKeys(email);
                driver.FindElement(passwordTxt).SendKeys(password);
                driver.FindElement(loginBtn_LoginPage).Click();

                string actualText = driver.FindElement(errorMessage).Text;
                if (actualText.Contains(email))
                {
                    Console.WriteLine("Login is successfull");

                }
                else
                {
                    Console.WriteLine("Login is not successfull");
                }

            }
            else if(loginType.ToLower().Equals("invalid"))
            {
                driver.FindElement(emailTxt).SendKeys(email);
                driver.FindElement(passwordTxt).SendKeys("password");
                driver.FindElement(loginBtn_LoginPage).Click();
                string actualText = driver.FindElement(errorMessage).Text;

                if(actualText.Equals(errorMessageTxt))
                {
                    Console.WriteLine("Error message is displayed");
                }
                else
                {
                    Console.WriteLine("Error message is not displayed");

                }
            }
        }
    }
}
