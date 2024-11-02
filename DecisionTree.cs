using System;

namespace ClothsAdvisor
{
    class DecisionTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Easy Outfit Advisor – with some fun added!");
            StartDecisionTree();
        }

        static void StartDecisionTree()
        {
            Console.WriteLine("Is it cold outside? (Yes/No)");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("Is it snowing or expected to snow? (Yes/No)");
                answer = Console.ReadLine().Trim().ToLower();

                if (answer == "yes")
                {
                    Console.WriteLine("Suggestion: Wear a thick winter coat, scarf, gloves, snow boots, and a warm hat. Stay warm like a cozy marshmallow!");
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Is it windy? (Yes/No)");
                    answer = Console.ReadLine().Trim().ToLower();

                    if (answer == "yes")
                    {
                        Console.WriteLine("Suggestion: Wear a warm coat, scarf, and a windproof jacket. You don’t want to be blown around like a kite!");
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Do you plan to stay out after sunset? (Yes/No)");
                        answer = Console.ReadLine().Trim().ToLower();

                        if (answer == "yes")
                        {
                            Console.WriteLine("Suggestion: Wear a warm coat, sweater, and gloves. Add a hat to keep your ears warm!");
                        }
                        else
                        {
                            Console.WriteLine("Suggestion: Wear a warm coat and a sweater. Layers are like friends – the more, the better.");
                        }
                    }
                    else
                    {
                        InvalidResponse();
                    }
                }
                else
                {
                    InvalidResponse();
                }
            }
            else if (answer == "no")
            {
                Console.WriteLine("Is it hot outside? (Yes/No)");
                answer = Console.ReadLine().Trim().ToLower();

                if (answer == "yes")
                {
                    Console.WriteLine("Is there high humidity? (Yes/No)");
                    answer = Console.ReadLine().Trim().ToLower();

                    if (answer == "yes")
                    {
                        Console.WriteLine("Suggestion: Wear light clothes that don’t stick to your skin. You don’t want to feel like a wet towel.");
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Is there a lot of sun? (Yes/No)");
                        answer = Console.ReadLine().Trim().ToLower();

                        if (answer == "yes")
                        {
                            Console.WriteLine("Suggestion: Wear a hat, sunglasses, and light clothes. Don’t forget sunscreen – you’re not a roast chicken!");
                        }
                        else
                        {
                            Console.WriteLine("Suggestion: Wear light and comfy clothes. Stay cool, don’t sweat it!");
                        }
                    }
                    else
                    {
                        InvalidResponse();
                    }
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Is it rainy or expected to rain? (Yes/No)");
                    answer = Console.ReadLine().Trim().ToLower();

                    if (answer == "yes")
                    {
                        Console.WriteLine("Suggestion: Wear a raincoat, waterproof shoes, and carry an umbrella. Don’t end up looking like a wet cat!");
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Is it a mild day or is there a slight breeze? (Yes/No)");
                        answer = Console.ReadLine().Trim().ToLower();

                        if (answer == "yes")
                        {
                            Console.WriteLine("Suggestion: Wear a light jacket or a sweater. Perfect for feeling comfy!");
                        }
                        else
                        {
                            Console.WriteLine("Suggestion: Regular, comfy clothes will do. Enjoy the nice weather!");
                        }
                    }
                    else
                    {
                        InvalidResponse();
                    }
                }
                else
                {
                    InvalidResponse();
                }
            }
            else
            {
                InvalidResponse();
            }
        }

        static void InvalidResponse()
        {
            Console.WriteLine("Invalid response. Please type 'Yes' or 'No'. Let’s try again!");
            StartDecisionTree();
        }
    }
}
