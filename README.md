# LinqPerformanceBenchmark

run: `dotnet run --configuration Release`

Benchmark.net: https://benchmarkdotnet.org/

Video: https://www.youtube.com/watch?v=zCKwlgtVLnQ


|  Method | Size |     Mean |   Error |  StdDev | Allocated |
|-------- |----- |---------:|--------:|--------:|----------:|
|     Min |  100 | 354.4 ns | 3.94 ns | 3.49 ns |      32 B |
|     Max |  100 | 309.1 ns | 5.62 ns | 5.26 ns |      32 B |
| Average |  100 | 331.2 ns | 6.46 ns | 8.17 ns |      32 B |
|     Sum |  100 | 310.0 ns | 5.95 ns | 5.84 ns |      32 B |
