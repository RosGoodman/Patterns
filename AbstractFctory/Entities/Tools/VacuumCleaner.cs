
namespace AbstractFctory.Entities.Tools;

internal class VacuumCleaner : ToolAbstract
{
    internal override void Use()
    {
        Console.WriteLine("Пылесосит.");
    }

    internal override void Position()
    {
        Console.WriteLine("Размещает в нужное положение пылесос.");
    }
}
