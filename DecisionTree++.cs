using System;
using System.Collections.Generic;

namespace ClothsAdvisor
{
    class DecisionTree
    {
        enum State
        {
            Start,
            ColdOutside,
            Snowing,
            Windy,
            Sunset,
            HotOutside,
            Humidity,
            Sunny,
            Rainy,
            MildBreeze,
            Done
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Easy Outfit Advisor!");
            StartDecisionTree();
        }

        static void StartDecisionTree()
        {
            // Mapping of each state to the question it should ask
            Dictionary<State, string> questions = new Dictionary<State, string>
            {
                { State.Start, "Is it cold outside? (Yes/No)" },
                { State.ColdOutside, "Is it snowing or expected to snow? (Yes/No)" },
                { State.Windy, "Is it windy? (Yes/No)" },
                { State.Sunset, "Do you plan to stay out after sunset? (Yes/No)" },
                { State.HotOutside, "Is it hot outside? (Yes/No)" },
                { State.Humidity, "Is there high humidity? (Yes/No)" },
                { State.Sunny, "Is there a lot of sun? (Yes/No)" },
                { State.Rainy, "Is it rainy or expected to rain? (Yes/No)" },
                { State.MildBreeze, "Is it a mild day or is there a slight breeze? (Yes/No)" }
            };

            State state = State.Start;

            while (state != State.Done)
            {
                // Ask the question associated with the current state
                if (questions.TryGetValue(state, out var question))
                {
                    Console.WriteLine(question);
                }

                // Get user input, ensuring we handle invalid values by looping until "yes" or "no" is entered
                string answer = GetValidInput();

                // Define next state and suggestion message in a single switch expression
                (state, string? suggestion) = state switch
                {
                    State.Start => answer == "yes" ? (State.ColdOutside, null) : (State.HotOutside, null),
                    State.ColdOutside => answer == "yes"
                        ? (State.Done, "Suggestion: Wear a thick winter coat, scarf, gloves, snow boots, and a warm hat. Stay warm like a cozy marshmallow!")
                        : (State.Windy, null),
                    State.Windy => answer == "yes"
                        ? (State.Done, "Suggestion: Wear a warm coat, scarf, and a windproof jacket. You don’t want to be blown around like a kite!")
                        : (State.Sunset, null),
                    State.Sunset => answer == "yes"
                        ? (State.Done, "Suggestion: Wear a warm coat, sweater, and gloves. Add a hat to keep your ears warm!")
                        : (State.Done, "Suggestion: Wear a warm coat and a sweater. Layers are like friends – the more, the better."),
                    State.HotOutside => answer == "yes" ? (State.Humidity, null) : (State.Rainy, null),
                    State.Humidity => answer == "yes"
                        ? (State.Done, "Suggestion: Wear light clothes that don’t stick to your skin. You don’t want to feel like a wet towel.")
                        : (State.Sunny, null),
                    State.Sunny => answer == "yes"
                        ? (State.Done, "Suggestion: Wear a hat, sunglasses, and light clothes. Don’t forget sunscreen – you’re not a roast chicken!")
                        : (State.Done, "Suggestion: Wear light and comfy clothes. Stay cool, don’t sweat it!"),
                    State.Rainy => answer == "yes"
                        ? (State.Done, "Suggestion: Wear a raincoat, waterproof shoes, and carry an umbrella. Don’t end up looking like a wet cat!")
                        : (State.MildBreeze, null),
                    State.MildBreeze => answer == "yes"
                        ? (State.Done, "Suggestion: Wear a light jacket or a sweater. Perfect for feeling comfy!")
                        : (State.Done, "Suggestion: Regular, comfy clothes will do. Enjoy the nice weather!"),
                    _ => (State.Done, null) // Default case, should never hit
                };

                // Print the suggestion if we’ve reached the final state
                if (suggestion != null)
                {
                    Console.WriteLine(suggestion);
                }
            }
        }

        static string GetValidInput()
        {
            while (true)
            {
                string input = (Console.ReadLine() ?? "").Trim().ToLower();
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid response. Please type 'Yes' or 'No'.");
                }
            }
        }
    }
}

