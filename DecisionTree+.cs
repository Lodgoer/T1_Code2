using System;

namespace ClothsAdvisor
{
    class DecisionTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Easy Outfit Advisor!");
            StartDecisionTree();
        }

        static void StartDecisionTree()
        {
            string responseSequence = "";
            bool complete = false;

            while (!complete)
            {
                switch (responseSequence)
                {
                    case "":
                        responseSequence += PromptUser("Is it cold outside? (Yes/No)");
                        break;

                    case "yes":
                        responseSequence += PromptUser("Is it snowing or expected to snow? (Yes/No)");
                        break;

                    case "yesyes":
                        Console.WriteLine("Suggestion: Wear a thick winter coat, scarf, gloves, snow boots, and a warm hat. Stay warm like a cozy marshmallow!");
                        complete = true;
                        break;

                    case "yesno":
                        responseSequence += PromptUser("Is it windy? (Yes/No)");
                        break;

                    case "yesnoyes":
                        Console.WriteLine("Suggestion: Wear a warm coat, scarf, and a windproof jacket. You don’t want to be blown around like a kite!");
                        complete = true;
                        break;

                    case "yesnono":
                        responseSequence += PromptUser("Do you plan to stay out after sunset? (Yes/No)");
                        break;

                    case "yesnonoyes":
                        Console.WriteLine("Suggestion: Wear a warm coat, sweater, and gloves. Add a hat to keep your ears warm!");
                        complete = true;
                        break;

                    case "yesnonono":
                        Console.WriteLine("Suggestion: Wear a warm coat and a sweater. Layers are like friends – the more, the better.");
                        complete = true;
                        break;

                    case "no":
                        responseSequence += PromptUser("Is it hot outside? (Yes/No)");
                        break;

                    case "noyes":
                        responseSequence += PromptUser("Is there high humidity? (Yes/No)");
                        break;

                    case "noyesyes":
                        Console.WriteLine("Suggestion: Wear light clothes that don’t stick to your skin. You don’t want to feel like a wet towel.");
                        complete = true;
                        break;

                    case "noyesno":
                        responseSequence += PromptUser("Is there a lot of sun? (Yes/No)");
                        break;

                    case "noyesnoyes":
                        Console.WriteLine("Suggestion: Wear a hat, sunglasses, and light clothes. Don’t forget sunscreen – you’re not a roast chicken!");
                        complete = true;
                        break;

                    case "noyesnono":
                        Console.WriteLine("Suggestion: Wear light and comfy clothes. Stay cool, don’t sweat it!");
                        complete = true;
                        break;

                    case "nono":
                        responseSequence += PromptUser("Is it rainy or expected to rain? (Yes/No)");
                        break;

                    case "nonoyes":
                        Console.WriteLine("Suggestion: Wear a raincoat, waterproof shoes, and carry an umbrella. Don’t end up looking like a wet cat!");
                        complete = true;
                        break;

                    case "nonono":
                        responseSequence += PromptUser("Is it a mild day or is there a slight breeze? (Yes/No)");
                        break;

                    case "nononoyes":
                        Console.WriteLine("Suggestion: Wear a light jacket or a sweater. Perfect for feeling comfy!");
                        complete = true;
                        break;

                    case "nononono":
                        Console.WriteLine("Suggestion: Regular, comfy clothes will do. Enjoy the nice weather!");
                        complete = true;
                        break;
                }
            }
        }

        static string PromptUser(string question)
        {
            Console.WriteLine(question);
            string answer;
            do
            {
                answer = Console.ReadLine()?.Trim().ToLower() ?? ""; // Handle potential null input
                if (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Invalid response. Please type 'Yes' or 'No'.");
                }
            } while (answer != "yes" && answer != "no");

            return answer;
        }
    }
}
