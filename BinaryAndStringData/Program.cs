Console.WriteLine("Choose an example to run:");
Console.WriteLine("1. XmlAndJson");
Console.WriteLine("2. StreamIntroduction");
Console.WriteLine("3. ReadingAndWritingFiles");
Console.WriteLine("4. EncodingStringsAndBytes");
Console.WriteLine("5. DisposableAndUsing");

string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
        new XmlAndJson().RunExample();
        break;
    case "2":
        new StreamIntroduction().RunExample();
        break;
    case "3":
        new ReadingAndWritingFiles().RunExample();
        break;
    case "4":
        new EncodingStringsAndBytes().RunExample();
        break;
    case "5":
        new DisposableAndUsing().RunExample();
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}