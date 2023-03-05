// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
       

           
            Type t = typeof(MoodAnalyser);
            ConstructorInfo[] constructorInfos = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo);
            }
        }
    }






