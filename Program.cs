class Student
{
    public string Name;
    public int Mark;

    public Student(string name, int mark)
    {
        Name = name;
        Mark = mark;
    }
}

class Program
{
    static void Main(string[] args)
    {

        List<Student> students = new List<Student>
   {
       new Student("Losman", 78),
       new Student("Sipho", 45),
       new Student("Amahle", 92),
       new Student("Tumi", 60),
       new Student("Karabo", 33)
   };

        students.Add(new Student("Thabo", 55));
        students.Add(new Student("Zanele", 48));

        /*
        Method syntax

        // Students who passed (mark >= 50)
        var passed = students.Where(s => s.Mark >= 50);

        // Just their names
        var passedNames = students.Where(s => s.Mark >= 50).Select(s => s.Name);

        // Highest mark
        var topStudent = students.OrderByDescending(s => s.Mark).First();

        // Average mark
        double average = students.Average(s => s.Mark);

        // Sorted by mark, descending
        var ranked = students.OrderByDescending(s => s.Mark);
        */

        // Query syntax

        var passed = from s in students
                     where s.Mark >= 50
                     select s;

        var topStudent = (from s in students
                          orderby s.Mark descending
                          select s).FirstOrDefault();
        if (topStudent == null)
        {
            Console.WriteLine("No students found.");
            return;
        }

        double average = (from s in students
                          select s.Mark).Average();

        Console.WriteLine("Passed students:");
        foreach (var s in passed)
        {
            Console.WriteLine($"- {s.Name}: {s.Mark}");
        }

        Console.WriteLine($"\nTop student: {topStudent.Name} ({topStudent.Mark})");
        Console.WriteLine($"Class average: {Math.Round(average, 2)}");
    }

}