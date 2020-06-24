using System;
using System.Collections.Generic;

namespace BowlingInt
{
    class Program
    {
        static void Main(string[] args)
        {
            RunBowling();
        }
        
            
        
        static void RunBowling()
        {
            Random rnd = new Random();
            var frames = new List<int>(10);
            for(var idx = 0; idx < 10; idx++)
            {
                var score = rnd.Next(0, 31);
                frames.Add(score);
            }
            var total = 0;
            foreach(var frame in frames)
            {
                total += frame;
            }
            Console.WriteLine($"Score is {total}");
        }
        
        

        
    }
}
