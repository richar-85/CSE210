using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment("Samuel Bennett", "Multiplication");
        //student1.SetStudent("Samuel Bennett");
        //student1.SetTopic("Multiplication");
        Console.WriteLine(student1.GetSummary());

        MathAssignment student2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        //student2.SetSection("7.3");
        //student2.SetProblems("8-19");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());

        WritingAssignment student3 = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II");
        //student1.SetStudent("Richard Bennett");
        //student1.SetTopic("European History");
        //student3.SetTitle("The Cause of World War II");
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());

    }
}