
using System.Diagnostics;
using SortingApp.Helpers;
using SortingApp.Sorters;

var stopwatch = new Stopwatch();

var sorterTypes = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => typeof(ISorter).IsAssignableFrom(p) && !p.IsInterface)
    .ToList();

var sorters = sorterTypes.Select(type => (ISorter)Activator.CreateInstance(type)!).ToList();

using var streamTxt = new StreamWriter("results.txt");
using var streamCsv = new StreamWriter("results.csv");

streamTxt.Write($"Size \t"); streamCsv.Write("size");

foreach (var sorter in sorters)
{
    streamTxt.Write($"{sorter.GetName()}\t"); streamCsv.Write($", {sorter.GetName()}");
}

streamTxt.WriteLine(); streamCsv.WriteLine();

for (var i = 1; i < 4; i++)
{
    for (var j = 1; j < 10; j++)
    {
        var size = (int)Math.Pow(10, i) * j;

        var list = Generator.GenerateList(size);
        
        streamTxt.Write($"{size} \t"); streamCsv.Write($"{size}");

        foreach (var sorter in sorters)
        {
            stopwatch.Start();

            var resultList = sorter.Sort(list);

            stopwatch.Stop();

            var isSorted = Base.IsSorted(resultList);

            var res = Math.Round(stopwatch.Elapsed.Ticks / (double)1000, 2);
            
            streamTxt.Write(isSorted ? $"{res}\t\t" : "f \t");
            streamCsv.Write(isSorted ? $", {res}" : ", f");
            
            stopwatch.Reset();
        }
        
        streamTxt.WriteLine(); streamCsv.WriteLine();
    }
}