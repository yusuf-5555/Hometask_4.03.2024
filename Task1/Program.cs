var person = new Person("Yusuf", "Mayak");
System.Console.WriteLine(person.ToString());
var student=new Student("Behruz", "Sino");
student.AddCourseGrade("Javascript",55);
student.AddCourseGrade("C++",77);
student.AddCourseGrade("C#",99);
student.PrintGrades();
System.Console.WriteLine(student.GetAverageGrade());
System.Console.WriteLine(student.ToString());

var teacher=new Teacher("Yusuf", "amijoo");
System.Console.WriteLine(teacher.ToString());
System.Console.WriteLine(teacher.AddCourse("C++"));
System.Console.WriteLine(teacher.AddCourse("Python"));
System.Console.WriteLine(teacher.AddCourse("C++"));
System.Console.WriteLine(teacher.AddCourse("Javascript"));
System.Console.WriteLine(teacher.RemoveCourse("SMM"));
