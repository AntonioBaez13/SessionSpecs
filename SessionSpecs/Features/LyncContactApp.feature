﻿Feature: LyncContactApp
	
@UserPref
Scenario: Lync app setting switch added to User Preferences
	Given I am an active user in hub
	When I navigate to the Preferences view for my hub User
	Then I can see the Lync App setting switch in my Basic Settings 
	And Lync App setting switch is ON by default 
