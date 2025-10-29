using System;

class Program
{
    static void Main(string[] args)
    {

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        
        Job job1 = new Job();

        job1._company = "Waltmart";
        job1._jobTitle = "Customer Service";
        job1._startYear = 1995;
        job1._endYear = 2003;

        Job job2 = new Job();
        job2._company = "Mc-Donnals";
        job2._jobTitle = "Customer Service";
        job2._startYear = 2003;
        job2._endYear = 2013;


        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();

     // Console.WriteLine($"{myResume._jobs[0]._jobTitle}"); testing acces to first job Title 



    }
}