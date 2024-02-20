using System;
using System.Collections.Generic;
using StudentRegister.Models;

namespace StudentRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string continueProgram = "y";

            while (continueProgram == "y")
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add New Record");
                Console.WriteLine("2. Display All Records");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Which Action Do you want to perform ?");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        string isAdd = "y";

                        while (isAdd == "y")
                        {
                            Student student = new Student();
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("Add Student Detail");
                            Console.WriteLine("First Name:");
                            student.FirstName = Console.ReadLine();

                            Console.WriteLine("Last Name:");
                            student.LastName = Console.ReadLine();

                            Console.WriteLine("Age:");
                            student.Age = int.Parse(Console.ReadLine());

                            students.Add(student);
                            Console.WriteLine($"{student.FirstName} {student.LastName} is Added to the list.");
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("Do you want to add another Student?(y/n)");
                            isAdd = Console.ReadLine();
                        }
                        break;
                    case "2":
                        Console.WriteLine("----------------------------------------------------------------");

                        if (students.Count > 0)
                        {
                            Console.WriteLine("All Records");
                            Console.WriteLine("----------------------------------------------------------------");
                            foreach (Student item in students)
                            {
                                Console.WriteLine($"Name : {item.FirstName} {item.LastName} | Age : {item.Age}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Records in the List.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Action");
                        break;
                }

                Console.WriteLine("Press 'y' to continue 'n' to exit.");
                continueProgram = Console.ReadLine();
            }
            
        }
    }
}
