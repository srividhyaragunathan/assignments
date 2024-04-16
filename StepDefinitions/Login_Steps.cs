using SutherLand_Assignment.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutherLand_Assignment.StepDefinitions
{
    [Binding]
    public class Login_Steps
    {
       
       
        [StepDefinition(@"User Clicks on Login Button")]
        public void GivenUserClicksOnLoginButton()
        {
            Login.Instance.LoginPage();
        }

        [StepDefinition(@"User enters ""([^""]*)"" credentials and ""([^""]*)"" Successfully")]
        public void WhenUserEntersCredentialsAndSuccessfully(string login, string status)
        {
            Login.Instance.loginValidation(login,status);
        }

    }
}
