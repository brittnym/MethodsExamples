using System;

namespace MethodsExamples
{
    public class Program
    {
        //main method. This is where you put only the essential stuff. Like, //
        static void Main(string[] args)
        {
           //TODO: implement method to check if a number is in range of another int. That's what the first method below is
          
        }
        //access modifier followed by static or not followed by return type, then name, then (), then parameters
        private static bool IsWithinRange(int num1, int num2, int range)
        {
            return (num1 - num2) <= range;
        }
    }
}