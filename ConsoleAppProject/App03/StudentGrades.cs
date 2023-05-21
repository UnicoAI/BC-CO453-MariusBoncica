using System;
using System.Linq; // Used for Min and Max Calculations from Array
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This program allows a user to perform a range of Student Grade tasks, such as Inputting and Outputting Marks, Generating Grade Profiles and Statistics for this data.
    /// </summary>
    /// <author>
    /// Marius Boncica
    /// </author>
    public class StudentGrades
    {
        // Constants
        public const int LowestMark = 0; // Lowest Mark Overall
        public const int LowestGradeD = 40; // Lowest Grade D Boundary
        public const int LowestGradeC = 50; // Lowest Grade C Boundary
        public const int LowestGradeB = 60; // Lowest Grade B Boundary
        public const int LowestGradeA = 70; // Lowest Grade A Boundary
        public const int HighestMark = 100; // Highest Mark Overall

        // Properties
        public string[] Students { get; set; } // Students Array
        public int[] Marks { get; set; } // Marks Array
        public int[] GradeProfile { get; set; } // GradeProfile Array
        public double Mean { get; set; } // Mean Mark Variable
        public int Minimum { get; set; } // Minimum Mark Variable
        public int Maximum { get; set; } // Maximum Mark Variable

        /// <summary>
        /// Runs the required functions in the correct order, allowing for the program to operate correctly.
        /// </summary>
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("1. Input Marks"); // Input Marks
            Console.WriteLine("2. Output Marks"); // Output Marks
            Console.WriteLine("3. Output Stats"); // Output Stats
            Console.WriteLine("4. Output Grade Profile"); // Output Grade Profile
            Console.WriteLine("5. Quit"); // Quit Application
            Console.WriteLine();
            Console.Write("Enter Option Number > ");
            string selectedOption = Console.ReadLine(); // Read the User Input from the Console

            switch (selectedOption) // Switch and Case Method for Option Selection
            {
                case "1": // Input Marks
                    Console.WriteLine("You have selected: Input Marks");
                    InputMarks();
                    break;
                case "2": // Output Marks
                    Console.WriteLine("You have selected: Output Marks");
                    OutputMarks();
                    break;
                case "3": // Output Stats
                    Console.WriteLine("You have selected: Output Stats");
                    OutputStats();
                    break;
                case "4": // Output Grade Profile
                    Console.WriteLine("You have selected: Output Grade Profile");
                    OutputGradeProfile();
                    break;
                case "5": // Quit Application
                    Console.WriteLine("You have selected: Quit");
                    Program.Menu();
                    break;
                default: // Invalid Input
                    Console.WriteLine("Invalid Input: Please specify an option from the list above");
                    // Run Function
                    break;
            }
        }
        public StudentGrades() // Constructor of StudentGrades
        {
            Students = new[] // Adds 10 Students to the Students Array List.
            {
                "Marius", "Daniel", "Boncica", "Martin", "Biden", "Putin", "Biden", "Iohanis", "Macron", "Smith"
            };

            GradeProfile = new int[(int)Grades.A + 1]; // Creates an empty Grade Profile for each Student
            Marks = new int[Students.Length]; // Creates a Marks Array for each Student
        }

        /// <summary>
        /// Allows the user to input an individual mark for each Student, and for this to be stored in the Array.
        /// </summary>
        public void InputMarks()
        {
            ConsoleHelper.OutputHeading("Student Grades");
            int index = 0; // Counter

            foreach (var student in Students) // Loops Input for each Student in Students Array List
            {
                int mark = (int)ConsoleHelper.InputNumber($" Enter Mark for {student} > ", 0, 100);
                Marks[index] = mark; // Allocates Mark to specific Student via Array Index
                index++; // Increment Counter
            }
            Run(); // Show Menu
        }

        /// <summary>
        /// Allows the user to output a list of marks for all Students, showing their Mark and Calculated Grade.
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputHeading("Student Grades");
            int index = 0; // Counter Value

            foreach (var student in Students) // Loops Output for each Student in Students Array List
            {
                Grades grade = ConvertToGrade(Marks[index]);
                Console.WriteLine($"{student}'s Results\n Mark: " +Marks[index] +" | Grade: " +grade);
                index++; // Increment Counter
            }
            Run(); // Show Menu
        }

        /// <summary>
        /// This method performs the Mark to Grade conversion, by determining what Grade Boundary the Student is in, based on their Mark.
        /// </summary>
        public static Grades ConvertToGrade(int mark)
        {
            // Grade F
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }

            // Grade D
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }

            // Grade C
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }

            // Grade B
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }

            // Grade A
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else return Grades.F; // Allows scope for Invalid Input, where the Grade cannot be determined
        }

        /// <summary>
        /// Calculates the Mean, Minimum, and Maximum Marks from the Array by using Linq and Formulas.
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;
            foreach (int mark in Marks) // Loops Calculation for each Mark in Marks Array List
            {
                total += mark;
            }
            Mean = total / Marks.Length;
            Minimum = Marks.Min(); // Calculates Minimum Mark from Array using Linq
            Maximum = Marks.Max(); // Calculates Maximum Mark from Array using Linq
        }

        /// <summary>
        /// This method outputs the Statistics of the Mean, Minimum, and Maximum Mark calculated.
        /// </summary>
        public void OutputStats()
        {
            CalculateStats();
            ConsoleHelper.OutputHeading("Student Grades");
            Console.WriteLine("Mean Mark: " +Mean);
            Console.WriteLine("Minimum Mark: " +Minimum);
            Console.WriteLine("Maximum Mark: " + Maximum);
            Run(); // Show Menu
        }

        /// <summary>
        /// This method calculates the overall Grade Profile of each Grade, including the count of students who have attained each grade, and the percentage.
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++) // Loops Calculation for each Grade in GradeProfile Array List
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        } 

        /// <summary>
        /// This method will output the overall Grade Profile of each Grade, as calculated in the CalculateGradeProfile() method.
        /// </summary>
        public void OutputGradeProfile()
        {
            CalculateGradeProfile();
            ConsoleHelper.OutputHeading("Student Grades");

            Grades grade = Grades.F;

            foreach (int count in GradeProfile) // Loops Output for each Count from GradeProfile
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} Profile\n Percentage: {percentage}% | Student Count: {count}");
                grade++;
            }
            Run(); // Show Menu
        }

        public Grades Grades
        {
            get => default;
            set
            {
            }
        }
    }
}
