namespace ConsoleApp.Products.Tables;

public class ModernTable : Table
{
    public ModernTable()
    {
        HasLegs = true;
    }
    
    public override void PutOn(string item)
    {
        Console.WriteLine($"You put on {item} on Modern Table");
    }
}