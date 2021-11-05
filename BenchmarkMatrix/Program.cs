using BenchmarkDotNet.Running;

namespace BenchmarkMatrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<MatrixBenchmark>();
        }
    }
}
