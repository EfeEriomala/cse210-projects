using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
<<<<<<< HEAD
            new Running(new DateTime(2025, 12, 8), 30, 3.0),
            new Cycling(new DateTime(2025, 12, 5), 45, 15.0),
            new Swimming(new DateTime(2025, 12, 3), 40, 30)
=======
            new Running(new DateTime(2025, 8, 10), 30, 3.0),
            new Cycling(new DateTime(2025, 8, 12), 45, 15.0),
            new Swimming(new DateTime(2025, 8, 14), 40, 30)
>>>>>>> 302ec6ad7b2ef0c37aca4ce06cac5b72d7b41376
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
