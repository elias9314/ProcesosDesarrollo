Feature: Average
	In know my final note
	As student
	I want to know the average of two notes

@mytag
Scenario Outline: Average two notes
	Given  first notes is <number1>
	And  second notes is <number2>
	When the two note are averaged
	Then  average total <result>

	Examples: 

|number1|number2|result|
|18     |15     |  16.5|
|14     |20     |  17.0| 
|13     |16     |  14.5| 