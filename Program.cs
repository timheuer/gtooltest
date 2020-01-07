using System;

namespace gtooltest
{
    class Program
    {
        static void Main(string[] args)
        {
#if NETCOREAPP2_1
            Console.WriteLine("Hello World from 2.1!");
#elif NETCOREAPP3_1
            Console.WriteLine("Hello world from 3.1!");
#else
            Console.WriteLine("Hello world");
#endif
        }
    }
}
