// See https://aka.ms/new-console-template for more information

namespace Exercises;

class Program
{
    static void Main(string[] args)
    {
        // 1
        // Console.WriteLine("Enter number (1-10):");
        // int number = Int32.Parse(Console.ReadLine());
        //
        // Console.WriteLine(number is > 0 and < 11 ? "Valid" : "Invalid");
        
        // 2
        // Console.WriteLine("Enter number (1-10):");
        // int number1 = Int16.Parse(Console.ReadLine());
        // Console.WriteLine("Enter another number (1-10):");
        // int number2 = Int16.Parse(Console.ReadLine());
        // int[] array = new int[] { number1, number2 };
        // int max = array.Max();
        //
        // Console.WriteLine($"The max is: {max}");
        // foreach(var item in array)
        // {
        //     Console.WriteLine(item.ToString());
        // }
        
        // 3
        // Console.WriteLine("Length?");
        // int length = Int16.Parse(Console.ReadLine());
        // Console.WriteLine("Width?");
        // int width = Int16.Parse(Console.ReadLine());
        //
        // Console.WriteLine(width > length ? "Landscape" : "Portrait");
        
        // 4
        // Console.WriteLine("What's the speed limit?");
        // int speedLimit = Int16.Parse(Console.ReadLine());
        //
        // Console.WriteLine("What's the speed of this car?");
        // int carSpeed = Int16.Parse(Console.ReadLine());
        //
        // int diff = carSpeed - speedLimit;
        // int demerit = diff / 5;
        //
        // if (carSpeed < speedLimit)
        //     Console.WriteLine("OK");
        // else if (demerit >= 12)
        //     Console.WriteLine("License Suspended");

        // 1
        // var count = 0;
        // for (var i = 0; i <= 100; i++)
        // {
        //     if (i % 3 == 0)
        //         count += 1;
        // }
        //
        // Console.WriteLine(count);
        
        // 2
        while (true)
        {
            Console.WriteLine("Enter a number:");
            var input = Console.ReadLine();

            if (input != "OK")
            {
                Console.WriteLine("@Echo: " + input);
                continue;
            }

            break;
        }
    }
}