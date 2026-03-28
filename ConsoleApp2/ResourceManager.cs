namespace ConsoleApp2;

public class ResourceManager<T> where T: Resource
{
    private readonly List<T> _resources = new List<T>();

    public void Add(T item)
    {
        _resources.Add(item);
    }

    public void OpenAll()
    {
        foreach (T element in _resources)
        {
            element.Open();
        }
    }
    
    public void CloseAll()
    {
        foreach (T element in _resources)
        {
            element.Close();
        }
    }
}