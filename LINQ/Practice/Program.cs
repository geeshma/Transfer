using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Demo d = new Demo();
                Console.WriteLine("Enter roll no");
                d.GetAllRecords();
                int roll = int.Parse(Console.ReadLine());
                d.GetRow(roll);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
