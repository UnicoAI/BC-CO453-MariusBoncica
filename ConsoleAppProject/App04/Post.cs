using System;
using System.Collections.Generic;
using System.Text;
/// <author>
/// Daniel Boncica
/// version 2.0 Refactored
/// </author>
namespace ConsoleAppProject.App04
{
    //initiat variables 
    public class Post
    {
        public int PostID { get; }

        private int likes;

        private readonly List<String> comments;

        private static int instances = 0;

        // username of the post's author
        public String Username { get; }

        public DateTime Timestamp { get; }

        //use instances to pass ID of author to ad allocate comments
        public Post(string author)
        {
            instances++;
            PostID = instances;

            this.Username = author;
            Timestamp = DateTime.Now;
            likes = 0;
            comments = new List<String>();
        }

        // The method for liking a post
        public void Like()
        {
            likes++;
        }


        ///<summary>
        /// Method to unlike a post by decreasing the 'Like' count.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }
        //method to ass a comment

        public void AddComment(String text)
        {
            comments.Add(text);
        }
        //method to format time and display elapsed time
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
        //method to display comments
        public void DisplayComments()
        {
            string acomment = comments.ToString();
            Console.WriteLine($"{acomment}");
        }
        //method to display post
        public virtual void Display()
        {
            Console.WriteLine($"Post ID: {PostID}");
            Console.WriteLine();
            Console.WriteLine($"Author: {Username}");
            Console.WriteLine();
            Console.WriteLine($"Time Elpased: {FormatElapsedTime(Timestamp)}");

            if (likes > 0)
            {
                Console.WriteLine($"Likes: {likes}");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("No comments.");
            }
            else
            {
                Console.WriteLine($"Comment(s): {comments.Count} ");
            }
        }


    }
}