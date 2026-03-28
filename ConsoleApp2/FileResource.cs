namespace ConsoleApp2;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
        
    }
    

    public override void Close()
    {
        IsOpen = false;
    }

    public override void Open()
    {
        IsOpen = true;
    }
    
    public void Dispose()
    {
        Close();
    }
}