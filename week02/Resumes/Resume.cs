using System;

// Step 6: Resume class
public class Resume
{
    // Step 6: Resume class member variable for person's name and job's list
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Step 8: Display person's name and iterate through each job 'instances' in the job list and display them
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name} \nJobs: ");

        // Step 8: Add a Display method to the Resume class
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }

}