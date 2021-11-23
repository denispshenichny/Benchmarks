using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace ListArrayForForeachBenchmark
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByJob)]
    [DisassemblyDiagnoser(printSource: true)]
    public class CollectionLoopingBenchmark
    {
        private const int Size = 5_000_000;

        private int[] _array;
        private List<int> _list;

        public IEnumerable<int[]> Arrays()
        {
            _array = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                _array[i] = i;
            }

            yield return _array;
        }
        public IEnumerable<List<int>> Lists()
        {
            _list = new List<int>(Size);
            for (int i = 0; i < Size; i++)
            {
                _list.Add(i);
            }

            yield return _list;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Arrays))]
        public long ForLoopArray(int[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Arrays))]
        public long ForeachLoopArray(int[] array)
        {
            long sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }

            return sum;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Lists))]
        public long ForLoopList(List<int> list)
        {
            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Lists))]
        public long ForeachLoopList(List<int> list)
        {
            long sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }

            return sum;
        }
    }
}
