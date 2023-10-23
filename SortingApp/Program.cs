
using SortingApp.Helpers;
using SortingApp.Sorters;

while (true)
{
    var randomList = Generator.GenerateList();

    Base.Print("generated list: ", randomList);
    
    Base.NewLine();

    var mergeSorter = new MergeSorter();

    var sortedList = mergeSorter.Sort(randomList);

    Base.Print("sorted list: ", sortedList);
    
    Base.ClearConsole();
}