using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    internal class Person
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address PresentAddress { get; set; } // association relationship


        //public Person(string firstName, string middleName, string lastName)  // Constructor
        //{
        //    FirstName = firstName;
        //    MiddleName = middleName;
        //    LastName = lastName;
        //}

        //public Person(string firstName, string lastName) // same constructor name, but argument change
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}

        //public Person() // Default constructor 
        //{

        //}

        //private string firstName;
        //public string FirstName
        //{
        //    get { return firstName; }
        //    set
        //    {
        //        if (value.Length >= 2)
        //        {
        //            firstName = value;
        //        }
        //    }
        //}

        //public string middleName;
        //public string lastName;

        //public void SetFirstName(string firstName)
        //{
        //    if (firstName.Length >= 2)
        //    {
        //        this.firstName = firstName;
        //    }
        //}

        //public string GetFirstName()
        //{
        //    return firstName;
        //}

        //public void SetMiddleName(string middleName)
        //{
        //    if (middleName.Length >= 5)
        //    {
        //        this.middleName = middleName;
        //    }
        //}
        //public string GetMiddleName()
        //{
        //    return middleName;
        //}

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}
