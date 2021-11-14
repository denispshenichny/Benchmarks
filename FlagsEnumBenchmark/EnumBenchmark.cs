using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace FlagsEnumBenchmark
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [MemoryDiagnoser]
    public class EnumBenchmark
    {
        [Flags]
        public enum FlagsEnum
        {
            None = 0,
            _1 = 1,
            _2 = 2,
            _4 = 4,
            _8 = 8,
            _16 = 16,
            _32 = 32,
            _64 = 64,
            _128 = 128,
            _256 = 256,
            _512 = 512,
            _1024 = 1024,
            _2048 = 2048,
            _4096 = 4096,
            _8192 = 8192,
            _16384 = 16384,
            _32768 = 32768,
            _65536 = 65536,
            _131072 = 131072,
            _262144 = 262144,
            _524288 = 524288
        }

        private FlagsEnum[] _sequence;
        private FlagsEnum[] _enums;

        [GlobalSetup]
        public void Setup()
        {
            _enums = (FlagsEnum[])Enum.GetValues(typeof(FlagsEnum));

            int count = 1 << _enums.Length;
            _sequence = new FlagsEnum[count];
            for (int i = 1; i < count; i++)
            {
                _sequence[i] = (FlagsEnum)i;
            }
        }

        [Benchmark]
        public bool HasFlag()
        {
            bool res = false;
            int count = _sequence.Length;
            int enumsLength = _enums.Length;
            for (int i = 1; i < count; i++)
            {
                for (int j = 0; j < enumsLength; j++)
                {
                    res ^= _sequence[i].HasFlag(_enums[j]);
                }
            }

            return res;
        }

        [Benchmark]
        public bool AndEqual()
        {
            bool res = false;
            int count = _sequence.Length;
            int enumsLength = _enums.Length;
            for (int i = 1; i < count; i++)
            {
                for (int j = 0; j < enumsLength; j++)
                {
                    res ^= (_sequence[i] & _enums[j]) == _enums[j];
                }
            }

            return res;
        }

        [Benchmark(Baseline = true)]
        public bool AndGreater()
        {
            bool res = false;
            int count = _sequence.Length;
            int enumsLength = _enums.Length;
            for (int i = 1; i < count; i++)
            {
                for (int j = 0; j < enumsLength; j++)
                {
                    res ^= (_sequence[i] & _enums[j]) > FlagsEnum.None;
                }
            }

            return res;
        }
    }
}
