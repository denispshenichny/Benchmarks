using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace IEquatableBenchmark
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class EquatableBenchmark
    {
        private const int Size = 10_000_000;

        private List<SimpleStruct> _simpleStructs;
        private List<EqualsStruct> _equalsStructs;
        private List<EquatableStruct> _equatableStructs;

        [GlobalSetup]
        public void Setup()
        {
            _simpleStructs = new List<SimpleStruct>(Size);
            _equalsStructs = new List<EqualsStruct>(Size);
            _equatableStructs = new List<EquatableStruct>(Size);

            for (int i = 0; i < Size; i++)
            {
                _simpleStructs.Add(new SimpleStruct {Value = i});
                _equalsStructs.Add(new EqualsStruct {Value = i});
                _equatableStructs.Add(new EquatableStruct {Value = i});
            }
        }

        [Benchmark]
        public bool ContainsSimple()
        {
            return _simpleStructs.Contains(new SimpleStruct {Value = Size - 1});
        }

        [Benchmark]
        public bool ContainsEquals()
        {
            return _equalsStructs.Contains(new EqualsStruct { Value = Size - 1 });
        }

        [Benchmark(Baseline = true)]
        public bool ContainsEquatable()
        {
            return _equatableStructs.Contains(new EquatableStruct { Value = Size - 1 });
        }
    }
}

public struct SimpleStruct
{
    public int Value { get; set; }
}

public struct EqualsStruct
{
    public int Value { get; set; }

    public override bool Equals(object obj)
    {
        return obj is EqualsStruct @struct && @struct.Value == Value;
    }

    public override int GetHashCode()
    {
        return Value;
    }
}

public struct EquatableStruct : IEquatable<EquatableStruct>
{
    public int Value { get; set; }

    public bool Equals(EquatableStruct other)
    {
        return other.Value == Value;
    }

    public override bool Equals(object obj)
    {
        return obj is EquatableStruct @struct && Equals(@struct);
    }

    public override int GetHashCode()
    {
        return Value;
    }
}