public sealed class WhileLoops
{
    public void RunExample()
    {
        // while loops and do while loops are used
        // to execute a block of code repeatedly.

        // here is what a while loop looks like
        // while (condition)
        // {
        //     // code to execute
        // }

        // here is what a do while loop looks like
        // do
        // {
        //     // code to execute
        // }
        // while (condition)

        // let's make some real ones!

        // here is a while loop that counts to 5
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine(count);
            count++;
        }

        Console.WriteLine($"The total count is {count}!");

        // here is a do while loop that counts to 5
        count = 0;
        do
        {
            Console.WriteLine(count);
            count++;
        } while (count < 5);
        Console.WriteLine($"The total count is {count}!");

        // what happens if we change the condition to false
        // for a while loop?
        count = 0;
        while (count > 5)
        {
            Console.WriteLine(count);
            count++;
        }
        Console.WriteLine($"The total count is {count}!");

        // what happens if we change the condition to false
        // for a do while loop?
        count = 0;
        do
        {
            Console.WriteLine(count);
            count++;
        } while (count > 5);
        Console.WriteLine($"The total count is {count}!");

        // let's add a condition to the while loop
        // so we can see the behavior of
        // break and continue
        count = 0;
        while (count < 50)
        {
            if (count == 3)
            {
                count++;
                Console.WriteLine("I'm skipping 3!");
                continue;
            }

            Console.WriteLine(count);
            count++;

            if (count == 5)
            {
                Console.WriteLine("I'm out of here!");
                break;
            }
        }
    }
}