using System;

namespace InterpreterPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter RPN Expression:");
            var text = Console.ReadLine();// 5 42 10 - +
            var evaluator = new Evaluator();
            var result = evaluator.Parse(text);
            Console.WriteLine($"Result: {result.Interpret()}");
            Console.Read();
        }
    }
}
