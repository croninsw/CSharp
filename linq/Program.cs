// using System;
// using System.Collections.Generic;
// using System.Collections.Generic;
// using System.Linq;

// namespace linq
// {
//     public class Customer
//     {
//         public string Name { get; set; }
//         public double Balance { get; set; }
//         public string Bank { get; set; }

//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
// Find the words in the collection that start with the letter 'L'
// List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

// IEnumerable<string> LFruits = from fruit in fruits
//                               where fruit.StartsWith("L")
//                               select fruit;
// foreach (string fruit in LFruits)
// {
//     Console.WriteLine($@"
//     {fruit}
//     --------");
// }


// Which of the following numbers are multiples of 4 or 6
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
// foreach (int number in fourSixMultiples)
// {
//     Console.WriteLine($@"
//     {number}
//     --------");
// }

// Order these student names alphabetically, in descending order (Z to A)
// List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

// List<string> descend = names.OrderByDescending(name => name).ToList();

// foreach(string name in descend)
// {
//     Console.WriteLine($"{name}");
// }


// Build a collection of these numbers sorted in ascending order
// List<int> numbers2 = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// IEnumerable<int> ascending = from number in numbers2
//     orderby number ascending
//     select number;

// foreach(int number in ascending)
// {
//     Console.WriteLine($@"
//     {number}
//     --------");
// }


// Output how many numbers are in this list
// List<int> numbers3 = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// Console.WriteLine($"There are {numbers3.Count} total numbers in this list.");


// How much money have we made?
// List<double> purchases = new List<double>()
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// };

// Console.WriteLine($"We have made {purchases.Sum()} in total.");

// What is our most expensive product?
// List<double> prices = new List<double>()
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// };

// Console.WriteLine($"Our most expensive product costs {prices.Max()}");

/*
Store each number in the following List until a perfect square
is detected.

Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
// List<int> wheresSquaredo = new List<int>()
// {
//     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
// };

// IEnumerable<int> stopAtSquare = wheresSquaredo.TakeWhile(number => !(number % Math.Sqrt(number) == 0));
// Console.WriteLine($"These are all not perfect squares");
// foreach(int number in stopAtSquare)
// {
//     Console.WriteLine(number);
// }

// foreach(int area in wheresSquaredo)
// {
//     if(area % Math.Sqrt(area) == 0)
//     {
//         Console.WriteLine($"{area}");
//     }
// }

// Build a collection of customers who are millionaires
// List<Customer> customers = new List<Customer>() {
// new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
// new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
// new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
// new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
// new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
// new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
// new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
// new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
// new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
// new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
// };

// IEnumerable<Customer> millionaires = from person in customers
//     where person.Balance > 1000000.00
//     select person;

// foreach(Customer person in millionaires)
// {
//     Console.WriteLine($"{person.Name} is a millionaire!");
// }

/*
Given the same customer set, display how many millionaires per bank.
Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

Example Output:
WF 2
BOA 1
FTB 1
CITI 1
*/

// List<Customer> customers = new List<Customer>() {
// new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
// new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
// new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
// new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
// new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
// new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
// new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
// new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
// new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
// new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
// };

// var millionaires = from p in customers
//                    where p.Balance >= 1000000.00
//                    select p;

// foreach (Customer person in millionaires)
// {
//     Console.WriteLine($"{person.Name} is a millionaire!");
// }

// var millionairesByBank = from p in millionaires
//                          group millionaires by p.Bank into g
//                          select new { Bank = g.Key, Millionaires = g.ToList() };

// foreach (var bank in millionairesByBank)
// {
//     Console.WriteLine($"{bank.Bank}: {bank.Millionaires.Count()}");
// }

// using System;
// using System.Collections.Generic;

// public class Bank
// {
//     public string Symbol { get; set; }
//     public string Name { get; set; }
// }

// // Define a customer
// public class Customer
// {
//     public string Name { get; set; }
//     public double Balance { get; set; }
//     public string Bank { get; set; }
// }

// public class ReportItem
// {
//     public string CustomerName { get; set; }
//     public string BankName { get; set; }
// }

// public class Program
// {
//     public static void Main()
//     {
//         // Create some banks and store in a List
//         List<Bank> banks = new List<Bank>() {
//             new Bank(){ Name="First Tennessee", Symbol="FTB"},
//             new Bank(){ Name="Wells Fargo", Symbol="WF"},
//             new Bank(){ Name="Bank of America", Symbol="BOA"},
//             new Bank(){ Name="Citibank", Symbol="CITI"},
//         };

//         // Create some customers and store in a List
//         List<Customer> customers = new List<Customer>() {
//             new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
//             new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
//             new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
//             new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
//             new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
//             new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
//             new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
//             new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
//             new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
//             new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
//         };

//         List <Customer> millionaires = customers.FindAll(customer => customer.Balance >= 1000000).ToList();
//                 var millionaireReport =
//                 from b in banks
//                 join c in millionaires on b.Symbol equals c.Bank into customer
//                 from cust in customer
//                 select new {Customer = cust.Name , Bank = b};

//                 foreach (var item in millionaireReport)
//                 {
//                     Console.WriteLine($"{item.Customer} at {item.Bank.Name}");
//                 }
//     }
// }

var groupedByBank = customers.Where(c => c.Balance >= 1000000).GroupBy(
    p => p.Bank, // Group banks
    p => p.Name, // by Millionaire names
    (bank, millionaires) => new GroupedMillionaires() {
        Bank = bank,
            Millionaires = millionaires
    }
).ToList();

public class GroupedMillionaires {
    public string Bank { get; set; }

    public IEnumberable<
}