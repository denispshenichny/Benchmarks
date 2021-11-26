using BenchmarkDotNet.Running;

namespace FinalizableBenchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<FinalizableObjectBenchmark>();
        }
    }
}