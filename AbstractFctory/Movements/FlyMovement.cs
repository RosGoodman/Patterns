
namespace AbstractFctory.Entities.Movements;

internal class FlyMovement : MovementAbstract
{
    internal override void Move()
    {
        Console.WriteLine("Летит");
    }
}
