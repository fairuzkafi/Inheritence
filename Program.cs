using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Fairuz", 20);
            person.GetNameAndAge();
            Console.WriteLine();
            Teacher teacher = new Teacher("Kamarudin", 35, "190302", "Pemrograman");
            teacher.GetNameAndAge();
            Console.WriteLine();
            Students students = new Students("Fairuz", 20, "19.11.2623", "fairuz.kafi@students.amikom.ac.id");
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}