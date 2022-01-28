
namespace FactoryMethod.Products;

internal class Truck : ProductionAbstract
{
    public Truck()
    {
        Console.WriteLine("Грузовик простоен.");
    } 
}
