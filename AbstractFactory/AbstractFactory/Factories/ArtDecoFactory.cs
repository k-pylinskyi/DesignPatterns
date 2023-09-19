using ConsoleApp.Products.Chairs;
using ConsoleApp.Products.Sofas;
using ConsoleApp.Products.Tables;

namespace ConsoleApp.Factories;

public class ArtDecoFactory : IAbstractFactory
{
    public Chair CreateChair()
    {
        return new ArtDecoChair();
    }

    public Sofa CreateSofa()
    {
        return new ArtDecoSofa();
    }

    public Table CreateTable()
    {
        return new ArtDecoTable();
    }

    public override string ToString()
    {
        return "Art Deco Furniture";
    }
}