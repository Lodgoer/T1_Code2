class Prime
{
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
            if (number % i == 0) return false;
        return true;
    }
    static void Main()
    {
        const int MaxIntValue = int.MaxValue; // The maximum value for a 32-bit integer
        Console.WriteLine("========================================");
        Console.WriteLine("       Prime Number Finder Tool        ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Please enter numbers between 0 and {MaxIntValue}.");
        Console.WriteLine("Note: The second number (m) must be greater than the first number (n).");
        Console.WriteLine("----------------------------------------");
        Console.Write("Enter the first number (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > MaxIntValue)
        {
            Console.WriteLine("\nInvalid input. Please enter a valid number between 0 and the maximum integer value.");
            return;
        }
        Console.Write("Enter the second number (m): ");
        if (!int.TryParse(Console.ReadLine(), out int m) || m < 0 || m > MaxIntValue || m <= n)
        {
            Console.WriteLine("\nInvalid input. Please ensure that m > n and is within the allowed range.");
            return;
        }
        Console.WriteLine("\nCalculating prime numbers...");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Prime numbers between {n} and {m} are:\n");
        bool foundPrime = false;
        for (int num = n; num <= m; num++)
        {
            if (IsPrime(num))
            {
                Console.WriteLine(num);
                foundPrime = true;
            }
        }
        if (!foundPrime)
        {
            Console.WriteLine("No prime numbers found in the given range.");
        }
        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("Process completed. Press any key to exit.");
        Console.ReadKey();
    }
}