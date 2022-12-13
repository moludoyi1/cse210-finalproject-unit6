using System;
using System.Collections.Generic;

public class moneyCalc {
    TaxDict states =  new TaxDict();
    dataInput inputs = new dataInput();
    BillsCalculations bills = new BillsCalculations();

    public void Run() {
        var incomeAfterTaxes = getTaxDiduct();
        var incomeAfterBills = bills.Calculate(incomeAfterTaxes);
        var wagetype = inputs.hourlySalary();
        // put a welcome message here
    }

        public double getMonthlyEarnings() {
            Console.WriteLine("");
            var wageType = inputs.hourlySalary();
            var wageInfo = inputs.wageInfo(wageType);

            if (wageType == wageType.Hourly) {
                Console.Write("How many hours do you work weekly? ");
                int weeklyhours = int.Parse(Console.ReadLine()); // turn input to int
                double weeklyincome = weeklyhours * wageInfo; 
                double monthlyincome = weeklyincome * 4;
                Console.WriteLine($"Monthly income: ${monthlyincome}");
                return monthlyincome;
            }
            else if (wageType == wageType.Salary) {
                double monthlyincome = wageInfo/12;
                Console.WriteLine($"Monthly income: ${monthlyincome}");
                return monthlyincome;
            }
            else {
                return default;
            }
        }

        public double getTaxDiduct() { //uses inputkey to get state tax rates
            Console.WriteLine("");
            var state = inputs.stateInput();
            var taxRate = states.getTaxRate(state);

            double monthlyincome = getMonthlyEarnings();

            double incomeAfterTaxes = monthlyincome - (monthlyincome * taxRate);
            Console.WriteLine("");
            Console.WriteLine($"Monthly income after taxes: ${Math.Round(incomeAfterTaxes, 2)}");
            return incomeAfterTaxes;
        }
}