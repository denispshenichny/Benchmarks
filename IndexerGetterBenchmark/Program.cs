using BenchmarkDotNet.Running;

namespace IndexerGetterBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<IndexerVsGetterBenchmark>();
        }
    }
}
