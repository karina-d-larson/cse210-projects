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

        
        // Create some comments
        Comment comment4 = new Comment("Maggie", "This is better then the first one!");
        Comment comment5 = new Comment("John", "I learn a lot with every video.");
        Comment comment6 = new Comment("Don", "Thanks for sharing your videos!");

        // Create a video
        Video video2 = new Video("I'm bored still", "Mickey", 300);

        // Add comments to the video
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        // Display video details and comments
        video2.Display();


        // Create some comments
        Comment comment7 = new Comment("Maggie", "Greatest video you've made!");
        Comment comment8 = new Comment("John", "This was a bit mid.");
        Comment comment9 = new Comment("Don", "Thanks for the entertainment!");

        // Create a video
        Video video3 = new Video("I'm even more bored", "Mickey", 300);

        // Add comments to the video
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        // Display video details and comments
        video3.Display();
    }
}