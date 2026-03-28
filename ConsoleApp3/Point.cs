namespace ConsoleApp3;

public struct Point
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public void Print()
    {
        Console.Write($"x coordinate is: {X}, y coordinate is {Y}");
    }
}