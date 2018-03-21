using System;
using System.Reflection;
using BenchmarkDotNet.Running;

namespace Algorithms.Benchmarks
{
    public class Program
    {
        public static void Main()
        {
            BenchmarkSwitcher.FromAssembly(Assembly.GetAssembly(typeof(SorterBenchmarks))).RunAll();
            Console.ReadLine();
        }
    }
}
