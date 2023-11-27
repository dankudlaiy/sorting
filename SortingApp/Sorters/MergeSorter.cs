namespace SortingApp.Sorters;

public class MergeSorter : ISorter
{
    public List<int> Sort(List<int> list)
    {
        if (list.Count is 1) return list;

        var centerIndex = list.Count / 2;
        var left = list.Take(centerIndex).ToList();
        var right = list.Skip(centerIndex).Take(list.Count - centerIndex).ToList();

        var sortedLeft = Sort(left);
        var sortedRight = Sort(right);

        var sorted = new List<int>();

        var leftIndex = 0;
        var rightIndex = 0;

        while (sorted.Count < list.Count)
        {
            if (leftIndex < sortedLeft.Count && rightIndex < sortedRight.Count)
            {
                if (sortedLeft[leftIndex] <= sortedRight[rightIndex])
                {
                    sorted.Add(sortedLeft[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    sorted.Add(sortedRight[rightIndex]);
                    rightIndex++;
                }
            }  else if (leftIndex < sortedLeft.Count)
            {
                sorted.Add(sortedLeft[leftIndex]);
                leftIndex++;
            }
            else if (rightIndex < sortedRight.Count)
            {
                sorted.Add(sortedRight[rightIndex]);
                rightIndex++;
            }
        }

        return sorted;
    }

    public string GetName()
    {
        return "merge sort";
    }
}