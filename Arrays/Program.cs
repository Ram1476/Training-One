using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emp_Name = new string[5];
            Console.Write("Enter Employee_Name1: ");
            emp_Name[0] = Console.ReadLine();
            Console.Write("Enter Employee_Name2: ");
            emp_Name[1] = Console.ReadLine();
            Console.Write("Enter Employee_Name3: ");
            emp_Name[2] = Console.ReadLine();
            Console.Write("Enter Employee_Name4: ");
            emp_Name[3] = Console.ReadLine();
            Console.Write("Enter Employee_Name5: ");
            emp_Name[4] = Console.ReadLine();

            Console.WriteLine($"\nThe Provided Employee name_1 = {emp_Name[0]}");
            Console.WriteLine($"The Provided Employee name_2 = {emp_Name[1]}");
            Console.WriteLine($"The Provided Employee name_3 = {emp_Name[2]}");
            Console.WriteLine($"The Provided Employee name_4 = {emp_Name[3]}");
            Console.WriteLine($"The Provided Employee name_5 = {emp_Name[4]}");

            Console.ReadLine();

        }
    }
}
