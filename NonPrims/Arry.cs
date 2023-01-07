namespace NonPrims;

public class Arry
{
    public void Foo()
    {
        // int[] numbers = new int[3];
        //
        // numbers[0] = 1;
        // numbers[1] = 2;
        // numbers[2] = 3;
        Console.WriteLine("\nARRAYS");
        var numbers = new int[3] { 1, 2, 3 };
        
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);

        var flags = new bool[3] { true, false, true };

        Console.WriteLine(flags[0]);
        Console.WriteLine(flags[1]);
        Console.WriteLine(flags[2]);

        var names = new string[4] { "Travis", "KT", "Osiris", "Bittens" };

        Console.WriteLine(names.Length);
    }
}