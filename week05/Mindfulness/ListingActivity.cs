public class ListingActivity : Activity
{
    private int _count;
    private List<string> _responses;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having as many things as you can in a certain area.")
    {
        _responses = new List<string>();
        _prompts = new List<string>
        {
            "Who are people you appreciate?",
            "What are personal strengths of yours",
            "Who are people that you have helped this week?",
            "When have you felt the holy ghost this week?",
            "Who are some of your personal heroes?"
        };
    }

    public  void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                _responses.Add(response);
            }
        }
        _count = _responses.Count;
        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
