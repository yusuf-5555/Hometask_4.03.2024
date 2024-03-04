public class Teacher : Person
{
    int _numCourses = 0;
    List<string> _courses = new List<string>();

    public Teacher(string name, string address) : base(name, address)
    {
    }

    public bool AddCourse(string course)
    {
        foreach (var item in _courses)
        {
            if(item==course)
            {
                return false;
            }
        }
        _courses.Add(course);
        return true;
    }

    public bool RemoveCourse(string course)
    {
        foreach (var item in _courses)
        {
            if(item == course) return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"Teacher: {base.ToString()}";
    }
}