``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1288 (21H1/May2021Update)
Intel Core i3-8100 CPU 3.60GHz (Coffee Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.100-rc.2.21505.57
  [Host]             : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  .NET 5.0           : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT


```
| Method |                Job |            Runtime |      Mean |    Error |   StdDev | Ratio | RatioSD |
|------- |------------------- |------------------- |----------:|---------:|---------:|------:|--------:|
|   Rows |           .NET 5.0 |           .NET 5.0 |  16.75 ms | 0.030 ms | 0.026 ms |  1.00 |    0.00 |
|   Cols |           .NET 5.0 |           .NET 5.0 | 385.34 ms | 1.470 ms | 1.147 ms | 23.00 |    0.08 |
|        |                    |                    |           |          |          |       |         |
|   Rows | .NET Framework 4.8 | .NET Framework 4.8 |  16.89 ms | 0.045 ms | 0.040 ms |  1.00 |    0.00 |
|   Cols | .NET Framework 4.8 | .NET Framework 4.8 | 388.03 ms | 2.875 ms | 2.689 ms | 22.99 |    0.17 |
