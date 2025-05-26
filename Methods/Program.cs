Console.WriteLine("Pick an example class to run!");
Console.WriteLine("simplemehods\narguments\nfunctions");
string? input = Console.ReadLine();
switch (input)
{
    case "1":
        new SimpleMethods().RunExample();
        break;
    case "2":
        new Arguments().RunExample();
        break;
    case "3":
        new Functions().RunExample();
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}