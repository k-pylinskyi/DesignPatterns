using System.Security.Cryptography.X509Certificates;
using ConsoleApp.Factories;

var factories = new List<IAbstractFactory>
{
    new ArtDecoFactory(),
    new VictorianFactory(),
    new ModernFactory()
};

Console.WriteLine("Choose furniture style  variant and enter the number");

for (int i = 0; i < factories.Count; i++)
{
    Console.WriteLine($"{i + 1}. {factories[i]}");
}

var userEnteredValue = Console.ReadLine();

var isSuccess = int.TryParse(userEnteredValue, out int selectedStyle);

if (!isSuccess)
{
    Console.WriteLine("Critical error, please reboot your PC");
    Console.ReadKey();
    return;
}

selectedStyle--;

if (selectedStyle < 0 || selectedStyle >= factories.Count)
{
    Console.WriteLine("Critical error, please reboot your PC");
    Console.ReadKey();
    return;
}

IAbstractFactory factory = factories[selectedStyle];

var chair = factory.CreateChair();
var sofa = factory.CreateSofa();
var table = factory.CreateTable();
    
chair.SitOn();
sofa.SitOn();
table.PutOn("book");
