using System;

class Letter
{
    static void Main()
    {
        Console.WriteLine("Enter letters only and press Enter to validate:");

        string input = "";

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            char inputChar = keyInfo.KeyChar;

            // Check if Enter key is pressed
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (input.Length > 0 && IsAllLetters(input))
                {
                    Console.WriteLine("\nValid input: Letters detected. Process completed.");
                }
                else
                {
                    Console.WriteLine("\nInvalid input: Only letters are allowed.");
                }
                break;
            }

            // Check if the input is a letter
            if (char.IsLetter(inputChar))
            {
                input += inputChar;
                Console.Write(inputChar); // Display the letter as the user types
            }
            else
            {
                // Ignore non-letter input without any output
                continue;
            }
        }
    }

    static bool IsAllLetters(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }
}

