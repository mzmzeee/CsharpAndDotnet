Console.WriteLine("Pick an example class to run!");
Console.WriteLine("creatingClasses\nReferenceType\nFieldsAndProperties\nStaticVsinstance\nConstructors");
string? input = Console.ReadLine();
switch (input)
{
    case "1":
        new CreatingClasses().RunExample();
        break;
    case "2":
        new ReferenceType().RunExample();
        break;
    case "3":
        new FieldsAndProperties().RunExample();
        break;
    case "4":
        new StaticVsInstance().RunExample();
        break;
    case "5":
        new Constructors().RunExample();
        break;
}