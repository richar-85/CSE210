using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<YouTubeVideos> videos = new List<YouTubeVideos>();

        // Video 1
        YouTubeVideos video1 = new YouTubeVideos("Learning C# Abstraction", "Richard Udonsa", 600);
        video1.AddComment(new Comment("Mark", "Great explanation!"));
        video1.AddComment(new Comment("Rose", "Very helpful, thanks"));
        video1.AddComment(new Comment("Sam", "Enjoyed every details"));
        videos.Add(video1);

        // Video 2
        YouTubeVideos video2 = new YouTubeVideos("Sport Analysis", "AFTV", 600);
        video2.AddComment(new Comment("Noah", "Great Analysis!"));
        video2.AddComment(new Comment("Mike", "Very helpful, thanks"));
        video2.AddComment(new Comment("John", "Good breakdown."));
        videos.Add(video2);

        // Video 3
        YouTubeVideos video3 = new YouTubeVideos("Cooking Show", "Jacob's Kitchen", 600);
        video3.AddComment(new Comment("Mary", "Good recepies choice"));
        video3.AddComment(new Comment("Kate", "Looks appetizing"));
        video3.AddComment(new Comment("Linda", "Mouth watering"));
        videos.Add(video3);

        // Display
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._videoTitle}");
            Console.WriteLine($"Author: {video._videoAuthor}");
            Console.WriteLine($"Lengrh: {video._videoLength} seconds");
            Console.WriteLine($"_videoComments ({video.GetCommentCount()}):");

            foreach (var comment in video._videoComments)
            {
                Console.WriteLine($"- {comment._commentAuthor}: {comment._commentText}");
            }
            Console.WriteLine();
        }
    }
}