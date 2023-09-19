using ConsoleApp.Products.Chairs;
using ConsoleApp.Products.Sofas;
using ConsoleApp.Products.Tables;

namespace ConsoleApp.Factories;

public class VictorianFactory : IAbstractFactory
{
    public Chair CreateChair()
    {
        return new VictorianChair();
    }

    public Sofa CreateSofa()
    {
        return new VictorianSofa();
    }

    public Table CreateTable()
    {
        return new VictorianTable();
    }
    
    public override string ToString()
    {
        return "Victorian Furniture";
    }
}