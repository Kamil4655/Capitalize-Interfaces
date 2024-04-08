using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kamil", "Qehremanov");

            
            Console.WriteLine($"Student Id: {student.Id}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student Surname: {student.Surname}");
            Console.WriteLine($"Student CodeEmail: {student.CodeEmail}");
        }
    }
}
