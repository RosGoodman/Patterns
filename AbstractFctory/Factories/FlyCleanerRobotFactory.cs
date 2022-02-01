
using AbstractFctory.Abstracts;
using AbstractFctory.Entities;
using AbstractFctory.Entities.Movements;
using AbstractFctory.Entities.Tools;

namespace AbstractFctory.Factories;

internal class FlyCleanerRobotFactory : RobotFactory
{
    internal override MovementAbstract CreateMovement()
    {
        return new FlyMovement();
    }

    internal override ToolAbstract CreateTool()
    {
        return new VacuumCleaner();
    }
}
