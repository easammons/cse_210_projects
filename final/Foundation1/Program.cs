using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Exploring Mars", "NASA", 600);
        video1.AddComment(new Comment("Alice", "This is fascinating!"));
        video1.AddComment(new Comment("BillyJoeBobthethird", "I love space exploration."));
        video1.AddComment(new Comment("Charlie", "So cool!"));

        Video video2 = new Video("C# Tutorial for Beginners", "CodeAcademy", 1200);
        video2.AddComment(new Comment("Dave", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Codingishard707", "Please make more tutorials."));
        video2.AddComment(new Comment("Frank", "Great explanations."));

        Video video3 = new Video("Top 10 Anime Deaths", "FilmDaily", 900);
        video3.AddComment(new Comment("Grace", "Love #4, gave me chills."));
        video3.AddComment(new Comment("Hank", "Where's Inception?!"));
        video3.AddComment(new Comment("Sendmepicsofyourcat", "Nice compilation!"));
        video3.AddComment(new Comment("Jack", "Number 5 surprised me"));

        Video video4 = new Video("A Brief Introspection on Spongebob", "FilmDaily", 5400);
        video4.AddComment(new Comment("Spongeboblover24", "Spongebob needs to get a different job"));
        video4.AddComment(new Comment("Jillian", "Mr. Krabs should have been divorced sooner."));
        video4.AddComment(new Comment("Ivy", "Nice compilation!"));
        video4.AddComment(new Comment("CanIhazcheeseburger", "Unsubscribed. Blocked. I'm calling Nickelodeon. "));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(new string('-', 40));
        }

        Console.ReadLine();
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        LengthInSeconds = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }
}

