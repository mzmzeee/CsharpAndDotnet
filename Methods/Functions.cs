public sealed class Functions
{
    public void RunExample()
    {
        // a return value is a value that is returned from a
        // method to the code that called it
        // methods with return values are called functions!
        // a method can only have one return value
        // and the return value must be of the same type
        // as the method

        // here is an example of a method with a return value
        int Add(int a, int b)
        {
            return a + b;
        }

        // we can call the method like this
        int sum = Add(5, 3);

        // we can also call the method like this
        int x = 5;
        int y = 3;
        int sum2 = Add(x, y);

        // we can also call the method like this
        int sum3 = Add(Add(1, 2), Add(3, 4));
        // int sum3 = Add(3, Add(3, 4));
        // int sum3 = Add(3, 7);
        // int sum3 = 10;

        // the return value must match the type of the method
        // so this would be an error
        //string Add(int a, int b)
        //{
        //    return a + b;
        //}

        // and similarly, this would be an error
        //string answer = Add(5, 3);

        Add(5, 3);
    }
}