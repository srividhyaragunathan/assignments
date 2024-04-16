using SutherLand_Assignment.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutherLand_Assignment.StepDefinitions
{
    [Binding]
    public class User_Registration_Steps
    {
        [StepDefinition(@"The User Launches browser and opens Registration Page")]
        public void GivenTheUserLaunchesBrowserAndOpensRegistrationPage()
        {
            User_Registration.Instance.LaunchAppUrl();
            User_Registration.Instance.NavigateToUrl();
            
        }

        [StepDefinition(@"User Clicks on SignUp Button")]
        public void GivenUserClicksOnSignUpButton()
        {
            User_Registration.Instance.SignUpBtnClick();
        }

        [StepDefinition(@"The User enters valid Registration details")]
        public void WhenTheUserEntersValidRegistrationDetails()
        {
            User_Registration.Instance.UserRegistration();
        }

        [StepDefinition(@"New User account should be created successfully")]
        public void ThenNewUserAccountShouldBeCreatedSuccessfully()
        {
            
        }


        [StepDefinition(@"the user tries to register with the existing userid")]
        public void WhenTheUserTriesToRegisterWithTheExistingUserid()
        {
            User_Registration.Instance.UserRegistration();
        }

       
        [StepDefinition(@"Error message for ""([^""]*)"" should be displayed and the Registration should not proceed")]
        public void ThenErrorMessgeForShouldBeDisplayedAndTheRegistrationShouldNotProceed(string criteria)
        {
            User_Registration.Instance.ErrorMessage(criteria);
        }


        [StepDefinition(@"User does not enter require fields")]
        public void WhenUserDoesNotEnterRequireFields()
        {
            User_Registration.Instance.missingFields();


        }

        

    }
}
