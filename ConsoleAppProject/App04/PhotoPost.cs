using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// Author:  Marius Boncica
    ///  version 2.0 Refactored
    ///</author> 
    //Using Inheritance

    ///<summary>
    /// Constructor for objects of class PhotoPost.
    ///</summary>
    public class PhotoPost : Post
        {

            // the name of the image file
            public String Filename { get; set; }

            // a one line image caption
            public String Caption { get; set; }


           
           
            public PhotoPost(String author, String filename, String caption) : base(author)
            {
                this.Filename = filename;
                this.Caption = caption;
            }
        //Method to diplay the filename and caption
            public override void Display()
            {
                Console.WriteLine();
                Console.WriteLine($"Filename: {Filename}");
                Console.WriteLine();
                Console.WriteLine($"Caption: {Caption}");
                Console.WriteLine();
                base.Display();
            }

        }
    }