using System;

namespace ShortStraw
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int patsyIndex = rand.Next(args.Length);
            Console.WriteLine($"Sorry {args[patsyIndex]}!");
        }
    }
}
