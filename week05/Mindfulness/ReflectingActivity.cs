public class ReflectingActivity : Activity
{
    protected List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    protected List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private Random _random = new Random();
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and  resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("");
        Console.Write("How long do you want this session (in seconds)? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        DisplayPrompt();
        Console.ReadLine();
        for (int i = 0; i < 2; i++)
        {
            DisplayQuestions();
            ShowSpinner(8);
            Console.WriteLine("");
        }
        DisplayEndingMessage();
        ShowSpinner(5);

    }
    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
    public string GetRandomQuestion()
    {
        
        int randomIndex = _random.Next(_questions.Count);
        return _questions[randomIndex];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Get ready...");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue.");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}