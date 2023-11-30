namespace SortingApp.Helpers;

public static class Generator
{
    private static readonly Random Random = new();
    
    private const int MinElementValue = -1000;
    private const int MaxElementValue = 1000;

    public static List<int> GenerateList(int size)
    {
        return Enumerable.Range(0, size)
            .Select(r => Random.Next(MinElementValue, MaxElementValue))
            .ToList();
    }
}