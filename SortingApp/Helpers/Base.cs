namespace SortingApp.Helpers;

public static class Base
{
    public static void Print(string msg, List<int> list)
    {
        Console.Write(msg);
        
        foreach (var el in list)
        {
            Console.Write($"{el} ");
        }

        Console.WriteLine();
    }

    public static void ClearConsole()
    {
        Console.ReadLine();
        Console.Clear();
    }

    public static bool IsSorted(List<int> list)
    {
        return list.Zip(list.Skip(1), (a, b) => a <= b).All(x => x);
    }

    public static bool Swap(List<int> list, int a, int b)
    {
        if(a >= list.Count || b >= list.Count || a < 0 || b < 0)
            return false;
        
        (list[b], list[a]) = (list[a], list[b]);

        return true;
    }
}