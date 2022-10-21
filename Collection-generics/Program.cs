using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee daniel = new Employee("Daniel", 239, "Man", 28.3999m);
            Employee tobias = new Employee("Tobias", 183, "Man", 33.2450m);
           
            Employee sally = new Employee("Sally", 132, "Kvinna", 38.2350m);
            Employee kim = new Employee("Kim", 215, "Kvinna", 32.8850m);
            Employee hilda = new Employee("Hilda", 189, "Kvinna", 32.8850m);
            

            Stack persons = new Stack();
            persons.Push(daniel);
            persons.Push(tobias);
            persons.Push(sally);
            persons.Push(kim);
            persons.Push(hilda);

            foreach (Employee item in persons)
            {
                //Console.WriteLine($"Items left in the stack: {persons.Count}");
                Console.Write($"{item.Name} - {item.Id} - {item.Gender} - {item.Salary}");
                Console.WriteLine($"\nItems left in the stack: {persons.Count}");
            }
            Console.WriteLine("----------------------------");
        }
    }
}
