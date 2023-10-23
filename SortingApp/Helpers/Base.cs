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
}