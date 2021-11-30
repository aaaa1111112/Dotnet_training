using System;
class Student
{
    static void Main()
    {
        int i = 0;
        string a, q;
        string[,] detail = new string[100, 3];
        while (true)
        {
            Console.WriteLine("\nEnter:\n 1 for inserting data \n 2 for displaying all data \n 3 for searching roll number\n 4 for exiting ");
            a = Console.ReadLine();
            Console.Clear();
            if (a == "1")
            {
                Console.Write("Enter student name: ");
                detail[i, 0] = Console.ReadLine();
                Console.Write("Enter student class: ");
                detail[i, 1] = Console.ReadLine();
                Console.Write("Enter student roll: ");
                detail[i, 2] = Console.ReadLine();
                i++;
                Console.Clear();
            }
            else if (a == "2")
            {
                Console.WriteLine("The Student details are:\n");
                for (int w = 0; w < i; w++)
                {
                    Console.WriteLine("Student No:" + (w + 1));
                    Console.WriteLine("Name:" + detail[w, 0]);
                    Console.WriteLine("Class:" + detail[w, 1]);
                    Console.WriteLine("Roll:" + detail[w, 2]);
                    Console.WriteLine();
                }

            }
            else if (a == "3")
            {
                int b = 0;
                Console.Write("Enter Roll: ");
                q = Console.ReadLine();
                for (int w = 0; w <= i; w++)
                {
                    if (detail[w, 2] == q)
                    {
                        Console.WriteLine("Student Present:");
                        Console.WriteLine("Name:" + detail[w, 0]);
                        Console.WriteLine("Class:" + detail[w, 1]);
                        Console.WriteLine("Roll:" + detail[w, 2]);
                        Console.WriteLine();
                        b++;
                        break;
                    }
                }
                if (b == 0)
                {
                    Console.WriteLine("Student is not present");
                }

            }
            else if (a == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}