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

            //Print all objects in Stack
            foreach (Employee person in persons)
            {
                Console.WriteLine(person);
                Console.WriteLine($"Items left in the stack: {persons.Count}");
            }
            Console.WriteLine("----------------------------");


            int count = persons.Count; //Get length of Stack

            //Remove each object in list and print it.
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{persons.Pop()}");
                Console.WriteLine($"Items left in the stack: {persons.Count}");
            }

            //Add objects to stack.
            persons.Push(daniel);
            persons.Push(tobias);
            persons.Push(sally);
            persons.Push(kim);
            persons.Push(hilda);

            //Using peek as an example
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{persons.Peek()}");
            Console.WriteLine($"Items left in the stack: {persons.Count}");

            Console.WriteLine($"{persons.Peek()}");
            Console.WriteLine($"Items left in the stack: {persons.Count}");
            Console.WriteLine("----------------------------");
            
            //Does list contain Sally?
            var result = persons.Contains(sally) ? $"{sally.Name} is found." : "Item not found.";
            Console.WriteLine(result);
            Console.WriteLine("----------------------------");

            //Chapter 2
            List<Employee> listPerson = new List<Employee>();
            listPerson.Add(daniel);
            listPerson.Add(sally);
            listPerson.Add(kim);
            listPerson.Add(tobias);
            listPerson.Add(hilda);

            //Does kim exist in the list?
            result = listPerson.Contains(kim) ? $"{kim.Name} is found." : "Item not found.";
            Console.WriteLine(result);
            Console.WriteLine("----------------------------");

            //Does a male exist?
            Employee maleExists = listPerson.Find(x => x.Gender.Contains("Man"));
            Console.WriteLine(maleExists);
            Console.WriteLine("----------------------------");

            //How many males exist?
            List<Employee> searchResult = new List<Employee>();
            searchResult = listPerson.FindAll(y => y.Gender.Contains("Man"));
            foreach (Employee item in searchResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\tGood Bye!");
            Console.ReadKey();
        }
    }
}
