using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;
using ConsoleAppProject.App04;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

    // This is the method to be called from 
    // Progrram class to run this app
    public void Run()
    {
        DisplayMenu();
    }

    // First method called when the app runs
    public void DisplayMenu()
    {
        ConsoleHelper.OutputHeading("App 4 - Social Network");

        string[] choices = new string[]
        {
            "Post Image", "Post Message",
            "Display All posts", "Remove Post", "Add Comment to Post",
            "Like A Post",  "Unlike A Post", "Quit"
        };

        bool wantToQuit = false;

        do
        {
            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1: AddPhoto(); break;
                case 2: PostMessage(); break;
                case 3: DisplayAll(); break;
                case 4: RemovePost(); break;
                case 5: AddCommentsToPost(); break;
                case 6: LikePost(); break;
                case 7: UnlikeAPost(); break;
                case 8: wantToQuit = true; break;
            }
        }
        while (!wantToQuit);

    }

    // Code for posting a photo
    private void AddPhoto()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("\nEnter the photo filename: ");
        string filename = Console.ReadLine();

        Console.WriteLine("\nEnter the photo caption: ");
        string caption = Console.ReadLine();

        PhotoPost photopost = new PhotoPost(name, filename, caption);
        news.AddPhotoPost(photopost);
    }

    private void DisplayAll()
    {
        news.Display();
    }

    // Code for posting a message
    private void PostMessage()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your message: ");
        string message = Console.ReadLine();

        MessagePost post = new MessagePost(name, message);
        news.AddMessagePost(post);
    }

    // Code for removing a post
    private void RemovePost()
    {
        ConsoleHelper.OutputTitle($"Removing a post");

        int id = (int)ConsoleHelper.InputNumber("Please enter the Post ID: ");

        news.RemovePost(id);

    }

    // Code for adding a comment to a post
    public void AddCommentsToPost()
    {
        int id = (int)ConsoleHelper.InputNumber("Please enter the Post ID: ");

        Console.WriteLine("Please enter a comment: ");
        string comment = Console.ReadLine();

        news.AddACommentToAPost(id, comment);


    }

    // Code for liking a post
    public void LikePost()
    {
        int id = (int)ConsoleHelper.InputNumber("Please enter the Post ID: ");

        news.LikeAPost(id);
    }

    // Code for unliking a post
    public void UnlikeAPost()
    {
        int id = (int)ConsoleHelper.InputNumber("Please enter the Post ID: ");

        news.UnlikePost(id);
    }

}

}
