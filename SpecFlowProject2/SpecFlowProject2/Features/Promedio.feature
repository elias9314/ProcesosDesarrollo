Feature: Average
	In know my final note
	As student
	I want to know the average of two notes

@mytag
Scenario: Average two notes
	Given the first note is 60
	And the  second note is 80
	When the two notes are averaged
	Then  average should be 70