
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_Data
{
    class program
    {
        static void Main(string[] args)
        {
            int a=0;
            List<Class1> std = new List<Class1>();
            while (true)
            {
                Console.WriteLine("Enter:\n 1: for input\n 2: for printing data\n 3: for student roll\n 4: to exit");
                int w = Convert.ToInt32(Console.ReadLine());
                if (w == 1)
                {
                    Class1 student = new Class1();
                    Console.WriteLine("please enter information about the student\n");
                    Console.WriteLine("Student :" + (a + 1));
                    Console.Write("Enter the first Name: ");
                    student.FirstName = Console.ReadLine();

                    Console.Write("enter the last Name: ");
                    student.LastName = Console.ReadLine();
                    Console.Write("enter the roll number: ");
                    student.Roll = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Marks: ");
                    student.Marks = Convert.ToDouble(Console.ReadLine());
                    std.Add(student);
                    Console.Clear();
                    a++;
                }
                else if (w == 2)
                {
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine("Student: " + (i + 1) + "\n");
                        Console.WriteLine($"FirstName:{std[i].FirstName}");
                        Console.WriteLine($"LastName:{std[i].LastName}");
                        Console.WriteLine($"Roll:{std[i].Roll}");
                        Console.WriteLine($"Marks:{std[i].Marks}");
                        Console.WriteLine();
                    }
                }
                else if (w == 3)
                {
                    Console.WriteLine("Enter the sudent roll: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    int z = 0;
                    for (int i = 0; i < a; i++)
                    {
                        if (std[i].Roll == q)
                        {
                            Console.WriteLine($"FirstName:{std[i].FirstName}");
                            Console.WriteLine($"LastName:{std[i].LastName}");
                            Console.WriteLine($"Roll:{std[i].Roll}");
                            Console.WriteLine($"Marks:{std[i].Marks}");
                            Console.WriteLine();
                            z++;
                            break;
                        }
                    }
                    if (z == 0) Console.WriteLine("The student not present");
                }
                else if (w == 4)
                    break;
                else Console.WriteLine("Invalid Input");

            }


        }
    }
}