using System;
using DefaultParameterSample.Core;

namespace DefaultParameterSample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = new Sample();

            System.Console.WriteLine($"--- {nameof(Sample.ConstString)} ---");
            System.Console.WriteLine(Sample.ConstString);
            System.Console.WriteLine($"--- {nameof(Sample.ReadonlyString)} ---");
            System.Console.WriteLine(Sample.ReadonlyString);
            System.Console.WriteLine($"--- {nameof(Sample.Method)} ---");
            sample.Method();

            System.Console.ReadLine();
        }
    }
}
