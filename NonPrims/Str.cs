using System;

namespace NonPrims;

public class Str
{
    public void Main()
    {
        Console.WriteLine("\nSTRINGS");

        var firstName = "travis";
        var lastName = "myrick";
        string name = string.Format("{0} {1}", firstName, lastName);

        Console.WriteLine(name);

        var numbers = new int[] { 1, 2, 3 };
        String list = string.Join(",", numbers);

        Console.WriteLine(list);

        // string path = "c:\\projects\\mayhem\\dir1";
        string path = @"c:\projects\mayhem\dir1";

        Console.WriteLine(path);
    }
}