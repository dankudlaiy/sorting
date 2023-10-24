namespace SortingApp.Helpers;

public static class Base
{
    public static void Print(List<int> list)
    {
        foreach (var el in list)
        {
            Console.Write($"{el} ");
        }
    }

    public static void Print(string msg, List<int> list)
    {
        Console.Write(msg);
        Print(list);
    }

    public static void ClearConsole()
    {
        Console.ReadLine();
        Console.Clear();
    }

    public static void NewLine()
    {
        Console.Write("\n");
    }

    public static bool Swap(List<int> list, int a, int b)
    {
        if(a >= list.Count || b >= list.Count || a < 0 || b < 0)
            return false;
        
        (list[b], list[a]) = (list[a], list[b]);

        return true;
    }
}