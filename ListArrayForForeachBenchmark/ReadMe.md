``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.100
  [Host]             : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET 5.0           : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  .NET 6.0           : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4161.0), X64 RyuJIT


```
|           Method |                Job |            Runtime |      Mean |     Error |    StdDev | Code Size |
|----------------- |------------------- |------------------- |----------:|----------:|----------:|----------:|
|      ForLoopList |           .NET 5.0 |           .NET 5.0 |  3.666 ms | 0.0103 ms | 0.0091 ms |      70 B |
|  ForeachLoopList |           .NET 5.0 |           .NET 5.0 | 11.485 ms | 0.0050 ms | 0.0047 ms |     163 B |
|     ForLoopArray |           .NET 5.0 |           .NET 5.0 |  3.191 ms | 0.0098 ms | 0.0091 ms |      35 B |
| ForeachLoopArray |           .NET 5.0 |           .NET 5.0 |  3.185 ms | 0.0063 ms | 0.0056 ms |      35 B |
|                  |                    |                    |           |           |           |           |
|      ForLoopList |           .NET 6.0 |           .NET 6.0 |  3.659 ms | 0.0032 ms | 0.0025 ms |      70 B |
|  ForeachLoopList |           .NET 6.0 |           .NET 6.0 |  5.945 ms | 0.0274 ms | 0.0242 ms |      98 B |
|     ForLoopArray |           .NET 6.0 |           .NET 6.0 |  3.181 ms | 0.0099 ms | 0.0093 ms |      38 B |
| ForeachLoopArray |           .NET 6.0 |           .NET 6.0 |  3.178 ms | 0.0115 ms | 0.0108 ms |      38 B |
|                  |                    |                    |           |           |           |           |
|      ForLoopList | .NET Framework 4.8 | .NET Framework 4.8 |  4.563 ms | 0.0191 ms | 0.0159 ms |     164 B |
|  ForeachLoopList | .NET Framework 4.8 | .NET Framework 4.8 | 10.463 ms | 0.0121 ms | 0.0108 ms |     179 B |
|     ForLoopArray | .NET Framework 4.8 | .NET Framework 4.8 |  3.272 ms | 0.0098 ms | 0.0087 ms |      35 B |
| ForeachLoopArray | .NET Framework 4.8 | .NET Framework 4.8 |  3.282 ms | 0.0163 ms | 0.0144 ms |      35 B |
