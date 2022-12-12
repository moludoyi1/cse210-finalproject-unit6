using System;
using System.Collections.Generic;


enum wageType {
    Salary,
    Hourly,
}

// enum utiliTies{

// }

class dataInput {
    public string stateInput() {
        // uses the input from user to get dictionary key
        Console.WriteLine("");
        Console.WriteLine("Please use lower cases :)");
        Console.Write("What state do you reside in: ");
        string input = Console.ReadLine();
        return input;
    }

    public wageType hourlySalary() {
        Console.WriteLine("");
        Console.WriteLine("lowercases pls");
        Console.Write("Do you get paid hourly or salary? ");
        string input = Console.ReadLine();
        return input;
    }

    public int wageInfo(wageType type) {
        if (type == "hourly") {
            Console.WriteLine("");
            Console.Write("How much do get paid per hour, ex: $16? $");
            int perHour = int.Parse(Console.ReadLine()); //turns the input to int
            return perHour;
        }
        else if(type == "salary") {
            Console.WriteLine("");
            Console.Write("How much is your salary per year? $");
            int perAnnually = int.Parse(Console.ReadLine());
            return perAnnually;
        }
        else {
            Console.WriteLine("Invalid input, stupid. Try again!!");
            return (int)hourlySalary(); //calls the method until a valid input is provided
        }
    }


    //     wageType wageType;

    //     switch(input) {
            
    //         case "hourly":
    //             Console.WriteLine("")
    //             Console.Write("How much do you get paid per hour, ex: $16? $");
    //             int input = int.Parse(Console.ReadLine()); //turns the input to int
    //             wageType = wageType.Hourly;
    //             break;

    //         case "salary":
    //             Console.WriteLine("");
    //             Console.Write("How much is your salary per year? ");
    //             int input = int.Parse(Console.ReadLine());
    //             wageType = wageType.Salary;
    //             break;
            
    //         default:
    //             Console.WriteLine("Invalid input. Please try again.");
    //         return hourlySalary(); //recursively call the method until a valid input is provided
    //     }
    //     return wageType;
    // }

    public Dictionary<string, double> Utilities() {
        Dictionary<string, double> utilities = new Dictionary<string, double>();
        Console.WriteLine("");
        Console.Write("Do you pay any utilities/bills? ");
        string input = Console.ReadLine();

        if (input == "yes") {
            Console.WriteLine("What utilites do you pay? ex:'car note': ");

            while (true) { //loop until the user inputs "done"
                Console.WriteLine("Enter 'done' when done entering bill names");
                Console.Write("Enter the name of the utility or bill: ");
                string billName = Console.ReadLine();

                if (billName == "done") { //break the loop when user is done entering bills
                    break;
                }
                Console.WriteLine("Enter the amount of the utility of bill per month: ");
                string billAmount = Console.ReadLine();
                utilities.Add(billName, double.Parse(billAmount)); //parses the input as double and adds the bill to the dictionary
            }
            return utilities;
        }
        else if (input == "no") {
            Console.WriteLine("alright, good for you!!");
            return utilities; //return an empty dictionary
        }
        else {
            return default;
        }
    }
        


    // public Dictionary<string, double> Utilities() {
    //     Dictionary<string, double> utilities = new Dictionary<string, double>();
    //     Console.WriteLine("");
    //     Console.Write("Do you pay any utilities/bills? ");
    //     string input = Console.ReadLine();
    //     if (input == "yes") {
    //         Console.WriteLine("What utilites do you pay? ex:'car note': ");
    //         string billpayments = Console.ReadLine();
    //         utilities.Add(billpayments, 0); //adds the bill to the dictionary with a value of 0
    //         Console.WriteLine($"How much do you pay for {billpayments}: ")
    //         string billamount = Console.ReadLine();
    //         utilities[billpayments] = double.Parse(billamount); //parse the input as double and sets it as the value for the bill in the dictionary
    //         return utilities;
    //     }
    //     // utilities.Add(billpayments, billamounts);
    //     else if(input == "no") {
    //         Console.WriteLine("alright, good for you!!");
    //         return utilities;  //return an empty dictionary
    //     }
        
    // }

    // public string titHing() {
    //     Console.WriteLine("");
    //     Console.Write("Would you like to pay tithing?")
    // }
}