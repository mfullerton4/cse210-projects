public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time When you stood up for someone else.",
        "Think of a time When you did something really difficult.",
        "Think of a time When you helped someone in need.",
        "Think of a time When you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your faavorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        ShowPrompt();

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            PauseWithSpinner(5);
        }

        DisplayEndingMessage();
    }
    private void ShowPrompt()
    {
        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions:");
        PauseWithSpinner(3);
    }

    private string GetRandomQuestion()
    {
        return _questions[new Random().Next(_questions.Count)];
    }
}