using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Daniel Boncica
    /// version 2.0 Refactored
    /// </author>
    public class MessagePost : Post
    {

        // an arbitrarily long, multi-line message
        public String Message { get; }

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// Using Inheritance Declared using base clss
        /// </summary>
       
        public MessagePost(String author, String text) : base(author)
        {
            Message = text;
        }
        //Method to display message
        public override void Display()
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine();

            base.Display();
        }
    }
}