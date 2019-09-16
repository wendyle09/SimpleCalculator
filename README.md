# Simple Calculator Console
This program performs the simple math operations using two numbers and an operator.

## Input Fields
* First number - This is the first number in the operation. Decimals are allowed.
* Second number - This is the second number in the operation. Decimals are allowed.
* Operator - This is the operator. Acceptable formats are "+", "-", "*", "/", "add", "subtract", "multiply", "divide".

## Error Handling
If an invalid input is provided for the numbers or operator, an error message is displayed and user will be prompted with option to restart the program.
If an invalid input is provided for the prompt to restart the program, the user will keep getting prompted until a valid input is received.

## Test Script
There are two test scripts, one for the InputConverter class and one for the CalculatorEngine class.
In the InputConverterTest script, there are 2 test cases:
* Valid number is received
* Invalid number is received
In the CalculatorEngineTest script, there are 9 test cases:
* Addition of two numbers using a non-symbol operator
* Addition of two numbers using a symbol operator
* Subtraction of two numbers using a non-symbol operator
* Subtraction of two numbers using a symbol operator
* Multiplication of two numbers using a non-symbol operator
* Multiplication of two numbers using a symbol operator
* Division of two numbers using a non-symbol operator
* Division of two numbers using a symbol operator
