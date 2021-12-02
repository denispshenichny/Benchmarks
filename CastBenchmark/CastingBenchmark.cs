using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace CastBenchmark
{
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net48)]
    [DisassemblyDiagnoser]
    public class CastingBenchmark
    {
        private object _value;

        [GlobalSetup]
        public void Setup()
        {
            _value = new A();
        }

        [Benchmark]
        public void DoubleCast()
        {
            if (_value is A)
            {
                ((A)_value).Do();
            }
        }

        [Benchmark]
        public void DoubleCast_As()
        {
            if (_value is A)
            {
                (_value as A).Do();
            }
        }

        [Benchmark]
        public void CachedCast()
        {
            var a = _value as A;
            if (a != null)
            {
                a.Do();
            }
        }

        [Benchmark]
        public void PatternMatching()
        {
            if (_value is A a)
            {
                a.Do();
            }
        }

        [Benchmark]
        public void DoubleCast_Virtual()
        {
            if (_value is A)
            {
                ((A)_value).VirtualDo();
            }
        }

        [Benchmark]
        public void DoubleCast_As_Virtual()
        {
            if (_value is A)
            {
                (_value as A).VirtualDo();
            }
        }

        [Benchmark]
        public void CachedCast_Virtual()
        {
            var a = _value as A;
            if (a != null)
            {
                a.VirtualDo();
            }
        }

        [Benchmark]
        public void PatternMatching_Virtual()
        {
            if (_value is A a)
            {
                a.VirtualDo();
            }
        }
    }

    public class A
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Do()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public virtual void VirtualDo()
        {
        }
    }
}
