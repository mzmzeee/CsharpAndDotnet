Console.WriteLine("Pick an example class to run!");
Console.WriteLine("1-ifstatements\n2-switchstatements and expressions\n3-ternaryoperators");
string? decision = Console.ReadLine();
switch (decision)
{
    case "1":
        new IfStatements().RunExample();
        break;
    case "2":
        new SwitchStatementAndExpression().RunExample();
        break;
    case "3":
        new TernaryOperators().RunExample();
        break;
    default:
        Console.WriteLine("error");
        break;
}