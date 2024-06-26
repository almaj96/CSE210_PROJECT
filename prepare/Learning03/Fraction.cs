
using System.Security.Cryptography.X509Certificates;

class Fraction
{
    private int Numerator ;
    private int Denominator; 

    public Fraction() // no parameters 
    {
        Numerator = 1;
        Denominator = 1;
    }

    public Fraction(int numerator) // parameters returning a denominator under the denominator
    {
        this.Numerator = numerator;
        Denominator = 1; // Denominator is always initialized to 1
    }

    public Fraction(int numerator, int denominator)
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }



    public int Numerator1
   {
       get { return Numerator; }
       set { Numerator = value; }
   }

   public int Denominator1
   {
       get { return Denominator; }
       set { Denominator = value; }
   }

   public string GetFractionString()
   {
       return $"{Numerator}/{Denominator}";

   }

   public double GetDecimalValue()
   {
       
       return (double) Numerator / Denominator;

   }
}
