public class Student : Person
{

    int _numCourses = 0;
    List<string> _courses = new List<string>();
    List<int> _grades = new List<int>();
    public Student(string name, string address) : base(name, address)
    {
    }

    public void AddCourseGrade(string course, int grade)
    {
        _courses.Add(course);
        _grades.Add(grade);
    }

    public void PrintGrades()
    {
        foreach (var item in _grades)
        {
            System.Console.WriteLine(item);
        }
    }

    public double GetAverageGrade()
    {
        return _grades.Average();
    }

    public override string ToString()
    {
        return $"Student: {base.ToString()}";
    }
}