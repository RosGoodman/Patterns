
using FactoryMethod.Products;

namespace FactoryMethod;

internal abstract class AbstractDeveloper
{
    internal string Name { get; set; }

    public AbstractDeveloper(string name) => Name = name;

    internal abstract ProductionAbstract TransportCreate();
}
