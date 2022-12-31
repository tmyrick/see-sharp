// See https://aka.ms/new-console-template for more information
using System;
using NonPrims.Math;

namespace NonPrims
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            Arry arr = new Arry();
            arr.Foo();

            Str str = new Str();
            str.Main();

        }
    }
}