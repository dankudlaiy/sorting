using SortingApp.Helpers;

namespace SortingApp.Sorters;

public  class QuickSorter : ISorter
{
    public List<int> Sort(List<int> list)
    {
        QuickSortRecursive(list, 0, list.Count - 1);

        return list;
    }

    private static void QuickSortRecursive(List<int> list, int low, int high)
    {
        while (true)
        {
            if (low >= high) return;

            var partitionIndex = Partition(list, low, high);

            QuickSortRecursive(list, low, partitionIndex - 1);
            low = partitionIndex + 1;
        }
    }

    private static int Partition(List<int> list, int low, int high)
    {
        var pivot = list[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
        {
            if (list[j] > pivot) continue;
            
            i++;
            Base.Swap(list, i, j);
        }

        Base.Swap(list, i + 1, high);

        return i + 1;
    }

    public string GetName()
    {
        return "quick sort";
    }
}