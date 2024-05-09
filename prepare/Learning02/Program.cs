using System;

class Program
{
    static void Main(string[] args)
    {   
        
   



    
        Job job1 = new Job
        {
            _company = "Microsoft",
            _jobTitle = "Software Engineer",
            _startYear = 2019,
            _endYear = 2022
        };

        Job job2 = new Job
        {
            _company = "Apple",
            _jobTitle = "Manager",
            _startYear = 2022,
            _endYear = 2023
        };

        Resume myResume = new Resume
        {
            _name = "John Doe"
        };

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        Console.ReadLine();
    }
}