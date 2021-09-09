using System;
using System.Linq;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] no = { 12, 23, 34, 45, 56, 67, 78, 78, 89 };//Data source
            var result = from num in no
                         where num % 2 == 0
                         select num;
            foreach (var n in result)
                Console.WriteLine(n);
            //Example-1
           var k = no.First();
            Console.WriteLine(k);
            k = no.Last();
            Console.WriteLine(k);
            k = no.First(i => i % 2 == 0);
            Console.WriteLine(k);
            k = no.Last(i => i % 2 == 0);
            Console.WriteLine(k);
            //Example-2
            k = no.LastOrDefault(i => i % 2 == 0);
            Console.WriteLine(k);
            k = no.FirstOrDefault(i => i % 2 == 1);
            Console.WriteLine(k);
            //Example-3
             k = no.Single(i => i > 8);
            Console.WriteLine(k);
            k = no.SingleOrDefault(i => i > 9);
            Console.WriteLine(k);
            //Example-4
             k = no.ElementAt(1);
            Console.WriteLine(k);
            k = no.ElementAtOrDefault(2);
            Console.WriteLine(k);

        }
    }
}
