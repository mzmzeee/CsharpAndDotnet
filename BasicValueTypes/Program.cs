using System;

namespace BasicValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick an example class to run:");
            Console.WriteLine("1: IntegerVariables");
            Console.WriteLine("2: StringVariables");
            Console.WriteLine("3: FloatAndDoubleVariables");
            Console.WriteLine("4: DateTimeVariables");
            Console.WriteLine("5: BoleanVariables");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new IntegerVariables().RunExample();
                    break;
                case "2":
                    new StringVariables().RunExample();
                    break;
                case "3":
                    new FloatAndDoubleVariables().RunExample();
                    break;
                case "4":
                    new DateTimeVariables().RunExample();
                    break;
                case "5":
                    new BoleanVariables().RunExample();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}