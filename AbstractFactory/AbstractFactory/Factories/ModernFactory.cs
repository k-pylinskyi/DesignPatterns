using ConsoleApp.Products.Chairs;
using ConsoleApp.Products.Sofas;
using ConsoleApp.Products.Tables;

namespace ConsoleApp.Factories;

public class ModernFactory : IAbstractFactory
{
    public Chair CreateChair()
    {
        return new ModernChair();
    }

    public Sofa CreateSofa()
    {
        return new ModernSofa();
    }

    public Table CreateTable()
    {
        return new ModernTable();
    }
    
    public override string ToString()
    {
        return "Modern Furniture";
    }
}