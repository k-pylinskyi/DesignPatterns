namespace ConsoleApp.Products.Sofas;

public class ModernSofa : Sofa
{
    public ModernSofa()
    {
        HasLegs = false;
    }
    
    public override void SitOn()
    {
        Console.WriteLine("You sit on Modern Sofa");
    }
}