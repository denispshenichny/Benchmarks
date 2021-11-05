``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1288 (21H1/May2021Update)
Intel Core i3-8100 CPU 3.60GHz (Coffee Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.100-rc.2.21505.57
  [Host]             : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  .NET 5.0           : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT


```
|           Method |                Job |            Runtime |      Mean |     Error |    StdDev | Ratio | Allocated |
|----------------- |------------------- |------------------- |----------:|----------:|----------:|------:|----------:|
|     ForLoopArray |           .NET 5.0 |           .NET 5.0 |  3.027 ms | 0.0032 ms | 0.0027 ms |  1.00 |         - |
| ForeachLoopArray |           .NET 5.0 |           .NET 5.0 |  2.684 ms | 0.0025 ms | 0.0021 ms |  0.89 |         - |
|      ForLoopList |           .NET 5.0 |           .NET 5.0 |  3.839 ms | 0.0024 ms | 0.0022 ms |  1.27 |         - |
|  ForeachLoopList |           .NET 5.0 |           .NET 5.0 | 10.199 ms | 0.0049 ms | 0.0039 ms |  3.37 |         - |
|                  |                    |                    |           |           |           |       |           |
|     ForLoopArray | .NET Framework 4.8 | .NET Framework 4.8 |  3.039 ms | 0.0111 ms | 0.0104 ms |  1.00 |         - |
| ForeachLoopArray | .NET Framework 4.8 | .NET Framework 4.8 |  2.687 ms | 0.0095 ms | 0.0075 ms |  0.88 |         - |
|      ForLoopList | .NET Framework 4.8 | .NET Framework 4.8 |  4.308 ms | 0.0114 ms | 0.0101 ms |  1.42 |         - |
|  ForeachLoopList | .NET Framework 4.8 | .NET Framework 4.8 | 10.176 ms | 0.0089 ms | 0.0083 ms |  3.35 |         - |
