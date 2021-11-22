using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace IndexerGetterBenchmark
{
    [DisassemblyDiagnoser(printSource: true)]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net60)]
    public class IndexerVsGetterBenchmark
    {
        private Class[] _classArray;
        private Class _object;
        private Struct[] _structArray;
        private Struct _struct;

        [GlobalSetup]
        public void Setup()
        {
            _classArray = new Class[100];
            for (int i = 0; i < 100; i++)
            {
                _classArray[i] = new Class { Index = i };
            }

            _object = _classArray[15];

            _structArray = new Struct[100];
            for (int i = 0; i < 100; i++)
            {
                _structArray[i] = new Struct { Index = i };
            }

            _struct = _structArray[15];
        }

        [Benchmark]
        public Class Indexer_Class()
        {
            return _classArray[10];
        }

        [Benchmark]
        public int Getter_Class()
        {
            return _object.Index;
        }

        [Benchmark]
        public Struct Indexer_Struct()
        {
            return _structArray[10];
        }

        [Benchmark]
        public int Getter_Struct()
        {
            return _struct.Index;
        }
    }

    public class Class
    {
        public int Index { get; set; }
    }

    public struct Struct
    {
        public int Index { get; set; }
    }
}
