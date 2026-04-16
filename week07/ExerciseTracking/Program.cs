using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(DateTime.Now, 30, 3.0));
        activities.Add(new Cycling(DateTime.Now, 45, 15.0));
        activities.Add(new Swimming(DateTime.Now, 30, 20));
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}