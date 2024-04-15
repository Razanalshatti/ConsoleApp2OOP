// See https://aka.ms/new-console-template for more information

// C# OOP 
// task 1 
class Student
{
    public string Name { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }
    
    public Student(string name,string major,double gpa)
    {
        Name = name;
        Major = major;
        GPA = gpa;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"GPA: {GPA:F2}"); // formatted student summary 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Razan Alshatti", "Computer engineer", 3.5);

        student1.DisplayInfo();
    }
}

