
using FactoryMethod.Products;

namespace FactoryMethod;

internal class AirplaneDeveloper : AbstractDeveloper
{
    public AirplaneDeveloper(string name) : base(name)
    {
    }

    internal override ProductionAbstract TransportCreate() => new Airplane();
}
