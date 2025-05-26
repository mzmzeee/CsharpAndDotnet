namespace MultiProject.ClassLibrary;

public class NicksPublicClassWithInternalMembers
{
    public void PublicMethod()
    {
        Console.WriteLine("Hello from the public method on the public class!");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Hello from the internal method on the public class!");
    }
}
