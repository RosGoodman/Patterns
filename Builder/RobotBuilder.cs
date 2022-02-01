
using Builder.Models;
using Builder.Models.Chassis;
using Builder.Models.Heads;
using Builder.Models.Manipulators;

namespace Builder;

internal class RobotBuilder : RobotBuilderAbstract
{
    internal override RobotBuilderAbstract SetChassis()
    {
        Robot.Chassis = new WheelsChassis();
        return this;
    }

    internal override RobotBuilderAbstract SetHead()
    {
        Robot.Head = new RoundHead() { Visor = "Ультрафиолетовый" };
        return this;
    }

    internal override RobotBuilderAbstract SetLeftManipulator()
    {
        Robot.LeftManipulator = new SimpleHand();
        return this;
    }

    internal override RobotBuilderAbstract SetRightManipulator()
    {
        Robot.RightManipulator = new HandWithLaser();
        return this;
    }

    internal override Robot GetResult() => Robot;
}
