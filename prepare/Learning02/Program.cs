using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 1999;
        job1._endYear = 2012;
        
        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "Toys-R-Us";
        job2._startYear = 2012;
        job2._endYear = 2025;

        Resume resume = new Resume();
        resume._name = "Kevin";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResumeInfo();


    }
}