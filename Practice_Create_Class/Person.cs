using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Create_Class
{
    internal class Person
    {
        public bool Student { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }

        public void Introduce()
        {
            if (Student == true)
            {
                Console.WriteLine("\nStudent Information:");
            }
            else
            {
                Console.WriteLine("\nTeacher Information:");
            }

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Date of Birth: " +  BirthDate);

        }

    }

}

