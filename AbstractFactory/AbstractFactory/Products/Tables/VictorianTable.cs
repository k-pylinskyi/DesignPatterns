namespace ConsoleApp.Products.Tables;

public class VictorianTable : Table
{
    public VictorianTable()
    {
        HasLegs = true;
    }
    
    public override void PutOn(string item)
    {
        Console.WriteLine($"You put {item} on Victorian Table");
    }
}