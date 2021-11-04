using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace BenchmarkMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<MatrixBenchmark>();
        }
    }

    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [MemoryDiagnoser]
    public class MatrixBenchmark
    {
        const int Size = 5000;

        [Benchmark(Baseline = true)]
        public void Rows()
        {
            int[][] matrix = new int[Size][];
            for(int i = 0; i < Size; i++)
                matrix[i] = new int[Size];
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    matrix[i][j] = i + j;
        }
        [Benchmark]
        public void Cols()
        {
            int[][] matrix = new int[Size][];
            for (int i = 0; i < Size; i++)
                matrix[i] = new int[Size];
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    matrix[j][i] = i + j;
        }
    }
}
