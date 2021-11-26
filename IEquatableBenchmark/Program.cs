using BenchmarkDotNet.Running;

namespace IEquatableBenchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<EquatableBenchmark>();
        }
    }
}
