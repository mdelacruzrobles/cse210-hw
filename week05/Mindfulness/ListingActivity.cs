public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts;
    private Random _random = new Random();
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"

        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("");
        Console.Write("How long do you want this session (in seconds)? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("List as many responses you can to the following prompt");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("You may begin in: ");
        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
    public List<string> GetListFromUser()
    {
        List<string> listingItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                listingItems.Add(input);
            }
        }

        return listingItems;
    }
}