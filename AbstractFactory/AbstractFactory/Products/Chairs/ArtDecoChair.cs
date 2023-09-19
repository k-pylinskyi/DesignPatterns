namespace ConsoleApp.Products.Chairs;

public class ArtDecoChair : Chair
{
    public ArtDecoChair()
    {
        HasLegs = true;
    }
    
    public override void SitOn()
    {
        Console.WriteLine("You sit on Art Deco Chair");
    }
}