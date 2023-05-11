using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleTests
{
    [TestClass]
    public class StudentGradesUnitTest
    {
        /// <summary>
        /// Test Method used for testing that the Mark 0 is assigned to the Grade F Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert0ToGradeF()
        {
            // Arrange
            Grades expectedGrade = Grades.F;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(0);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 39 is assigned to the Grade F Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert39ToGradeF()
        {
            // Arrange
            Grades expectedGrade = Grades.F;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(39);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 40 is assigned to the Grade D Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert40ToGradeD()
        {
            // Arrange
            Grades expectedGrade = Grades.D;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(40);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 49 is assigned to the Grade D Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert49ToGradeD()
        {
            // Arrange
            Grades expectedGrade = Grades.D;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(49);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 50 is assigned to the Grade C Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert50ToGradeC()
        {
            // Arrange
            Grades expectedGrade = Grades.C;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(50);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 59 is assigned to the Grade C Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert59ToGradeC()
        {
            // Arrange
            Grades expectedGrade = Grades.C;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(59);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 60 is assigned to the Grade B Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert60ToGradeB()
        {
            // Arrange
            Grades expectedGrade = Grades.B;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(60);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 69 is assigned to the Grade B Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert69ToGradeB()
        {
            // Arrange
            Grades expectedGrade = Grades.B;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(69);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 70 is assigned to the Grade A Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert70ToGradeA()
        {
            // Arrange
            Grades expectedGrade = Grades.A;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(70);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Test Method used for testing that the Mark 100 is assigned to the Grade A Boundary correctly
        /// </summary>
        [TestMethod]
        public void Convert100ToGradeA()
        {
            // Arrange
            Grades expectedGrade = Grades.A;

            // Act
            Grades actualGrade = StudentGrades.ConvertToGrade(100);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
    }
}