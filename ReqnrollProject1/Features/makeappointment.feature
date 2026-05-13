Feature: makeappointment

A short summary of the feature

@functional
Scenario: user books an appointment
	Given open browser window click on make appointment button
	When enter valid username and pass
	And click on the login button
	And enter appointment details
	And click on book appointment button
	Then appointment booked successfully
