using System;

class Program
{
    static void Main(string[] args)
    {


         List<int> ListNumber = new List<int>(); // create a new list

         // Please note we could use a do-while loop here instead
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                ListNumber.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in ListNumber)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is:" + sum);

        // Part 2: Compute the average
    
        // Notice that we first cast the sum variable to be a float. Otherwise, because
        // both the sum and the count are integers, the computer will do integer division
        // and I will not get a decimal value (even though it puts the result into a float variable).

        // By making one of the variables a float first, the computer knows that it has to
        // do the floating point division, and we get the decimal value that we expect.
        float average = ((float)sum) / ListNumber.Count;
        Console.WriteLine($"The average is:" + average);

        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list
        
        int max = ListNumber[0];

        foreach (int number in ListNumber)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
                Console.WriteLine($"The largest number is:" + max);
            }
        }

        int smallestPositive = ListNumber.Where(num => num > 0).DefaultIfEmpty(0).Min();
        if (smallestPositive == 0)
        {
            Console.WriteLine("No positive number found in the list.");
        }
        else
        {
            Console.WriteLine("The smallest positive number is: " + smallestPositive);
        }

        ListNumber.Sort(); 

        foreach (int num in ListNumber)
        {
            Console.Write(num + " ");
        }
        


    }
}