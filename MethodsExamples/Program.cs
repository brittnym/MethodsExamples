using System;

namespace MethodsExamples
{
    public class Program
    {
        //main method. This is where you put only the essential stuff. //
        static void Main(string[] args)
        {
            //TODO: implement method to check if a number is in range of another int. That's what the first method below is

            //TODO: ask the user for the initial number
            //TODO: ask the user for the target 
            //TODO: ask the user for the range
            //None of the infor in this method needs to be another method because you're not doing anything but asking questions and printing output.

            Console.WriteLine("Enter an initial number: ");
            int StartingNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an taregt number: ");
            int TargetNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an range: ");
            int range = int.Parse(Console.ReadLine());
            
            //TODO: write the result by calling IsInRange
            Console.WriteLine($"Given a starting number of {StartingNum}, and a target number of {TargetNum},it's {IsWithinRange(StartingNum, TargetNum, range)} ");




        }
        //access modifier followed by static or not followed by return type, then name, then (), then parameters
        private static bool IsWithinRange(int num, int target, int range)
        {
            return (num - target) <= range;
        }

    }
}