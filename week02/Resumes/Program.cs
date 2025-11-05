using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Centauro";
        job1._jobTitle = "SallesMan";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();

        job2._company = "Lince Tech";
        job2._jobTitle = "Programer";
        job2._startYear = 2020;
        job2._endYear = 2021;

        job2.Display();

        Resume alexResume = new Resume();

        alexResume._name = "Alex";
        alexResume._jobs.Add(job1);
        alexResume._jobs.Add(job2);

        alexResume.Display();
    }
}