``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.100
  [Host]             : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET 6.0           : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4161.0), X64 RyuJIT


```
|            Method |                Job |            Runtime |       Mean |     Error |    StdDev | Ratio | RatioSD |      Gen 0 |     Allocated |
|------------------ |------------------- |------------------- |-----------:|----------:|----------:|------:|--------:|-----------:|--------------:|
|    ContainsSimple |           .NET 6.0 |           .NET 6.0 | 173.103 ms | 2.7468 ms | 2.4350 ms | 28.62 |    0.44 | 76333.3333 | 480,000,160 B |
|    ContainsEquals |           .NET 6.0 |           .NET 6.0 |  34.642 ms | 0.6151 ms | 0.5754 ms |  5.74 |    0.09 | 38200.0000 | 240,000,032 B |
| ContainsEquatable |           .NET 6.0 |           .NET 6.0 |   6.048 ms | 0.0327 ms | 0.0290 ms |  1.00 |    0.00 |          - |           4 B |
|                   |                    |                    |            |           |           |       |         |            |               |
|    ContainsSimple | .NET Framework 4.8 | .NET Framework 4.8 | 273.977 ms | 0.6437 ms | 0.5706 ms | 15.70 |    0.03 | 76500.0000 | 481,414,744 B |
|    ContainsEquals | .NET Framework 4.8 | .NET Framework 4.8 |  63.622 ms | 0.5278 ms | 0.4937 ms |  3.65 |    0.03 | 38250.0000 | 240,706,348 B |
| ContainsEquatable | .NET Framework 4.8 | .NET Framework 4.8 |  17.447 ms | 0.0118 ms | 0.0099 ms |  1.00 |    0.00 |          - |             - |
