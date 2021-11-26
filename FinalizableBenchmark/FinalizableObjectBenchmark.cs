using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace FinalizableBenchmark
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class FinalizableObjectBenchmark
    {
        private const int Size = 10_000;

        [Benchmark(Baseline = true)]
        public object NonFinalizable()
        {
            var nonFinalizableObjects = new NonFinalizableObject[Size];
            for (int i = 0; i < Size; i++)
            {
                nonFinalizableObjects[i] = new NonFinalizableObject { Value = i };
            }

            return nonFinalizableObjects;
        }

        [Benchmark]
        public object Finalizable()
        {
            var finalizableObjects = new FinalizableObject[Size];
            for (int i = 0; i < Size; i++)
            {
                finalizableObjects[i] = new FinalizableObject { Value = i };
            }

            return finalizableObjects;
        }
    }

    public class FinalizableObject
    {
        public int Value { get; set; }

        ~FinalizableObject()
        {
        }
    }

    public class NonFinalizableObject
    {
        public int Value { get; set; }
    }
}
