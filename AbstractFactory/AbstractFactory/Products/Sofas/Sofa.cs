namespace ConsoleApp.Products.Sofas;

public abstract class Sofa
{
    public bool HasLegs { get; protected set; }

    public abstract void SitOn();
}