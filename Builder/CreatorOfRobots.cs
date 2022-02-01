
namespace Builder.Models
{
    /// <summary> Директор шабола Builder. </summary>
    internal class CreatorOfRobots
    {
        internal Robot Create(RobotBuilderAbstract builder)
        {
            builder.CreateRobot()
                .SetHead()
                .SetLeftManipulator()
                .SetRightManipulator()
                .SetChassis();

            return builder.GetResult();
        }
    }
}
