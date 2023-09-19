namespace ConsoleApp.Products.Chairs;

public class VictorianChair : Chair
{
    public VictorianChair()
    {
        HasLegs = true;
    }
    
    public override void SitOn()
    {
        Console.WriteLine("You sit on Victorian chair");
    }
}