using System;

using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Marius Boncica
    /// Version 2 Student Marks Application
    /// </summary>
    public class StudentGrades
    {
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }

        public const int TotalStudents = 10;

        public int Total { get; set; }
        public double Mean { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void Run()
        {
            ConsoleHelper.OutputHeading("Student Grades");
            Console.ForegroundColor = ConsoleColor.Cyan;

            OutputMenuChoices();
        }
        public StudentGrades()
        {
            Students = new string[TotalStudents]
            {
                "Daniel", "Boncica", "Marius", "Boris", "Vladimir", "Biden", "Zelensky", "Sara", "Dave", "Richard"
            };
            Marks = new int[]
            {
                100, 70, 60, 20, 60, 12, 60, 40, 40, 40
            };

            GradeProfile = new int[5];
        }

        public void OutputMenuChoices()
        {
            string[] choices =
            {
                "Input Marks", "Mean Mark", "Grade Percentage", "Min Max Mark", "Exit"
            };

            int choice;
            choice = ExecuteChoice(choices);
        }

        private int ExecuteChoice(string[] choices)
        {
            int choice;
            do
            {
                choice = ConsoleHelper.SelectChoice(choices);
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        InputMarks();
                        OutputGrades();
                        break;
                    case 2:
                        MeanMark();
                        break;
                    case 3:
                        GradePercentage();
                        break;
                    case 4:
                        MinMaxmark();
                        break;
                    case 5:
                        exit();
                        break;
                    default:
                        break;
                }

            }
            while (choice != 5);
            return choice;
        }

        public Grades MarkToGrade(int mark)
        {
            if (mark >= 0 && mark < 39)
            {
                return App03.Grades.F;
            }
            if (mark >= 40 && mark < 49)
            {
                return App03.Grades.D;
            }
            if (mark >= 50 && mark < 59)
            {
                return App03.Grades.C;
            }
            if (mark >= 60 && mark < 69)
            {
                return App03.Grades.B;
            }
            else
            {
                return App03.Grades.A;
            }
        }

        private void InputMarks()
        {
            Console.WriteLine("Please Enter a Mark for Each of the Students \n");
            int index = 0;

            foreach (string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"{name} insert mark > ", 0, 100);
                Marks[index] = mark;
            };
        }

        public void MeanMark()
        {
            foreach (int mark in Marks)
            {
                Total += mark;
            }

            Mean = Total / TotalStudents;
        }

        static void GradePercentage()
        {
            int mark = (int)ConsoleHelper.InputNumber($"Enter Mark > ", 0, 100);
            int sum = mark;
            Console.WriteLine($"{mark}%");
        }

        public void MinMaxmark()
        {
            Min = Marks[0];
            Max = Marks[0];
            foreach (int mark in Marks)
            {
                if (mark < Min)
                {
                    Min = mark;
                }
                else if (mark > Max)
                {
                    Max = mark;
                }
            }
        }

        private void exit()
        {
            System.Environment.Exit(1);
        }

        private void OutputGrades()
        {
            for (int i = 0; i < TotalStudents; i++)
            {
                int mark = Marks[i];
                Grades grade = MarkToGrade(mark);

                Console.WriteLine($"{Students[i]} Mark = {Marks[i]} Grade = {grade}");
            }
        }
    }
}