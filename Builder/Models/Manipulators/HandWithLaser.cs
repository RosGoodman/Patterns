
namespace Builder.Models.Manipulators;

internal class HandWithLaser : ManipulatorAbstract
{
    internal override void MainAction()
    {
        Console.WriteLine("Стреяет из лазера в руке.");
    }

    internal override void Move()
    {
        Console.WriteLine("Двигает рукой.");
    }
}
