using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace ListArrayForForeachBenchmark
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [MemoryDiagnoser]
    public class CollectionLoopingBenchmark
    {
        private const int Size = 5_000_000;

        private int[] _array;
        private List<int> _list;

        [GlobalSetup]
        public void Setup()
        {
            _array = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                _array[i] = i;
            }

            _list = new List<int>(Size);
            for (int i = 0; i < Size; i++)
            {
                _list.Add(i);
            }
        }

        [Benchmark(Baseline = true)]
        public long ForLoopArray()
        {
            long sum = 0;
            for (int i = 0; i < Size; i++)
            {
                sum += _array[i];
            }

            return sum;
        }

        [Benchmark]
        public long ForeachLoopArray()
        {
            long sum = 0;
            foreach (int item in _array)
            {
                sum += item;
            }

            return sum;
        }

        [Benchmark]
        public long ForLoopList()
        {
            long sum = 0;
            for (int i = 0; i < Size; i++)
            {
                sum += _list[i];
            }

            return sum;
        }

        [Benchmark]
        public long ForeachLoopList()
        {
            long sum = 0;
            foreach (int item in _list)
            {
                sum += item;
            }

            return sum;
        }
    }
}
