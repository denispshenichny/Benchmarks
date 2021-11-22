``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.100
  [Host]             : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET 6.0           : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4161.0), X64 RyuJIT


```
|         Method |                Job |            Runtime |      Mean |     Error |    StdDev |    Median | Code Size |
|--------------- |------------------- |------------------- |----------:|----------:|----------:|----------:|----------:|
|  Indexer_Class |           .NET 6.0 |           .NET 6.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |      29 B |
|   Getter_Class |           .NET 6.0 |           .NET 6.0 | 0.0012 ns | 0.0020 ns | 0.0018 ns | 0.0000 ns |       8 B |
| Indexer_Struct |           .NET 6.0 |           .NET 6.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |      28 B |
|  Getter_Struct |           .NET 6.0 |           .NET 6.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |       7 B |
|  Indexer_Class | .NET Framework 4.8 | .NET Framework 4.8 | 0.2072 ns | 0.0718 ns | 0.2116 ns | 0.0401 ns |      29 B |
|   Getter_Class | .NET Framework 4.8 | .NET Framework 4.8 | 0.0818 ns | 0.0201 ns | 0.0215 ns | 0.0839 ns |       8 B |
| Indexer_Struct | .NET Framework 4.8 | .NET Framework 4.8 | 0.3134 ns | 0.0031 ns | 0.0029 ns | 0.3139 ns |      28 B |
|  Getter_Struct | .NET Framework 4.8 | .NET Framework 4.8 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |       7 B |


## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
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

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Getter_Class()
       mov       rax,[rcx+10]
       mov       eax,[rax+8]
       ret
; Total bytes of code 8
```

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
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

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Getter_Struct()
       add       rcx,20
       mov       eax,[rcx]
       ret
; Total bytes of code 7
```

## .NET Framework 4.8 (4.8.4161.0), X64 RyuJIT
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

## .NET Framework 4.8 (4.8.4161.0), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Getter_Class()
       mov       rax,[rcx+10]
       mov       eax,[rax+8]
       ret
; Total bytes of code 8
```

## .NET Framework 4.8 (4.8.4161.0), X64 RyuJIT
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

## .NET Framework 4.8 (4.8.4161.0), X64 RyuJIT
```assembly
; IndexerGetterBenchmark.IndexerVsGetterBenchmark.Getter_Struct()
       lea       rax,[rcx+20]
       mov       eax,[rax]
       ret
; Total bytes of code 7
```

