Feature: TestFeature

A short summary of the feature

@tag1
Scenario Outline: This is a test scenario
	Given I launch the formy-heroku app url <url>
	When I click on Form 
	Then The form should be displayed
	And I Enter FirstName, LastName, JobTitle and Submit the form
	| FirstName | LastName | JobTitle         |
	| Ravi      | Gajul    | Quality Engineer |

Examples: 
| url                                    |
| "https://formy-project.herokuapp.com/" |
| "https://formy-project.herokuapp.com/" |
