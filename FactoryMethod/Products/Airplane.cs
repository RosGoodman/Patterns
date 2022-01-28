
namespace FactoryMethod.Products;

internal class Airplane : ProductionAbstract
{
    public Airplane()
    {
        Console.WriteLine("Самолет построен.");
    } 
}
