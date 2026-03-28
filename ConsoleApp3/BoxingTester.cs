namespace ConsoleApp3;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        
        // boxing a into an object
        Object aAsObject = a; // besically just say that that a is an objest and create new value for it: aAsObject
        // also if we abject it, it means that this a is right now in heap, not stuck
        
        // unboxing a 

        int AASInt = (int)aAsObject; // say that object a is integer right now
        
        Console.WriteLine($"Here are all values: int a: {a}, object a(boxed a): {aAsObject}, a as an int (unboxed a): {AASInt}");




    }
}