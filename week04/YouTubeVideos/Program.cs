using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Heartstone top decks", "Zeddy Heartstone", 1600);
        v1._comments.Add(new Comment("Miguel", "Great decks."));
        v1._comments.Add(new Comment("Paul", "Best video ive ever seen."));
        v1._comments.Add(new Comment("Carlos", "Your decks improved my game."));
        Video v2 = new Video("How to paint kitchen cabinets", "Remodel Services", 2500);
        v2._comments.Add(new Comment("Paul", "Clear instructions, ill watch it again."));
        v2._comments.Add(new Comment("Maria", "Ill have my husband do the same project."));
        v2._comments.Add(new Comment("Samir", "Love your videos"));
        Video v3 = new Video("Dancing Salsa", "Dancing Studio", 4500);
        v3._comments.Add(new Comment("Jasmine", "I wish I could dance like you."));
        v3._comments.Add(new Comment("Sophie", "Where I apply for your lessons?"));
        v3._comments.Add(new Comment("Jhonn", "Keep the hard work."));

        List<Video> videos = new List<Video>()
        {
            v1,
            v2,
            v3
        
        };
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._videoLength} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentNumber()}");
            Console.WriteLine("Comments:");
            foreach (Comment c in video._comments)
            {
                Console.WriteLine($"* {c._commentatorName}: {c._comment}");
            }
            Console.WriteLine("");

        }
    
    }
}