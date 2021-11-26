``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.100
  [Host]             : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET 6.0           : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4161.0), X64 RyuJIT


```
|         Method |                Job |            Runtime |         Mean |      Error |     StdDev |  Ratio | RatioSD |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|--------------- |------------------- |------------------- |-------------:|-----------:|-----------:|-------:|--------:|--------:|--------:|--------:|----------:|
| NonFinalizable |           .NET 6.0 |           .NET 6.0 |    103.04 μs |   0.861 μs |   0.805 μs |   1.00 |    0.00 | 50.7813 | 25.3906 |       - |    313 KB |
|    Finalizable |           .NET 6.0 |           .NET 6.0 | 19,107.76 μs |  60.225 μs |  50.290 μs | 185.60 |    1.31 | 50.7813 | 25.3906 | 11.7188 |    313 KB |
|                |                    |                    |              |            |            |        |         |         |         |         |           |
| NonFinalizable | .NET Framework 4.8 | .NET Framework 4.8 |     89.95 μs |   0.713 μs |   0.667 μs |   1.00 |    0.00 | 50.7813 | 25.3906 |       - |    313 KB |
|    Finalizable | .NET Framework 4.8 | .NET Framework 4.8 | 21,221.85 μs | 404.284 μs | 432.580 μs | 235.64 |    5.38 | 50.7813 | 25.3906 | 11.7188 |    313 KB |
