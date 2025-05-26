// debugging is the process of finding and
// fixing errors within a computer program
// errors in our C# programs are called exceptions
// exceptions are "thrown" when the program encounters an error

// let's create a simple program that throws an exception
int IntegerDivision(int x, int y)
{
    return x / y;
}

// the program will throw an exception when we try to divide by zero
//int result = IntegerDivision(10, 0);


// exceptions are caught using try-catch blocks
// try-catch blocks look like this:
try
{
    // code that might throw an exception
}
catch (Exception e)
{
    // code that runs if an exception is thrown
}

// let's catch the exception from our IntegerDivision method
try
{
    IntegerDivision(10, 0);
}
catch (Exception e)
{
    Console.WriteLine("An exception was thrown!");
    Console.WriteLine(e.Message);
}

// we can catch specific types of exceptions and handle them differently
try
{
    IntegerDivision(10, 0);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You can't divide by zero!");
}
catch (Exception e)
{
    Console.WriteLine("An exception was thrown!");
    Console.WriteLine(e.Message);
}

// we can also use exception filters to catch exceptions that meet certain conditions
try
{
    IntegerDivision(10, 0);
}
catch (Exception e) when (e.Message.Contains("divide by zero"))
{
    Console.WriteLine("You can't divide by zero!");
}
catch (Exception e)
{
    Console.WriteLine("An exception was thrown!");
    Console.WriteLine(e.Message);
}

// we can use a finally block to run code after a try-catch block
try
{
    IntegerDivision(10, 0);
    //
    //
    //
}
catch (Exception e)
{
    Console.WriteLine("An exception was thrown!");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("This code always runs!");
}