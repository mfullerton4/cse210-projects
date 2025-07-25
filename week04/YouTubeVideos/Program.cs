using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1.SetTitle("Intro to Encapsulation");
        v1.SetAuthor("tech Guru");
        v1.SetLength(300);
        v1.AddComment(new Comment("Alice", "Super helpful!"));
        v1.AddComment(new Comment("Bob", "Great explanation."));
        v1.AddComment(new Comment("Charlie", "Loved the animation,"));
        videos.Add(v1);

        Video v2 = new Video();
        v2.SetTitle("Designing RPG Characters");
        v2.SetAuthor("Tabletop Tavern");
        v2.SetLength(450);
        v2.AddComment(new Comment("Zara", "Malrics backstory gave me chils."));
        v2.AddComment(new Comment("Leo", "I'm stealing that armor design!"));
        v2.AddComment(new Comment("Jules", "When's the sequel episode?"));
        videos.Add(v2);

        Video v3 = new Video();
        v3.SetTitle("Python Outbreak Simulation");
        v3.SetAuthor("Code Pulse");
        v3.SetLength(600);
        v3.AddComment(new Comment("Nina", "Visualization was awesome!"));
        v3.AddComment(new Comment("Marcus", "Could use more recovery logic."));
        v3.AddComment(new Comment("Eve", "I'm building this for my class project."));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");

            }
        }
    }
}