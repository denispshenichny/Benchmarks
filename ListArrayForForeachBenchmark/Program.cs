using BenchmarkDotNet.Running;

namespace ListArrayForForeachBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<CollectionLoopingBenchmark>();
        }
    }
}
