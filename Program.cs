﻿using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>() { "adam", "amy" };

            employees.Add("barbara");
            employees.Add("billy");

            Console.WriteLine("My employees are:");
            Console.WriteLine("***************");
            
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}

