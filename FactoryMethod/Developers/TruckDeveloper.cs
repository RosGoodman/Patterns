
using FactoryMethod.Products;

namespace FactoryMethod;

internal class TruckDeveloper : AbstractDeveloper
{
    public TruckDeveloper(string name) : base(name)
    {
    }

    internal override ProductionAbstract TransportCreate() => new Truck();
}
