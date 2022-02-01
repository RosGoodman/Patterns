
namespace Builder.Models;

internal class Robot
{
    internal ManipulatorAbstract LeftManipulator { get; set; }
    internal ManipulatorAbstract RightManipulator { get; set; }
    internal HeadModelAbstract Head { get; set; }
    internal ChassisModelAbstract Chassis { get; set; } 
}
