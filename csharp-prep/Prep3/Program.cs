using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random ();
        
        int Magicnumber = randomGenerator.Next(1,101);

        int guess = -1 ; 

         while (guess != Magicnumber)

           {

                Console.WriteLine("what is your magic guess?");

                string guess1 = Console.ReadLine();
                guess = int.Parse(guess1);
        
        

        
                if (guess > Magicnumber)
                {
                Console.WriteLine("Lower");
                
                }

                else if (guess < Magicnumber)
                {
                Console.WriteLine("Higher");
                
                }
                else 
                {
                Console.WriteLine("Felicidad you got it");
                }


    
            }

            

            
            
        
             
         
         
         

        
        
         

        
    }
}