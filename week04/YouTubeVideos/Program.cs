using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a master list to hold our videos
            List<Video> videoList = new List<Video>();

            // ==========================================
            // VIDEO 1: Tech Review
            // ==========================================
            Video video1 = new Video("C# Basics in 10 Minutes", "CodeWithSeyi", 600);
            video1.AddComment(new Comment("Alice", "This explained OOP perfectly, thank you!"));
            video1.AddComment(new Comment("Bob", "Best 10 minutes I've spent all week. Clear and concise."));
            video1.AddComment(new Comment("Charlie", "Can you make a video on advanced Linq structures next?"));
            videoList.Add(video1);

            // ==========================================
            // VIDEO 2: Cooking Tutorial
            // ==========================================
            Video video2 = new Video("Perfect Jollof Rice Recipe", "NaijaChef Masters", 900);
            video2.AddComment(new Comment("David", "The aroma practically came through my screen!"));
            video2.AddComment(new Comment("Emma", "Tried this tonight and my whole family loved it. 10/10."));
            video2.AddComment(new Comment("Frank", "Secret tip: cook down the tomatoes longer. Great video!"));
            video2.AddComment(new Comment("Grace", "Simple, authentic, and delicious. Subscribed!"));
            videoList.Add(video2);

            // ==========================================
            // VIDEO 3: Travel Vlog
            // ==========================================
            Video video3 = new Video("Exploring Obudu Cattle Ranch", "Wanderlust Africa", 1450);
            video3.AddComment(new Comment("Henry", "Nigeria is incredibly beautiful. Adding this to my bucket list."));
            video3.AddComment(new Comment("Isabella", "Those drone shots of the mountains were completely breathtaking."));
            video3.AddComment(new Comment("Jack", "What camera gear did you use to film the canopy walk?"));
            videoList.Add(video3);

            // ==========================================
            // DISPLAYING THE STORED DATA
            // ==========================================
            Console.WriteLine("==================================================");
            Console.WriteLine("          YOUTUBE VIDEO TRACKING REPORT           ");
            Console.WriteLine("==================================================\n");

            foreach (Video video in videoList)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Total Comments: {video.GetCommentCount()}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  - @{comment.CommenterName}: \"{comment.CommentText}\"");
                }

                Console.WriteLine("\n==================================================\n");
            }
        }
    }
}