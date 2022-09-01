Feature:FizzBuzz
 
Given a user has an amount of numbers 
When the user tries to find the numbers multiple of 3 and 5 or both 
Then the returned result is correct 
multiple of 3 the result should be Fizz
multiple of 5 the result should be Buzz
multiple of 3 and 5 the result should be FizzBuzz 


Scenario Outline: Should successfully print the numbers
	Given a user has a range of 100 numers
	When the user tries to print the numbers multiple of <number> in that range 
	Then the result is <result>
Scenarios: 
	| exmple description  | number  | result |
	| multiple_of_3       | 3       | 27     |
	| multiple_of_5       | 5       | 14     |
	| multiple_of_3_and_5 | 3 and 5 | 6      |