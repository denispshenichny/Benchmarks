using BenchmarkDotNet.Running;

namespace CastBenchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<CastingBenchmark>();
        }
    }
}