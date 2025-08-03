public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            Countdown(4);

            Console.Write("Breathe out...");
            Countdown(6);
        }

        DisplayEndingMessage();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
        Console.WriteLine();
    }
}