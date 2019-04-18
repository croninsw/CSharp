using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("FB", "Facebook");
            stocks.Add("NTSH", "Nutshell");
            stocks.Add("NSS", "Nashville Software School");

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add(new Dictionary<string, double>() { { "GM", 1000.00 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 500.00 } });
            purchases.Add(new Dictionary<string, double>() { { "FB", 400.00 } });
            purchases.Add(new Dictionary<string, double>() { { "NTSH", 300.00 } });
            purchases.Add(new Dictionary<string, double>() { { "NSS", 200.00 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 1000.00 } });


            Dictionary<string, double> stockReport = new Dictionary<string, double>();
            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> stock in purchase)
                {
                    string fullCompanyName = stocks[stock.Key];
                    // Does the full company name key already exist in the "stockReport"?

                    // If it does not contain the key which has been set to the variable, "fullCompanyName"
                    if (!stockReport.ContainsKey(fullCompanyName))
                    {
                        // Set the company name in the Dictionary and set it's value as well
                        stockReport[fullCompanyName] = stock.Value;

                    }
                    else
                    {

                        // If the key exists, update it's value by adding
                        stockReport[fullCompanyName] += stock.Value;

                    }
                    // Write to the console, the full name of the company and it's stock values
                }

                // OUTPUT
                //     foreach (KeyValuePair<string, double> listing in stockReport)
                //     {
                //         Console.WriteLine($"The position in {listing.Key} is worth {listing.Value}");
                //     }
                }


            // Lightning exercises for post lunch fun
            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
                idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
                idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
                idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
                idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
                idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
                idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
                idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
                idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
                idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
                idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

                // OUTPUT
                // foreach(KeyValuePair<string, List<string>> item in idioms)
                // {
                //     Console.WriteLine($"{item.Key}: {String.Join(" ", item.Value)}");
                // }


            // Ariana's boyfriends
            // Pete Davidson
            // Ricky Alvarez
            // Big Sean
            // Jai Brooks
            // Nathan Sykes
            // Graham Phillips

            Dictionary<string, string> boyfriends = new Dictionary<string, string>();

            // Add Ariana's boyfriends to the boyfriends dictionary with the {key name, value boyfriend} ex. {Big Sean, boyfriend}
                boyfriends.Add("Pete Davidson", "boyfriend");
                boyfriends.Add("Ricky Alvarez", "boyfriend");
                boyfriends.Add("Big Sean", "boyfriend");
                boyfriends.Add("Jai Brooks", "boyfriend");
                boyfriends.Add("Nathan Sykes", "boyfriend");
                boyfriends.Add("Graham Phillips", "boyfriend");

            // I want you to change the value boyfriend to ex-boyfriend ex {Big Sean, ex-boyfriend}, if Pete Davidson change the value to ex-fiance ex {Pete Davidson, ex-fiance}

            Dictionary<string, string> updatedBoyfriends = new Dictionary<string, string>();

                foreach(KeyValuePair<string, string> bf in boyfriends)
                {
                    if (bf.Key == "Pete Davidson")
                    {
                        updatedBoyfriends[bf.Key] = "ex-fiance";
                    } else {
                        updatedBoyfriends[bf.Key] = "ex-boyfriend";
                    }
                }

            // display the results "Ariana's {value} is {key}"
            // OUTPUT
            // foreach(KeyValuePair<string, string> bf in updatedBoyfriends)
            // {
            //     Console.WriteLine($"Ariana's {bf.Value} is {bf.Key}");
            // }


            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // add several words and their definition
            wordsAndDefinitions.Add("Cohort 30", "Pretty damn cool cohort");
            wordsAndDefinitions.Add("Awesome", "Cohort 30 learning C#");

            // OUTPUT
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {
            //     Console.WriteLine($"The defintion of {word.Key} is {word.Value}");
            // }

            List<string> Inventory = new List<string> ()
                {
                    "Camry", "F-150", "MDX", "Camry", "Camry",
                    "Taurus", "F-150", "MDX", "Camry", "Xterra",
                    "Mustang", "Suburban", "Santa Fe", "F-150", "Camry",
                    "F-150", "F-150", "Mustang", "Camry", "Camry",
                    "Camry", "Escalade", "Q30", "Camry", "MDX",
                };
                HashSet<string> allModels = new HashSet<string>();

                foreach (string model in Inventory)
                {
                    allModels.Add(model);
                }

                // OUTPUT
                // foreach (string vehicle in allModels)
                // {
                //     Console.WriteLine($"{vehicle}");
                // }

        }
    }
}



