
using AbstractFctory.Abstracts;
using AbstractFctory.Entities;
using AbstractFctory.Entities.Movements;
using AbstractFctory.Entities.Tools;

namespace AbstractFctory.Factories;

internal class RideHummerRobotFactory : RobotFactory
{
    internal override MovementAbstract CreateMovement()
    {
        return new RideMovement();
    }

    internal override ToolAbstract CreateTool()
    {
        return new Hummer();
    }
}
