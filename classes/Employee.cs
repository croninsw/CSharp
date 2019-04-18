using System;

namespace Company
{
    public class Employee
    {
        // Public Classes

        private string FirstName { get; }
        private string LastName { get; }
        public string Title { get; set; }
        public DateTime DateStarted { get; set; }

        // Contstuctors

        public Employee(string lastName, string firstName) {
            LastName = lastName;
            FirstName = firstName;
        }

        public void Hire(string title) {
            DateStarted = DateTime.Now;
            Title = title;
        }
    }
}