using System;

namespace Hello
{
 
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < 5; ++i)
                    Console.WriteLine(a[i]);
                int x = (1 / Convert.ToInt32(0));
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("A");
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("B");
            }
            Console.ReadLine();
        }
    }
}
