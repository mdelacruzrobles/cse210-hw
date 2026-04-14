

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
    public void ShowSpinner(int seconds)
    {
        
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}