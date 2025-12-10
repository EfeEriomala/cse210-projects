using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 12, 8), 30, 3.0),
            new Cycling(new DateTime(2025, 12, 5), 45, 15.0),
            new Swimming(new DateTime(2025, 12, 3), 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}