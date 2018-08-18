using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            Console.WriteLine("Press enter to start stopwatch or exit to exit. ");
            var input = Console.ReadLine();
            while (!input.ToLower().Equals("exit"))
            {
                
                watch.Start();

                Console.WriteLine("Hit a key to stop/pause the stopwatch.");
                Console.ReadKey();
                watch.Stop();
                Console.WriteLine("Current time elapsed: {0}",watch.TimeElapsed.ToString());

                Console.WriteLine("Press enter to unpause the stopwatch. Type exit to exit. ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Final stopwatch time: {0}", watch.TimeElapsed.ToString());

            Console.ReadKey();
        }
    }
}
