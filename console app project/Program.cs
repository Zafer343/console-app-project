using System;

// Define a class named 'Calculator'.
public class Calculator
{
    // Define a method named 'PerformOperation' that does not return a value (void)
    // and takes two integers as parameters.
    public void PerformOperation(int number1, int number2)
    {
        // Perform a math operation on the first integer (e.g., multiply by 2).
        int result = number1 * 2;

        // Display the second integer to the screen.
        Console.WriteLine("The second number is: " + number2);

        // Optionally display the result of the operation on the first integer.
        Console.WriteLine("The result of the operation on the first number is: " + result);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the Calculator class.
        Calculator calc = new Calculator();

        // Call the 'PerformOperation' method, passing in two numbers (e.g., 5 and 10).
        calc.PerformOperation(5, 10);

        // Call the 'PerformOperation' method again, specifying the parameters by name.
        calc.PerformOperation(number1: 15, number2: 30);

        // Wait for the user to press a key to close the console window.
        Console.ReadKey();
    }
}
