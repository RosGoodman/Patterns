
namespace FactoryMethod.Products;

internal class Ship : ProductionAbstract
{
    public Ship()
    {
        Console.WriteLine("Корабль построен.");
    } 
}
