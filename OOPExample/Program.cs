using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.HouseNumber = "123";
            address.Street = "Main St";
            address.City = "Dhaka";
            address.State = "Dhaka";
            address.ZipCode = "1212";
            address.Country = "Bangladesh";

            Person person1 = new Person();
            person1.PresentAddress = address;

            Address myAddress = person1.PresentAddress;
            string HouseNumber = myAddress.HouseNumber;

            //Person person1 = new Person(firstName:"Rabid", middleName:"Jahan", lastName:"Khan");
            //Person person2 = new Person(lastName: "Mahi", firstName: "Rabid");

            //string fullName = person1.GetFullName(); 
            //Console.WriteLine(fullName);  

            //string firstName = Console.ReadLine();
            //Person person1 = new Person();
            //person1.FirstName=firstName;


            //person1.middleName = "Jahan";
            //person1.lastName = "Khan";


            //Person person2 = new Person();

            //person2.FirstName=firstName;
            //person2.middleName = "Jahan";
            //person2.lastName = "Mahi";

            //Console.WriteLine(person1.GetFullName());
            //Console.WriteLine(person2.GetFullName());
            Console.ReadKey(); 
        }
    }
}
