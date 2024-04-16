Feature: User_Registration

--To validate if the user is able to register successfully 
and display proper error message if the user already exists

Background: 
Given The User Launches browser and opens Registration Page
And User Clicks on SignUp Button

@User_Registration_New_User
Scenario: Successful User Registration
When The User enters valid Registration details 
Then New User account should be created successfully

@User_Registration_Existing_User
Scenario: Existing User Validation
When the user tries to register with the existing userid
Then Error message for "Existing User" should be displayed and the Registration should not proceed

@User_Registration_MissingRequiredFields
Scenario: Missing Required Fields
When User does not enter require fields
Then Error message for "Missing mandatory fields" should be displayed and the Registration should not proceed