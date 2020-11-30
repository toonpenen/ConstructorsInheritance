using ConstructorsInheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student() {FirstName = "Toon", LastName = "ToonNM", Age = 42, Subject = "C#" };
            Student student = new Student("Toon","ToonNM");
            student.Age = 42;

            //student.FirstName = "Toon";
            //student.LastName = "ToonNM";
            //student.Age = 42;

            Console.WriteLine($"FirstName : {student.FirstName} LastName : {student.LastName} ");
        }
    }
}
