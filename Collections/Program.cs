using System.Collections;

Console.WriteLine("Pick an example class to run!");
Console.WriteLine("1. Arrays");
Console.WriteLine("2. Lists");
Console.WriteLine("3. Dictionaries");
string? answer = Console.ReadLine();
switch (answer)
{
    case "1":
        new Arrays().RunExample();
        break;
    case "2":
        new Lists().RunExample();
        break;
    case "3":
        new Dictionaries().RunExample();
        break;
    default:
        Console.WriteLine("error");
        break;
}