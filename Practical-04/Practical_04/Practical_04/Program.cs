using System;
using System.Linq;

namespace Practical_04
{
    class Student
    {
        public string Name;
        public decimal[] Marks=new decimal[5];
        public static decimal AverageMarks;
        public decimal CalculateAverageMarks()
        {
            decimal sum = 0;
            foreach(int m in Marks)
            sum += m;
            AverageMarks = sum / Marks.Length;
            return AverageMarks;
        }
        public string CalculateGrade(decimal marks)
        {
            string grade;
            switch(marks)
            {
                case > 90:
                    grade = "A";
                    break;
                case > 80:
                    grade = "B";
                    break;
                case > 70:
                    grade = "C";
                    break;
                case < 90:
                    grade = "D";
                    break;
            }
            return grade;
        }
    }
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("Enter Name:");
            s.Name = Console.ReadLine();
            for (int i = 0; i < s.Marks.Length; i++)
            {
                Console.WriteLine($"Enter Subject{i + 1} Marks:");
                s.Marks[i] = decimal.Parse(Console.ReadLine());
            }
            while(true)
            {
                Console.WriteLine("Option Menu");
                Console.WriteLine("1 - Aggregate: Displays the Name: Average marks");
                Console.WriteLine("2 - MinMark: Displays the minimum marks of the student");
                Console.WriteLine("3 - MaximumMark: Displays the maximum mark");
                Console.WriteLine("4 - Grade: Displays grade");
                Console.WriteLine("Choose Option:");
                try
                {
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case (int)Options.Aggregate:
                            Console.Clear();
                            Console.WriteLine($"Student Name: {s.Name}");
                            Console.WriteLine($"Average Marks {s.CalculateAverageMarks()}\n\n\n");
                            break;
                        case (int)Options.MinMark:
                            Console.Clear();
                            Console.WriteLine($"Minimum Marks: {s.Marks.Min()}\n\n\n");
                            break;
                        case (int)Options.MaximumMark:
                            Console.Clear();
                            Console.WriteLine($"Minimum Marks: {s.Marks.Max()}\n\n\n");
                            break;
                        case (int)Options.Grade:
                            Console.Clear();
                            decimal avgMrk = s.CalculateAverageMarks();
                            Console.WriteLine($"Grade: {s.CalculateGrade(avgMrk)}\n\n\n");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Wrong Option Chosen!!!\n\n\n");
                            break;
                    }
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
