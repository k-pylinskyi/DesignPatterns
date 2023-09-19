using ConsoleApp.Products.Chairs;
using ConsoleApp.Products.Sofas;
using ConsoleApp.Products.Tables;

namespace ConsoleApp.Factories;

public interface IAbstractFactory
{
    Chair CreateChair();
    Sofa CreateSofa();
    Table CreateTable();
    
}