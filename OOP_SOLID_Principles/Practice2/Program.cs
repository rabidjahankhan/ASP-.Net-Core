using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\USER\source\repos\OOP_SOLID_Principles\Practice2\salarysheet.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string maxName = "";
            int maxSalary = int.MinValue;

            string minName = "";
            int minSalary = int.MaxValue;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length == 2)
                {
                    string name = parts[0];
                    int salary;

                    if (int.TryParse(parts[1], out salary))
                    {
                        if (salary > maxSalary)
                        {
                            maxSalary = salary;
                            maxName = name;
                        }
                        if (salary < minSalary)
                        {
                            minSalary = salary;
                            minName = name;
                        }
                    }
                }
            }

            Console.WriteLine($"Max: {maxName}\t{maxSalary}");
            Console.WriteLine($"Min: {minName}\t{minSalary}");
        }
    }
}
