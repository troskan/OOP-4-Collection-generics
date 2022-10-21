using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_generics
{
    public class Employee
    {
        //ID, Name, Gender, Salary
        public string Name {get; set;}
        public int Id {get; set;}
        public string Gender {get; set;}
        public decimal Salary {get; set;}
        public Employee(string name, int id, string gender, decimal salary)
        {
            this.Name = name;
            this.Id = id;
            this.Gender = gender;
            this.Salary = salary;
        }

    }
}
