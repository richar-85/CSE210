// Math assignment is an assignment
using System.Reflection.PortableExecutable;

public class MathAssignment : Assignment
{
    private string _section = "";
    private string _problems = "";

    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;

    }

    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}