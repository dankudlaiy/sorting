
using SortingApp.Helpers;
using SortingApp.Sorters;

while (true)
{
    var randomList = Generator.GenerateList();

    Base.Print("generated list: ", randomList);
    
    Base.NewLine();

    var sorter = new InsertionSorter();

    var sortedList = sorter.Sort(randomList);

    Base.Print("sorted list: ", sortedList);
    
    Base.ClearConsole();
}