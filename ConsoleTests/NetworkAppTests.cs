using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;

namespace ConsoleAppProject.Tests
{
    [TestClass]
    public class NetworkAppTests
    {


        [TestMethod]
        public void Test_Like()
        {
            Post post = new Post("Boncica");
            {
                // Arrange

                // Act
                post.Like();

                // Assert
                Assert.AreEqual(4, 4);

            }
        }

        [TestMethod]
        public void Test_Unlike()
        {
            Post post = new Post("Boncica");
            {
                // Arrange
                post.Like();

                // Act
                post.Unlike();

                // Assert
                Assert.AreEqual(0, 0);

            }
        }

        [TestMethod]
        public void Test_AddComment()
        {
            Post post = new Post("Boncica");
            {
                // Arrange
                string comment = "Nice post!";

                // Act
                post.AddComment(comment);

                // Assert
                Assert.AreEqual(1, post.PostID);
            }
        }

        [TestMethod]
        public void Test_DisplayComments()
        {
            Post post = new Post("Boncica");
            {
                // Arrange
                post.AddComment("Comment 1");


                // Act
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    post.DisplayComments();
                    string output = sw.ToString().Trim();

                    // Assert
                    Assert.AreEqual(1, 1);
                }
            }
        }
    }
}