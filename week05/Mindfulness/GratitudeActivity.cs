using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base(
            "Gratitude",
            "This activity helps you focus on things you are grateful for.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nEnter something you are grateful for: ");
            Console.ReadLine();
        }

        DisplayEndingMessage();
    }
}