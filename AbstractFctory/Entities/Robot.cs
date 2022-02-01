
using AbstractFctory.Abstracts;

namespace AbstractFctory.Entities;

internal class Robot
{
    private MovementAbstract _movement;
    private ToolAbstract _tool;

    public Robot(RobotFactory factory)
    {
        _movement = factory.CreateMovement();
        _tool = factory.CreateTool();
    }

    public void Move() => _movement.Move();

    public void Position() => _tool.Position();
    public void UseTool() => _tool.Use();
}
