using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> ();
            names.Add("Tareq");
            names.Add("Afsana");
            names.Add("Imtiaz");
            names.Add("Pulok");
            names.Add("Robin");
            names.Add("Samia");
            names.Add("Rupok");
            names.Add("Rabid");

            Console.WriteLine("Enter search text: ");
            string userInput = Console.ReadLine();

            var matched = names.Where(name => name.IndexOf(userInput, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if ( matched.Count > 0)
            {
                Console.WriteLine("Matched Names: " + string.Join(", ", matched));
            }
            else
            {
                Console.WriteLine("No match found.");
            }

        }
    }
}
