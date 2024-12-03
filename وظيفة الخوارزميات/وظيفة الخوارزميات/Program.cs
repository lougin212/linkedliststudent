using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Test1 { get; set; }
    public double Test2 { get; set; }
    public string Grade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
       
        while (true)
        {
            Student student = new Student();
            Console.WriteLine($"Enter student details {students.Count + 1}:");

            student.Id = students.Count + 1;

            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.Write("test 1: ");
            student.Test1 = double.Parse(Console.ReadLine());

            Console.Write("test 2: ");
            student.Test2 = double.Parse(Console.ReadLine());

            double totalScore = (student.Test1 + student.Test2) / 2;

            if (totalScore < 50)
                student.Grade = "Fail";
            else if (totalScore < 70)
                student.Grade = "Good";
            else if (totalScore < 85)
                student.Grade = "Very Good";
            else
                student.Grade = "Excellent";

            students.Add(student);

            Console.Write("Do you want to enter another student? yes/no): ");
            string response = Console.ReadLine();
            if (response.ToLower() != "yes")
                break;
        }
        //students sorted by name
        //students.Sort((x, y) => x.Name.CompareTo(y.Name));
        //Console.WriteLine("\nStudents sorted by name:");
        //foreach (Student student in students)
        //{
        //    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Test1: {student.Test1}, Test2: {student.Test2}, Grade: {student.Grade}");
        //}

        // Students sorted by total score
        Console.WriteLine("\nStudents sorted by total score:");
        students.Sort((x, y) =>
        {
            double xTotal = (x.Test1 + x.Test2) / 2;
            double yTotal = (y.Test1 + y.Test2) / 2;
            return yTotal.CompareTo(xTotal);
        });

        foreach (Student student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Test1: {student.Test1}, Test2: {student.Test2}, Grade: {student.Grade}");
        }
    }
}
