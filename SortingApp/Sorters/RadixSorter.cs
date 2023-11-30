namespace SortingApp.Sorters;

public class RadixSorter : ISorter
{
    public List<int> Sort(List<int> list)
    {
        return RadixSort(list);
    }

    private static int GetMax(List<int> list)
    {
        int max = list[0];
        foreach (int num in list)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

    // Using counting sort to sort the elements based on significant places
    private static List<int> CountSort(List<int> list, int exp)
    {
        List<int> output = new List<int>(new int[list.Count]);
        int[] count = new int[10];

        // Initialize count array
        for (int i = 0; i < 10; i++)
            count[i] = 0;

        // Store count of occurrences in count[]
        foreach (int num in list)
            count[(num / exp) % 10]++;

        // Change count[i] so that count[i] contains the actual
        // position of this digit in output[]
        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        // Build the output list
        for (int i = list.Count - 1; i >= 0; i--)
        {
            output[count[(list[i] / exp) % 10] - 1] = list[i];
            count[(list[i] / exp) % 10]--;
        }

        return output;
    }

    // Radix Sort
    public static List<int> RadixSort(List<int> inputList)
    {
        // Clone the input list to avoid modifying the original list
        List<int> sortedList = new List<int>(inputList);

        // Find the maximum number to know the number of digits
        int max = GetMax(sortedList);

        // Do counting sort for every digit
        for (int exp = 1; max / exp > 0; exp *= 10)
            sortedList = CountSort(sortedList, exp);

        return sortedList;
    }

    
    public string GetName()
    {
        return "radix sort";
    }
}