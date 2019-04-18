using System;
using System.Collections.Generic;

namespace Company
{
    public class Company
    {
        // Public Classes

        public string Name { get; }
        public DateTime FoundedOn { get; }

        // Constructors

        public Company(string name, DateTime founded)
        {
            Name = name;
            FoundedOn = founded;
        }
        public List<Employee> Employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}