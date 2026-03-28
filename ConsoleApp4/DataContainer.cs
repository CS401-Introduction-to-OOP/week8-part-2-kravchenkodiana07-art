namespace ConsoleApp4;

public class DataContainer<T> where T: DataItem
{
    private readonly List<T> _items = new();
    private long sizeOfAllItems = 0;

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public long GetTotalSize()
    {
        sizeOfAllItems = 0;
        foreach (T elements in _items )
        {
            sizeOfAllItems += elements.GetSize();
        }

        return sizeOfAllItems;
    }
}