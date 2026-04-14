public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        Console.WriteLine("");
        Console.Write("How long do you want this session (in seconds)? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        int sessionDuration = _duration / 8;
        for (int i = 0; i < sessionDuration; i++)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Now breath out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}