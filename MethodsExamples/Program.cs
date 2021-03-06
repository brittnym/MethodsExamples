using System;

namespace MethodsExamples
{
    public class Program
    {
        //main method. This is where you put only the essential stuff. //
        static void Main(string[] args)
        {
            //TODO: implement method to check if a number is in range of another int. That's what the first method below is


            //None of the infor in this method needs to be another method because you're not doing anything but asking questions and printing output.

            //TODO: ask the user for the initial number
            Console.WriteLine("Enter an initial number: ");
            int StartingNum = int.Parse(Console.ReadLine());

            //TODO: ask the user for the target 
            Console.WriteLine("Enter an taregt number: ");
            int TargetNum = int.Parse(Console.ReadLine());

            //TODO: ask the user for the range
            Console.WriteLine("Enter an range: ");
            int range = int.Parse(Console.ReadLine());
            
            //TODO: write the result by calling IsInRange
            Console.WriteLine($"Given a starting number of {StartingNum}, and a target number of {TargetNum},it's {IsWithinRange(StartingNum, TargetNum, range)} ");

            //This is for the PrintDoc()
            Console.WriteLine("Do we have power? (y/n)");
            bool hasPower = Console.ReadLine().ToLower() == "y";

            Console.WriteLine("Do we have paper? (y/n)");
            bool hasPaper = Console.ReadLine().ToLower() == "y";

            Console.WriteLine("What is your ink level?");
            int inkLevel =int.Parse(Console.ReadLine());

            PrintDoc(hasPower, hasPaper, inkLevel);

        }
        //access modifier followed by static or not followed by return type, then name, then (), then parameters
        private static bool IsWithinRange(int num, int target, int range)
        {
            //This particular math doesn't work properly, but for the purposes of this exercise, it doesn't really matter
           // return (num - target) <= range;//

            //this is actually the correct formula
            return (num - target) <= range && (num - target) >= -range;
        }

        //TODO: Print a document if it hasPower, hasPaper, and the ink level >=10//
        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            string result = hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unabe to print";
            Console.Write(result);

           // if (hasPower && hasPaper && inkLevel>=10)//
        }
    }
}