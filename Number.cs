using System;
class Number
{
    static void Main()
    {
        Console.WriteLine("Enter numbers and press Enter to validate:");
        string input = "";
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            char inputChar = keyInfo.KeyChar;
            // Check if Enter key is pressed
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (input.Length > 0 && IsAllDigits(input))
                {
                    Console.WriteLine("\nValid input: Numbers detected. Process completed.");
                }
                else
                {
                    Console.WriteLine("\nInvalid input: Only numbers are allowed.");
                }
                break;
            }
            // Check if the input is a digit
            if (char.IsDigit(inputChar))
            {
                input += inputChar;
                Console.Write(inputChar); // Display the number as the user types
            }
            else
            {
                // Ignore non-numeric input without any output
                continue;
            }
        }
    }
    static bool IsAllDigits(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}