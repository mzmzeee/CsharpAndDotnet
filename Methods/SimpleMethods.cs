public sealed class SimpleMethods
{
    public void RunExample()
    {
        // a method is a block of code that performs a specific task
        // we use methods to break our code into smaller, more manageable pieces!

        // here is an example of a method
        void ThisIsAMethod()
        {
            // this is the body of the method
        }

        // we can call the method like this
        ThisIsAMethod();

        // if we had code like the following, how might
        // we go make a method for it?
        Console.WriteLine("------------");
        Console.WriteLine("New Example!");
        Console.WriteLine("------------");

        // we could make a method like this:
        void PrintSeparator()
        {
            Console.WriteLine("------------");
        }

        // and then call it like this
        PrintSeparator();
        Console.WriteLine("New Example!");
        PrintSeparator();

        // we could take it a step further and make ANOTHER
        
        // we could take it a step further and make ANOTHER
        // method that prints out the entire header
        void PrintHeader()
        {
            PrintSeparator();
            Console.WriteLine("New Example!");
            PrintSeparator();
        }

        // and then call it like this
        PrintHeader();
    }
}