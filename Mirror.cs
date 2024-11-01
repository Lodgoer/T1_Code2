class Mirror
{
    static bool IsMirrorNumber(int number)
    {
        // Check if the number is a single-digit number
        if (number >= 0 && number < 10)
        {
            return false; // Single-digit numbers are not mirror numbers
        }
        string original = number.ToString(); // Convert the number to a string
        string reversed = "";
        // Reverse the number
        for (int i = original.Length - 1; i >= 0; i--)
        {
            reversed += original[i];
        }
        // Check if the original number is the same as the reversed number
        return original == reversed;
    }
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("      Mirror Number Finder Tool        ");
        Console.WriteLine("========================================");
        Console.WriteLine("Please enter numbers between 0 and 2,147,483,647.");
        Console.WriteLine("----------------------------------------");
        // Get user input for the first number
        Console.Write("Enter the first number (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("\nInvalid input. Please enter a non-negative integer.");
            return;
        }
        // Get user input for the second number
        Console.Write("Enter the second number (m): ");
        if (!int.TryParse(Console.ReadLine(), out int m) || m < 0)
        {
            Console.WriteLine("\nInvalid input. Please enter a non-negative integer.");
            return;
        }
        // Swap n and m if n is greater than m
        if (n > m)
        {
            int temp = n;
            n = m;
            m = temp;
        }
        // Display mirror numbers between n and m
        Console.WriteLine($"\nMirror numbers between {n} and {m} are:\n");
        bool foundMirror = false;
        for (int num = n; num <= m; num++)
        {
            if (IsMirrorNumber(num))
            {
                Console.WriteLine(num);
                foundMirror = true;
            }
        }
        if (!foundMirror)
        {
            Console.WriteLine("No mirror numbers found in the given range.");
        }
        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("Process completed. Press any key to exit.");
        Console.ReadKey();
    }
}