using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for(int i=0;i<5;i++)
            {
                try
                {
                    Console.WriteLine(i);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                //The finally statement lets you execute code, after try...catch, regardless of the result
                finally
                {
                    Console.WriteLine("This is finally block");
                }
            }
        }
    }
}
