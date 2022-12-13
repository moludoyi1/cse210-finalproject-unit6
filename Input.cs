using System;
using System.Collections.Generic;


enum wageType {
    Salary,
    Hourly,
}
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
        if (input == "hourly") {
            return wageType.Hourly;
        }
        else if (input == "salary"){
            return wageType.Salary;
        }
        else {
            return default;
        }
    }

    public int wageInfo(wageType type) {
        if (type == wageType.Hourly) {
            Console.WriteLine("");
            Console.Write("How much do get paid per hour, ex: $16? $");
            int perHour = int.Parse(Console.ReadLine()); //turns the input to int
            return perHour;
        }
        else if(type == wageType.Salary) {
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

    public Dictionary<string, double> Utilities() {
        Dictionary<string, double> utilities = new Dictionary<string, double>();
        Console.WriteLine("");
        Console.Write("Do you pay any utilities/bills? yes/no ");
        string input = Console.ReadLine();

        if (input == "yes") {
            Console.WriteLine("What utilites do you pay? ex:'car note': ");

            while (true) { //loop until the user inputs "done"
                Console.WriteLine("");
                Console.WriteLine("Enter 'done' when done entering bill names");
                Console.Write("Enter the name of the utility or bill: ");
                string billName = Console.ReadLine();
                
                Console.WriteLine("Enter the amount of the utility of bill per month: ");
                string billAmount = Console.ReadLine();
                utilities.Add(billName, double.Parse(billAmount)); //parses the input as double and adds the bill to the dictionary
                
                if (billName == "done") { //break the loop when user is done entering bills
                    break;
                }
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
}