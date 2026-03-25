using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some comments
        Comment comment1 = new Comment("Maggie", "Great video!");
        Comment comment2 = new Comment("John", "I learned a lot.");
        Comment comment3 = new Comment("Don", "Thanks for sharing!");

        // Create a video
        Video video = new Video("I'm bored", "Mickey", 300);

        // Add comments to the video
        video.AddComment(comment1);
        video.AddComment(comment2);
        video.AddComment(comment3);

        // Display video details and comments
        video.Display();
    }
}