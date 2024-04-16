Feature: Login

To verify if the user is able to login


Background: 
Given The User Launches browser and opens Registration Page
And User Clicks on Login Button

@ValidLogin
Scenario: Successfull login
When User enters "valid" credentials and "able to login" Successfully


@InvalidLogin
Scenario: UnSuccessfull login
When User enters "valid" credentials and "unable to login" Successfully
