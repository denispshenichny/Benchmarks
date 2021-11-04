``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1288 (21H1/May2021Update)
Intel Core i3-8100 CPU 3.60GHz (Coffee Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.100-rc.2.21505.57
  [Host]             : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  .NET 5.0           : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT


```
| Method |                Job |            Runtime |      Mean |    Error |   StdDev | Ratio |
|------- |------------------- |------------------- |----------:|---------:|---------:|------:|
|   Rows |           .NET 5.0 |           .NET 5.0 |  54.84 ms | 1.416 ms | 4.063 ms |  1.00 |
|   Cols |           .NET 5.0 |           .NET 5.0 | 413.02 ms | 5.967 ms | 5.581 ms |  7.31 |
|        |                    |                    |           |          |          |       |
|   Rows | .NET Framework 4.8 | .NET Framework 4.8 |  86.67 ms | 1.698 ms | 2.790 ms |  1.00 |
|   Cols | .NET Framework 4.8 | .NET Framework 4.8 | 422.03 ms | 2.312 ms | 1.931 ms |  4.88 |
