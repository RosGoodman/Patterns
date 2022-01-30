
namespace AbstractFctory.Entities.Tools;

internal class Screwdriver : ToolAbstract
{
    internal override void Use()
    {
        Console.WriteLine("Вращает отверткой.");
    }

    internal override void Position()
    {
        Console.WriteLine("Размещает в нужное положение отвертку.");
    }
}
