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
        if (input == "hourly") {
            Console.WriteLine("");
            Console.Write("How much do get paid per hour, ex: $16? $");
            int input = Console.ReadLine();
            return wageType.Hourly;
        }
        else (input == "salary") {
            Console.WriteLine("");
            Console.Write("How much is your salary per year? $");
            int input = Console.ReadLine();
            return wageType.Salary;
        }
    }


    public Dictionary<string, double> Utilities() {
        Dictionary<string, double> utilities = new Dictionary<string, double>();
        Console.WriteLine("");
        Console.Write("Do you pay any utilities/bills? ");
        string input = Console.ReadLine();
        if (input == "yes") {
            Console.WriteLine("What utilites do you pay? ex:'car note': ");
            string billpayments = Console.ReadLine();
            utilities.Add(billpayments, 0);
            Console.WriteLine($"How much do you pay for {billpayments}: ")
            string billamount = Console.ReadLine();
            utilities[billpayments] = billamount;
        }
        // utilities.Add(billpayments, billamounts);
        else (input == "no") {
            Console.WriteLine("alright, good for you!!");
            string nopayments = Console.ReadLine();
        }
        return utilities;  //return an empty dictionary
    }

    // public string titHing() {
    //     Console.WriteLine("");
    //     Console.Write("Would you like to pay tithing?")
    // }
}