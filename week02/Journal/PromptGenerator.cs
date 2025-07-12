using System;
public class PromptGenerator
{
    private String[] _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the part of my day?",
        "How did I see the hand of the lord in my life today?",
        "What was the strongest emotion I felt Today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Length)];
    }
}