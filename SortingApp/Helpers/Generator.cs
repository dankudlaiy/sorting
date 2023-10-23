namespace SortingApp.Helpers;

public static class Generator
{
    private static readonly Random Random = new Random();

    private const int MinListSize = 1;
    private const int MaxListSize = 20;
    private const int MinElementValue = -10000;
    private const int MaxElementValue = 10000;

    public static List<int> GenerateList()
    {
        var size = Random.Next(MinListSize, MaxListSize);
        return GenerateList(size);
    }

    public static List<int> GenerateList(int size)
    {
        return Enumerable.Range(0, size)
            .Select(r => Random.Next(MinElementValue, MaxElementValue))
            .ToList();
    }
}