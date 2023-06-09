# TDD Calculator with Acceptance tests
## Description
The console application is created to display a menu with multiple choices.
Choices include a standard calculators functions as well as displaying a list of previous calculations and results; the records.
The application is developed in the following process: 
1. Writing Acceptance tests.
2. Writing unit tests, which are run on Xunit.
3. Creating the program and calculator including the functions.
4. Running the unit tests.

# The following are acceptance tests for the methods of the calculator.
## Addition
1. Start the application.
2. Choose 'Addition', in the presented menu.
3. Enter 5 and press enter.
4. Enter 7 and press enter.
5. Check that the displayed result is 12.
6. Press enter to return to menu.

Expected result: The expected result is that the function calculates by addition correctly and displays the correct calculation result.
## Subtraction
1. Start the application.
2. Choose 'Subtraction', in the presented menu.
3. Enter 5 and press enter.
4. Enter 3 and press enter.
5. Check that the displayed result is 2.
6. Press enter to return to menu.

Expected result: The expected result is that the function calculates by subtraction correctly and displays the correct calculation result.
## Multiplication
1. Start the application.
2. Choose 'Multiplication', in the presented menu.
3. Enter 10 and press enter.
4. Enter 2 and press enter.
5. Check that the displayed result is 20.
6. Press enter to return to menu.

Expected result: The expected result is that the function calculates by multiplication correctly and displays the correct calculation result.
## Division
1. Start the application.
2. Choose 'Division', in the presented menu.
3. Enter 25 and press enter.
4. Enter 5 and press enter.
5. Check that the displayed result is 5.
6. Press enter to return to menu.

Expected result: The expected result is that the function calculates by division correctly and displays the correct calculation result.
## Records - Displaying earlier calculations and results 
1. Start the application.
2. Choose 'Records', in the presented menu.
3. Check the records of previous calculations and results.
4. Press enter to return to menu.

Expected result: The expected result is that the function displays a list of
earlier calculations and the results. If there are no previous calculations there should be an informative message.
If there are previous calculations they should be displayed.
