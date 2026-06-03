using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "C# Programming Basics",
            "Code Academy",
            720);

        video1.AddComment(new Comment(
            "Alice",
            "This tutorial was very helpful!"));

        video1.AddComment(new Comment(
            "Bob",
            "Great explanation of classes."));

        video1.AddComment(new Comment(
            "Charlie",
            "I learned a lot from this."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Top 10 Travel Destinations",
            "Travel World",
            540);

        video2.AddComment(new Comment(
            "David",
            "Amazing places!"));

        video2.AddComment(new Comment(
            "Emma",
            "Adding these to my bucket list."));

        video2.AddComment(new Comment(
            "Frank",
            "Beautiful video quality."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Healthy Meal Prep Ideas",
            "Fit Kitchen",
            600);

        video3.AddComment(new Comment(
            "Grace",
            "These recipes look delicious."));

        video3.AddComment(new Comment(
            "Henry",
            "Can't wait to try them."));

        video3.AddComment(new Comment(
            "Isabella",
            "Very informative video."));

        videos.Add(video3);

        // Display videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
 