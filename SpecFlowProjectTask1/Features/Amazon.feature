Feature: Amazon

As an unregistered user, User should be able to search for a specific item,
add it to cart,verify and validate it
@task1
Scenario: To add and validate item added to the cart in Amazon home page
	Given User navigate to the Amazon homepage
	When User search for "TP-Link N450 WiFi Router- Wireless Internet Router for Home (TL-WR940N)"
	And User Add the corresponding item to the cart
	And User Verify the corresponding item added to the cart
	Then User validate the correct item and the amount is displayed
