
using AbstractFctory.Entities;

namespace AbstractFctory.Abstracts;

internal abstract class RobotFactory
{
    internal abstract MovementAbstract CreateMovement();
    internal abstract ToolAbstract CreateTool();
}
