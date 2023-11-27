
using System.Diagnostics;
using SortingApp.Helpers;
using SortingApp.Sorters;

var stopwatch = new Stopwatch();

var sorterTypes = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => typeof(ISorter).IsAssignableFrom(p) && !p.IsInterface)
    .ToList();

while (true)
{
    var randomList = Generator.GenerateList();
    
    Console.WriteLine($"Generated list ({randomList.Count})\n");

    foreach (var type in sorterTypes)
    {
        var sorter = (ISorter)Activator.CreateInstance(type)!;

        var name = sorter.GetName();

        stopwatch.Start();

        var resultList = sorter.Sort(randomList);

        stopwatch.Stop();

        var isSorted = Base.IsSorted(resultList);

        Console.WriteLine($"{name}, {stopwatch.ElapsedMilliseconds} mls, {(isSorted ? "sorted" : "not sorted")}");

        stopwatch.Reset();
    }
    
    Base.ClearConsole();
}