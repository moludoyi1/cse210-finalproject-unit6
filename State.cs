using System;
using System.Collections.Generic;
public class TaxDict {
    Dictionary<string, double> states = new Dictionary<string, double>();
    public TaxDict() {
        // Dictionary<TKey, Tvaleue>;
        states.Add("alabama", 0.0200);
        states.Add("alaska", 0);
        states.Add("arizona", 0.259);
        states.Add("arkansas", 0.0090);
        states.Add("california", 0.1330);
        states.Add("colorado", 0);
        states.Add("connecticut", 0.0300);
        states.Add("delaware", 0.0220);
        states.Add("florida", 0);
        states.Add("georgia", 0.0600);
        states.Add("hawaii", 0.0140);
        states.Add("idaho", 0.0160);
        states.Add("illinois", 0.0160);
        states.Add("indiana", 0.0160);
        states.Add("iowa", 0.0036);
        states.Add("kansas", 0.0290);
        states.Add("kentucky", 0.0200);
        states.Add("louisiana", 0.0600);
        states.Add("maine", 0.0580);
        states.Add("maryland", 0.0575);
        states.Add("massachusetts", 0.0500);
        states.Add("michigan", 0.0425);
        states.Add("minnesota", 0.0535);
        states.Add("mississipi", 0.0300);
        states.Add("missouri", 0.0150);
        states.Add("montana", 0.0100);
        states.Add("nebraska", 0.0684);
        states.Add("nevada", 0);
        states.Add("new hampshire", 0.0500);
        states.Add("new jersey", 0.0140);
        states.Add("new mexico", 0.0490);
        states.Add("new york", 0.0400);
        states.Add("north carolina", 0.0525);
        states.Add("north dakota", 0.0110);
        states.Add("ohio", 0.0050);
        states.Add("oklahoma", 0.0050);
        states.Add("oregon", 0.0500);
        states.Add("pennsylvania", 0.0307);
        states.Add("rhode island", 0.0375);
        states.Add("south carolina", 0.0700);
        states.Add("south dakota", 0);
        states.Add("tennessee", 0.0100);
        states.Add("texas", 0);
        states.Add("utah", 0.0495);
        states.Add("vermont", 0.0355);
        states.Add("virginia", 0.0575);
        states.Add("washington", 0.0400);
        states.Add("west virginia", 0.0300);
        states.Add("wisconsin", 0.0400);
        states.Add("wyoming", 0);
    }
    
    // public void inputKey() {
    //     // uses the input from user to get dictionary key
    //     Console.WriteLine("");
    //     Console.WriteLine("Please use lower cases :)");
    //     Console.Write("What state do you reside in: ");
    //     string input = Console.ReadLine();
    // } 
}