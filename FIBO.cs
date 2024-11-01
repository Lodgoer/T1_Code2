using System;

class FIBO
{
    // Function to generate and check if n is in the Fibonacci series starting from a1 and a2
    static bool GenerateFibonacciSeries(int a1, int a2, int n)
    {
        Console.Write("Series: ");
        Console.Write($"{a1} ");

        // If a1 equals a2, print only one instance initially
        if (a1 != a2 || a1 == 0)
        {
            Console.Write($"{a2} ");
        }

        if (n == a1 || n == a2) return true;

        int current = a2, previous = a1, next = a1 + a2;
        bool found = false;

        while (true)
        {
            Console.Write($"{next} ");
            if (next == n) found = true;
            if (found && next == n) break; // Stop when reaching n if found
            if (!found && next > n) break; // Stop when exceeding n if not found

            previous = current;
            current = next;
            next = previous + current;
        }

        Console.WriteLine(); // New line after printing the series

        return found;
    }

    static void Main()
    {
        Console.Write("Enter the first number (a1): ");
        if (!int.TryParse(Console.ReadLine(), out int a1) || a1 < 0)
        {
            Console.WriteLine("Invalid input! Please enter a non-negative integer for a1.");
            return;
        }

        Console.Write("Enter the second number (a2): ");
        if (!int.TryParse(Console.ReadLine(), out int a2) || a2 < 0)
        {
            Console.WriteLine("Invalid input! Please enter a non-negative integer for a2.");
            return;
        }

        // Check for the special case where a1 = a2 = 0
        if (a1 == 0 && a2 == 0)
        {
            Console.WriteLine("Invalid input! a1 and a2 cannot both be zero.");
            return;
        }

        Console.Write("Enter the number to check (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid input! Please enter a non-negative integer for n.");
            return;
        }

        // Check if the input order is valid (a1 <= a2 <= n)
        if (!(a1 <= a2 && a2 <= n))
        {
            Console.WriteLine("Invalid input! Please ensure that a1 <= a2 <= n.");
            return;
        }

        // Display the Fibonacci series and check if n is part of it
        Console.WriteLine($"\nFibonacci series starting from {a1} and {a2} until it reaches {n} or exceeds it:");
        bool isInSeries = GenerateFibonacciSeries(a1, a2, n);

        // Display if n is in the series or not
        Console.WriteLine(isInSeries ? $"\nThe number {n} is in the Fibonacci series." : $"\nThe number {n} is NOT in the Fibonacci series.");

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
