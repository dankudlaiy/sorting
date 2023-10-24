using SortingApp.Helpers;

namespace SortingApp.Sorters;

public class InsertionSorter
{
    public List<int> Sort(List<int> list)
    {
        if (list.Count is 1) return list;

        for (var i = 1; i < list.Count; i++)
        {
            for (var j = i; j >= 1; j--)
            {
                if (list[j] < list[j - 1])
                {
                    Base.Swap(list, j, j - 1);
                }
            }
        }

        return list;
    }
}