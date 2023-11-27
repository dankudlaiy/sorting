using SortingApp.Helpers;

namespace SortingApp.Sorters;

public class HeapSorter : ISorter
{
    public List<int> Sort(List<int> list)
    {
        var n = list.Count;
        
        for (var i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(list, n, i);
        }

        for (var i = n - 1; i > 0; i--)
        {
            Base.Swap(list, 0, i);

            Heapify(list, i, 0);
        }

        return list;
    }

    private static void Heapify(List<int> list, int n, int i)
    {
        while (true)
        {
            var largest = i;
            var left = 2 * i + 1;
            var right = 2 * i + 2;

            if (left < n && list[left] > list[largest])
            {
                largest = left;
            }

            if (right < n && list[right] > list[largest])
            {
                largest = right;
            }

            if (largest == i) return;

            Base.Swap(list, i, largest);

            i = largest;
        }
    }

    public string GetName()
    {
        return "heap sort";
    }
}
