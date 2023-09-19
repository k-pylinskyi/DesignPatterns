namespace ConsoleApp.Products.Sofas;

public class VictorianSofa : Sofa
{
    public VictorianSofa()
    {
        HasLegs = true;
    }
    
    public override void SitOn()
    {
        Console.WriteLine("You sit on Victorian Sofa");
    }
}