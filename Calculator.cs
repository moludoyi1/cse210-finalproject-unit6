using System;
using System.Collections.Generic;

interface Calculations {
    
    public double Calculate(double totalBills);
}

public class BillsCalculations : Calculations
{
    public double Calculate(double incomeAfterTaxes)
    {
        var inputs = new dataInput();
        var utilites = inputs.Utilities();
        double afterUtilites = incomeAfterTaxes;
        foreach (var item in utilites) {
            afterUtilites -= item.Value;
        }
        return afterUtilites;
    }
}

public class IncomeAfterTaxes : Calculations
{
    public double Calculate(double totalBills)
    {
        throw new NotImplementedException();
    }
}