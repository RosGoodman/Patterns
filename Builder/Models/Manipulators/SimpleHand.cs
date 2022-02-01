
namespace Builder.Models.Manipulators;

internal class SimpleHand : ManipulatorAbstract
{
    internal override void MainAction()
    {
        Console.WriteLine("Хватает рукой предмет.");
    }

    internal override void Move()
    {
        Console.WriteLine("Двигает рукой.");
    }
}
