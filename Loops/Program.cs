Console.WriteLine("Pick an example class to run!");
Console.WriteLine("1. WhileLoops");
Console.WriteLine("2. ForLoops");
Console.WriteLine("3. ForeachLoops");
string? choice = Console.ReadLine();
switch (choice)
{
    case "1":
        new WhileLoops().RunExample();
        break;
    case "2":
        new ForLoops().RunExample();
        break;
    case "3":
        new ForeachLoops().RunExample();
        break;
    default:
        Console.WriteLine("Invalid choice!");
        break;
}