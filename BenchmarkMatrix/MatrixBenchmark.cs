using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace BenchmarkMatrix
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net50)]
    public class MatrixBenchmark
    {
        private const int Size = 5000;

        private int[][] _matrix;

        [GlobalSetup]
        public void Setup()
        {
            _matrix = new int[Size][];
            for (int i = 0; i < Size; i++)
                _matrix[i] = new int[Size];
        }

        [Benchmark(Baseline = true)]
        public void Rows()
        {
            for (int i = 0; i < Size; i++)
            for (int j = 0; j < Size; j++)
                _matrix[i][j] = i + j;
        }
        [Benchmark]
        public void Cols()
        {
            for (int i = 0; i < Size; i++)
            for (int j = 0; j < Size; j++)
                _matrix[j][i] = i + j;
        }
    }
}