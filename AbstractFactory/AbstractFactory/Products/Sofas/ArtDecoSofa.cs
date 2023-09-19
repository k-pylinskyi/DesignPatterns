using System.Runtime.InteropServices;

namespace ConsoleApp.Products.Sofas;

public class ArtDecoSofa : Sofa
{
    public ArtDecoSofa()
    {
        HasLegs = true;
    }

    public override void SitOn()
    {
        Console.WriteLine("You sit on Art Deco Sofa");
    }
}