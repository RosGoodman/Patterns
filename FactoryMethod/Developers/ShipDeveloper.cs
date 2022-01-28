
using FactoryMethod.Products;

namespace FactoryMethod;

internal class ShipDeveloper : AbstractDeveloper
{
    public ShipDeveloper(string name) : base(name)
    {
    }

    internal override ProductionAbstract TransportCreate() => new Ship();
}
