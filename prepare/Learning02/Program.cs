using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 1999;
        job1._endYear = 2005;


        Job job2 = new Job();
        job2._jobTitle = "Frontend Developer";
        job2._company = "Microsoft";
        job2._startYear = 2007;
        job2._endYear = 2010;

        Resume resume1 = new Resume();
        resume1._name = "Noah Heaven";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        job1.DisplayJobDetails();
        resume1.Display();
    }
}