
using Builder.Models;

namespace Builder;

internal abstract class RobotBuilderAbstract
{
    internal Robot Robot { get; private set; }
    internal RobotBuilderAbstract CreateRobot()
    {
        Robot = new Robot();
        return this;
    }

    internal abstract RobotBuilderAbstract SetHead();
    internal abstract RobotBuilderAbstract SetRightManipulator();
    internal abstract RobotBuilderAbstract SetLeftManipulator();
    internal abstract RobotBuilderAbstract SetChassis();
    internal abstract Robot GetResult();
}
