namespace ConsoleApp2;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
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