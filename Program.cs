// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Mood : ");
        string x = Console.ReadLine();
        try
        {
            MoodAnalyser m1 = new MoodAnalyser();
            m1.MoodException(x);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}








