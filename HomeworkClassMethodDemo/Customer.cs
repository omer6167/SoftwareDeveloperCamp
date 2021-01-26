using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClassMethodDemo
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Sex { get; set; }
         
        public Customer(int id, string firstName, string lastName, bool sex)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
        }

        public override string ToString()
        {
            string call = Sex ? "Mr" : "Ms";
            return $"Id: {Id}, Name: {call} {FirstName} {LastName}";
        }
    }
}
