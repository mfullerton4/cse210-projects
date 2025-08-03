using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Prepare to begin. . .");
        PauseWithSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        PauseWithSpinner(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

    protected void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
    }   
        protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}