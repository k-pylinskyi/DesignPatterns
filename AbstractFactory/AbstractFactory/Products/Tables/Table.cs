namespace ConsoleApp.Products.Tables;

public abstract class Table
{
    public bool HasLegs { get; protected set; }

    public abstract void PutOn(string item);
}