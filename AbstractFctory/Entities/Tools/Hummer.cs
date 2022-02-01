
namespace AbstractFctory.Entities.Tools;

internal class Hummer : ToolAbstract
{
    internal override void Use()
    {
        Console.WriteLine("Бьет молотом.");
    }

    internal override void Position()
    {
        Console.WriteLine("Размещает в нужное положение молот.");
    }
}
