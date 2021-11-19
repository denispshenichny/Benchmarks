``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
Intel Core i3-8100 CPU 3.60GHz (Coffee Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.100-rc.2.21505.57
  [Host]             : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  .NET 5.0           : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT


```
|         Method |                Job |            Runtime |      Mean |     Error |    StdDev | Code Size |
|--------------- |------------------- |------------------- |----------:|----------:|----------:|----------:|
|  Indexer_Class |           .NET 5.0 |           .NET 5.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns |      29 B |
|   Getter_Class |           .NET 5.0 |           .NET 5.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns |       8 B |
| Indexer_Struct |           .NET 5.0 |           .NET 5.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns |      28 B |
|  Getter_Struct |           .NET 5.0 |           .NET 5.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns |       7 B |
|  Indexer_Class | .NET Framework 4.8 | .NET Framework 4.8 | 0.3174 ns | 0.0092 ns | 0.0086 ns |      29 B |
|   Getter_Class | .NET Framework 4.8 | .NET Framework 4.8 | 0.0137 ns | 0.0009 ns | 0.0008 ns |       8 B |
| Indexer_Struct | .NET Framework 4.8 | .NET Framework 4.8 | 0.3126 ns | 0.0017 ns | 0.0015 ns |      28 B |
|  Getter_Struct | .NET Framework 4.8 | .NET Framework 4.8 | 0.0082 ns | 0.0031 ns | 0.0029 ns |       7 B |


## .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Indexer_Class()
       sub       rsp,28
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],0A
       jbe       short M00_L00
       mov       rax,[rax+60]
       add       rsp,28
       ret
M00_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 29
```

## .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Getter_Class()
       mov       rax,[rcx+10]
       mov       eax,[rax+8]
       ret
; Total bytes of code 8
```

## .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Indexer_Struct()
       sub       rsp,28
       mov       rax,[rcx+18]
       cmp       dword ptr [rax+8],0A
       jbe       short M00_L00
       mov       eax,[rax+38]
       add       rsp,28
       ret
M00_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 28
```

## .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Getter_Struct()
       add       rcx,20
       mov       eax,[rcx]
       ret
; Total bytes of code 7
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Indexer_Class()
       sub       rsp,28
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],0A
       jbe       short M00_L00
       mov       rax,[rax+60]
       add       rsp,28
       ret
M00_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 29
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Getter_Class()
       mov       rax,[rcx+10]
       mov       eax,[rax+8]
       ret
; Total bytes of code 8
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Indexer_Struct()
       sub       rsp,28
       mov       rax,[rcx+18]
       cmp       dword ptr [rax+8],0A
       jbe       short M00_L00
       mov       eax,[rax+38]
       add       rsp,28
       ret
M00_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 28
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Getter_Struct()
       lea       rax,[rcx+20]
       mov       eax,[rax]
       ret
; Total bytes of code 7
```

