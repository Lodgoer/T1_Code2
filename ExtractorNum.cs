using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class ExtractorNum
{
    static void Main()
    {
        Console.WriteLine("Enter a string containing phone numbers:");
        string? input = Console.ReadLine(); // Allow 'input' to be nullable with string?

        // Ensure 'input' is not null before passing to the method
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        List<string> validPhoneNumbers = ExtractValidPhoneNumbers(input);
        if (validPhoneNumbers.Count > 0)
        {
            Console.WriteLine("Extracted valid phone numbers:");
            foreach (string number in validPhoneNumbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No valid phone numbers found.");
        }
    }

    static List<string> ExtractValidPhoneNumbers(string input)
    {
        // Regex pattern to match 10-digit phone numbers starting with 0
        Regex phonePattern = new Regex(@"\b0\d{9}\b");
        List<string> validNumbers = new List<string>();
        MatchCollection matches = phonePattern.Matches(input);
        foreach (Match match in matches)
        {
            string phoneNumber = match.Value;
            if (HasAtLeastTwoDifferentDigits(phoneNumber))
            {
                validNumbers.Add(phoneNumber);
            }
        }
        return validNumbers;
    }

    static bool HasAtLeastTwoDifferentDigits(string phoneNumber)
    {
        HashSet<char> uniqueDigits = new HashSet<char>(phoneNumber);
        return uniqueDigits.Count >= 2;
    }
}

