using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 4: Job1 & Job2 class 'instance'
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Step 4: Display job company using dot notation to access the 'member variable'
        //Console.WriteLine($"{job1._company}");
        //Console.WriteLine($"{job2._company}");

        // Step 7: Resume class 'instance'
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Step 7: Add jobs created earlier to the list of jobs in the resume object
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();

        // Step 5: New 'method' call for job details 
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

    }


}