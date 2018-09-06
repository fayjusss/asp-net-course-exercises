using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExercise
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.Id = 1;
            person1.Name = "Tom";

            person2.Id = 2;
            person2.Name = "Marry";

            Console.WriteLine("ID: {0} Name: {1}", person1.Id, person1.Name);
            Console.WriteLine("ID: {0} Name: {1}", person2.Id, person2.Name);
            Console.ReadLine();
        }
    }

}
