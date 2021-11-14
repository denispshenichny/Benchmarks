using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace FlagsEnumBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<EnumBenchmark>();
        }
    }
}
