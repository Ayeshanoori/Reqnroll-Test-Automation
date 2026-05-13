Feature: invalidlogin

A short summary of the feature

@functional
Scenario: check user put invalid username and password
Given open browser window go to url and click on make appointment button
	And enter invalid username and password
	When click login button
	Then Login failed... Please ensure the username and password are valid.
