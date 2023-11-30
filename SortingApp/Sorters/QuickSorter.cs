using SortingApp.Helpers;

namespace SortingApp.Sorters;

public  class QuickSorter : ISorter
{
    public List<int> Sort(List<int> list)
    {
        return Sort(list, 0, list.Count - 1);
    }

    private List<int> Sort(List<int> list, int left, int right)
    {
        var i = left;
        var j = right;
        var pivot = list[left];

        while (i <= j)
        {
            while (list[i] < pivot) i++;

            while (list[j] > pivot) j--;

            if (i > j) continue;
            
            Base.Swap(list,i, j);
            
            i++; j--;
        }

        if (left < j) Sort(list, left, j);

        if (i < right) Sort(list, i, right);

        return list;
    }

    public string GetName()
    {
        return "quick sort";
    }
}