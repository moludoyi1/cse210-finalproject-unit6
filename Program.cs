using System;
using System.Collections.Generic;

class Main {

    TaxDict states =  new TaxDict();
    dataInput inputs = new dataInput();

    public int getMonthlyEarnings() {
        Console.WriteLine("");
        Console.Write("How many hours do you work weakly? ");
        int weeklyhours = int.Parse(Console.ReadLine()); // turn input to int
        // return weeklyHours;

        var wageType = inputs.hourlySalary();
        if (wageType == wageType.Hourly) { //
            double weeklyincome = weeklyhours * dataInput.hourlySalary(perHour); 
            double monthlyincome = weeklyincome * 4;
            Console.WriteLine($"Monthly income: ${monthlyearning}");
            return monthlyincome;
        }
        // var wageType = inputs.hourlySalary();
        else if (wageType == wageType.Salary) {
            double salarymonthlyearning = wageType.Salary/48;
            return salarymonthlyearning;
        }
        else {
            return default;
        }
    }

    public double getTaxDiduct() { //uses inputkey to get state tax rates
        Console.WriteLine("");

    }

    public double costOfUtilities() { // deducts the bills inputed to get how much money left over
        Console.WriteLine("");

    }


    // static void DisplayWelcomeMessage() {
    //     Console.WriteLine("");
    //     Console.WriteLine("");
    //     Console.WriteLine("############################");
    //     Console.WriteLine("Welcome");
    //     Console.WriteLine("");
    //     //Console.WriteLine("");
    //     Console.WriteLine("Let the game begin!!!");
    //     Console.WriteLine("############################");
    //     Console.WriteLine("");
    //     Console.WriteLine("");
    //     Console.WriteLine("");
    // }
}