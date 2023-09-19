namespace ConsoleApp.Products.Chairs;

public class ModernChair : Chair
{
    public ModernChair()
    {
        HasLegs = false;
    }
    
    public override void SitOn()
    {
        Console.WriteLine("You sit on Modern Chair");
    }
}