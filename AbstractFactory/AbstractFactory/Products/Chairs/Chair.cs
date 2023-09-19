namespace ConsoleApp.Products.Chairs;

public abstract class Chair
{
    public bool HasLegs { get; protected set; }
    public abstract void SitOn();
}