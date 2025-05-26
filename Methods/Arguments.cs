public sealed class Arguments
{
    public void RunExample()
    {
        // a parameter is a variable in a method definition. When a method is called
        // the arguments are the data you pass into the method's parameters.

        // the parameters go into the parantheses of the method
        // the arguments go into the parantheses of the method call

        // here is an example of a method with parameters
        void MyMethod(string name, int age)
        {
            // the method body
        }

        // here is an example of a method call with arguments
        MyMethod("Nick", 35);

        // can we build upon the example we saf earlier?
        // we can add a parameter to the method to make it more flexible!
        void PrintSeparator()
        {
            Console.WriteLine("------------");
        }

        void PrintHeader(string name)
        {
            PrintSeparator();
            Console.WriteLine(name);
            PrintSeparator();
        }

        PrintHeader("Example 1:");
        PrintHeader("Example 2:");
        PrintHeader("Example 3:");
    }
}