using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2014;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "IT";
        job2._company = "amazon.com";
        job2._startYear = 2018;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Marvin Canastuj";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}