﻿// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using LinqPerformance;

Console.WriteLine("Hello, World!");


BenchmarkRunner.Run<Benchmarks>();

