``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
Intel Core i3-8100 CPU 3.60GHz (Coffee Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.100-rc.2.21505.57
  [Host]             : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  .NET 5.0           : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT


```
|     Method |                Job |            Runtime |        Mean |    Error |   StdDev | Ratio | RatioSD |       Gen 0 |       Allocated |
|----------- |------------------- |------------------- |------------:|---------:|---------:|------:|--------:|------------:|----------------:|
|    HasFlag |           .NET 5.0 |           .NET 5.0 |    48.16 ms | 0.950 ms | 1.094 ms |  1.17 |    0.04 |           - |               - |
|   AndEqual |           .NET 5.0 |           .NET 5.0 |    47.31 ms | 0.511 ms | 0.399 ms |  1.14 |    0.02 |           - |         1,215 B |
| AndGreater |           .NET 5.0 |           .NET 5.0 |    41.38 ms | 0.634 ms | 0.562 ms |  1.00 |    0.00 |           - |               - |
|            |                    |                    |             |          |          |       |         |             |                 |
|    HasFlag | .NET Framework 4.8 | .NET Framework 4.8 | 1,032.91 ms | 4.934 ms | 4.120 ms | 23.30 |    0.41 | 673000.0000 | 2,120,162,864 B |
|   AndEqual | .NET Framework 4.8 | .NET Framework 4.8 |    47.30 ms | 0.466 ms | 0.413 ms |  1.07 |    0.02 |           - |               - |
| AndGreater | .NET Framework 4.8 | .NET Framework 4.8 |    44.34 ms | 0.886 ms | 0.740 ms |  1.00 |    0.00 |           - |               - |
