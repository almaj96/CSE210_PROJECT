using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1  = new Fraction (); 
        Console.WriteLine ($"Fraction value :{fraction1.Numerator1}/{fraction1.Denominator1}");


        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"Fraction value: {fraction2.Numerator1}/{fraction1.Denominator1}"); 

        Fraction fraction3 = new Fraction(6,7);
        Console.WriteLine($"Fraction value: {fraction3.Numerator1}/{fraction3.Denominator1}"); 

    // Changing values using setters
       fraction1.Numerator1 = 2;
       fraction1.Denominator1 = 3;

       fraction2.Numerator1 = 7;

       fraction3.Denominator1 = 6;
       fraction3.Numerator1 = 3 ; 

       // Displaying new values after using setters and also calling the method to display result 
      
       Console.WriteLine(fraction1.GetFractionString());
       Console.WriteLine(fraction2.GetFractionString());
       Console.WriteLine(fraction3.GetFractionString());


        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetDecimalValue()); 



        
    }
}