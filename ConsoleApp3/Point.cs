namespace ConsoleApp3;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    

    public void Print()
    {
        Console.Write($"x coordinate is: {X}, y coordinate is {Y}");
    }
}