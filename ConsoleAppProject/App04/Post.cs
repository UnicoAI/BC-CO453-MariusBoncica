using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        public int PostID { get; }

        private int likes;

        private readonly List<String> comments;

        private static int instances = 0;

        // username of the post's author
        public String Username { get; }

        public DateTime Timestamp { get; }


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
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        public void AddComment(String text)
        {
            comments.Add(text);
        }

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

        public void DisplayComments()
        {
            string acomment = comments.ToString();
            Console.WriteLine($"{acomment}");
        }

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