Console.WriteLine("Choose an example to run!");
Console.WriteLine("1. CallbacksAndDelegates");
Console.WriteLine("2. Events");
Console.WriteLine("3. LinqMethods");
Console.WriteLine("4. LinqAndLaziness");
Console.WriteLine("5. ExtensionMethods");
string? choice = Console.ReadLine();
switch (choice)
{
    case "1":
        new CallbacksAndDelegates().RunExample();
        break;
    case "2":
        new Events().RunExample();
        break;
    case "3":
        new LinqMethods().RunExample();
        break;
    case "4":
        new Laziness().RunExample();
        break;
    case "5":
        new ExtensionMethods().RunExample();
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}