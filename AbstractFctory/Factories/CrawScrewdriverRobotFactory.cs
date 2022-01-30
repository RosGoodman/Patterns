
using AbstractFctory.Abstracts;
using AbstractFctory.Entities;
using AbstractFctory.Entities.Movements;
using AbstractFctory.Entities.Tools;

namespace AbstractFctory.Factories;

internal class CrawScrewdriverRobotFactory : RobotFactory
{
    internal override MovementAbstract CreateMovement()
    {
        return new CrawlMovement();
    }

    internal override ToolAbstract CreateTool()
    {
        return new Screwdriver();
    }
}
