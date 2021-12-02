``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1348 (21H1/May2021Update)
Intel Core i3-8100 CPU 3.60GHz (Coffee Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]             : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET 6.0           : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT


```
|                  Method |                Job |            Runtime |     Mean |     Error |    StdDev | Code Size |
|------------------------ |------------------- |------------------- |---------:|----------:|----------:|----------:|
|              DoubleCast |           .NET 6.0 |           .NET 6.0 | 3.264 ns | 0.0843 ns | 0.0788 ns |      89 B |
|           DoubleCast_As |           .NET 6.0 |           .NET 6.0 | 1.957 ns | 0.0031 ns | 0.0028 ns |      48 B |
|              CachedCast |           .NET 6.0 |           .NET 6.0 | 1.733 ns | 0.0046 ns | 0.0043 ns |      46 B |
|         PatternMatching |           .NET 6.0 |           .NET 6.0 | 1.735 ns | 0.0046 ns | 0.0043 ns |      46 B |
|      DoubleCast_Virtual |           .NET 6.0 |           .NET 6.0 | 2.535 ns | 0.0051 ns | 0.0043 ns |      95 B |
|   DoubleCast_As_Virtual |           .NET 6.0 |           .NET 6.0 | 1.979 ns | 0.0187 ns | 0.0175 ns |      54 B |
|      CachedCast_Virtual |           .NET 6.0 |           .NET 6.0 | 1.944 ns | 0.0089 ns | 0.0083 ns |      54 B |
| PatternMatching_Virtual |           .NET 6.0 |           .NET 6.0 | 1.942 ns | 0.0053 ns | 0.0041 ns |      54 B |
|              DoubleCast | .NET Framework 4.8 | .NET Framework 4.8 | 3.097 ns | 0.0089 ns | 0.0083 ns |      85 B |
|           DoubleCast_As | .NET Framework 4.8 | .NET Framework 4.8 | 2.491 ns | 0.0085 ns | 0.0080 ns |      45 B |
|              CachedCast | .NET Framework 4.8 | .NET Framework 4.8 | 2.480 ns | 0.0051 ns | 0.0048 ns |      43 B |
|         PatternMatching | .NET Framework 4.8 | .NET Framework 4.8 | 2.492 ns | 0.0079 ns | 0.0070 ns |      43 B |
|      DoubleCast_Virtual | .NET Framework 4.8 | .NET Framework 4.8 | 2.623 ns | 0.0077 ns | 0.0072 ns |      87 B |
|   DoubleCast_As_Virtual | .NET Framework 4.8 | .NET Framework 4.8 | 2.480 ns | 0.0015 ns | 0.0013 ns |      47 B |
|      CachedCast_Virtual | .NET Framework 4.8 | .NET Framework 4.8 | 2.486 ns | 0.0038 ns | 0.0035 ns |      47 B |
| PatternMatching_Virtual | .NET Framework 4.8 | .NET Framework 4.8 | 2.492 ns | 0.0043 ns | 0.0039 ns |      47 B |



## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.DoubleCast()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L01
       mov       rdx,[rsi+8]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M00_L00
       mov       rax,offset MT_CastBenchmark.A
       cmp       [rcx],rax
       je        short M00_L00
       mov       rcx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       rcx,rax
M00_L00:
       cmp       [rcx],ecx
       add       rsp,20
       pop       rsi
       jmp       near ptr CastBenchmark.A.Do()
M00_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 88
```
```assembly
; CastBenchmark.A.Do()
       ret
; Total bytes of code 1
```

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.DoubleCast_As()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       cmp       [rcx],ecx
       add       rsp,28
       jmp       near ptr CastBenchmark.A.Do()
M00_L00:
       add       rsp,28
       ret
; Total bytes of code 47
```
```assembly
; CastBenchmark.A.Do()
       ret
; Total bytes of code 1
```

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.CachedCast()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr CastBenchmark.A.Do()
M00_L00:
       add       rsp,28
       ret
; Total bytes of code 45
```
```assembly
; CastBenchmark.A.Do()
       ret
; Total bytes of code 1
```

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.PatternMatching()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr CastBenchmark.A.Do()
M00_L00:
       add       rsp,28
       ret
; Total bytes of code 45
```
```assembly
; CastBenchmark.A.Do()
       ret
; Total bytes of code 1
```

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.DoubleCast_Virtual()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L01
       mov       rdx,[rsi+8]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M00_L00
       mov       rax,offset MT_CastBenchmark.A
       cmp       [rcx],rax
       je        short M00_L00
       mov       rcx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       rcx,rax
M00_L00:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       mov       rax,[rax+20]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 95
```

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.DoubleCast_As_Virtual()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+20]
       add       rsp,28
       jmp       rax
M00_L00:
       add       rsp,28
       ret
; Total bytes of code 54
```

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.CachedCast_Virtual()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+20]
       add       rsp,28
       jmp       rax
M00_L00:
       add       rsp,28
       ret
; Total bytes of code 54
```

## .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.PatternMatching_Virtual()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+20]
       add       rsp,28
       jmp       rax
M00_L00:
       add       rsp,28
       ret
; Total bytes of code 54
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.DoubleCast()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L01
       mov       rdx,[rsi+8]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M00_L00
       mov       rax,offset MT_CastBenchmark.A
       cmp       [rcx],rax
       je        short M00_L00
       mov       rcx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       rcx,rax
M00_L00:
       cmp       [rcx],ecx
       call      CastBenchmark.A.Do()
M00_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 84
```
```assembly
; CastBenchmark.A.Do()
       ret
; Total bytes of code 1
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.DoubleCast_As()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L00
       cmp       [rcx],ecx
       call      CastBenchmark.A.Do()
M00_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 44
```
```assembly
; CastBenchmark.A.Do()
       ret
; Total bytes of code 1
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.CachedCast()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L00
       call      CastBenchmark.A.Do()
M00_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 42
```
```assembly
; CastBenchmark.A.Do()
       ret
; Total bytes of code 1
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.PatternMatching()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L00
       call      CastBenchmark.A.Do()
M00_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 42
```
```assembly
; CastBenchmark.A.Do()
       ret
; Total bytes of code 1
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.DoubleCast_Virtual()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L01
       mov       rdx,[rsi+8]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M00_L00
       mov       rax,offset MT_CastBenchmark.A
       cmp       [rcx],rax
       je        short M00_L00
       mov       rcx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       rcx,rax
M00_L00:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M00_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 87
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.DoubleCast_As_Virtual()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M00_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 47
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.CachedCast_Virtual()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M00_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 47
```

## .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
```assembly
; CastBenchmark.CastingBenchmark.PatternMatching_Virtual()
       sub       rsp,28
       mov       rdx,[rcx+8]
       mov       rcx,offset MT_CastBenchmark.A
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M00_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 47
```

