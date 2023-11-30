namespace SortingApp.Sorters;

public interface ISorter
{
    public List<int> Sort(List<int> list);
    
    public string GetName();
}