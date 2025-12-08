using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 4.8));
        activities.Add(new Cycling("03 Nov 2022", 40, 20));
        activities.Add(new Swimming("03 Nov 2022", 25, 30));

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}