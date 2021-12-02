# Benchmarks
A bunch of benchmarks about different corners of C#.

Sometimes there are different options of writing C# code constructions are available, so it is necessary to choose one of them. Personally I try to choose the optimal one in sense of better performance and smaller memory consumption. But generally, it is not possible to find the best alternative basing on just starring at them. So in order to prove (or reject) my hypotheses I have created benchmarks measuring performance.

The following list is a list of questions "what is the best option to use in terms of performance?" I was asked and links to the corresponding answers:

- [How to traverse matrix: by rows or by columns?](https://github.com/denispshenichny/Benchmarks/tree/master/BenchmarkMatrix)
- [What is the most optimal way of casting object to the descendant class?](https://github.com/denispshenichny/Benchmarks/tree/master/CastBenchmark)
- [What is the impact the finalizable objects introduce?](https://github.com/denispshenichny/Benchmarks/tree/master/FinalizableBenchmark)
- [What is the fastest way to check whether the Flags enum has a certain flag?](https://github.com/denispshenichny/Benchmarks/tree/master/FlagsEnumBenchmark)
- [Why do I have to implement the IEquatable interface on structures used in standard containers?](https://github.com/denispshenichny/Benchmarks/tree/master/IEquatableBenchmark)
- [What is faster: get property value or get indexer value?](https://github.com/denispshenichny/Benchmarks/tree/master/IndexerGetterBenchmark)
- [Which collection is faster for traversing: List or array? And what is the preferred loop for traversing: for or foreach?](https://github.com/denispshenichny/Benchmarks/tree/master/ListArrayForForeachBenchmark)
