// See https://aka.ms/new-console-template for more information
using MultiProject.ClassLibrary;

using System.Data.Entity;

Console.WriteLine("Hello, World!");

NicksPublicClass nicksPublicClass = new();
nicksPublicClass.SayHello();

NicksPublicClassWithInternalMembers nicksPublicClassWithInternalMembers = new();
nicksPublicClassWithInternalMembers.InternalMethod();

NicksInternalClass nicksInternalClass = new();
nicksInternalClass.InternalMethod();

public class AppContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
}

public record Product(
    int Id,
    string Name,
    string Description,
    decimal Price);