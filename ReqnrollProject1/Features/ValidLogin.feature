Feature: ValidLogin

A short summary of the feature

@functional
Scenario: check whether user enters valid username and password
	Given open browser goto url click on make appointment button
	And enter valid username and password
	When click on login btn
	Then user logged in successfully