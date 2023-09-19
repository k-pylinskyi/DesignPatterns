namespace ConsoleApp.Products.Tables;

public class ArtDecoTable : Table
{
    public ArtDecoTable()
    {
        HasLegs = false;
    }
    
    public override void PutOn(string item)
    {
        Console.WriteLine($"You put {item} on Art Deco Table");
    }
}