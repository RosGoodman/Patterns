using AbstractFctory.Entities;
using AbstractFctory.Factories;

namespace AbstractFactory;

public class Program
{
    /*
        Абстрактная фабрика — это порождающий паттерн проектирования, который позволяет 
    создавать семейства связанных объектов, не привязываясь к конкретным классам 
    создаваемых объектов.
    
     Когда использовать абстрактную фабрику
    Когда система не должна зависеть от способа создания и компоновки новых объектов

    Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанными
    */

    public static void Main(string[] args)
    {
        Robot crawScrewdriverRobot = new Robot(new CrawScrewdriverRobotFactory());
        Robot flyCleanerRobot = new Robot(new FlyCleanerRobotFactory());
        Robot rideHummerRobot = new Robot(new RideHummerRobotFactory());

        Console.WriteLine("Ползающий робот с отверткой.");
        crawScrewdriverRobot.Move();
        crawScrewdriverRobot.Position();
        crawScrewdriverRobot.UseTool();

        Console.WriteLine("Летающий робот с пылесосом.");
        flyCleanerRobot.Move();
        flyCleanerRobot.Position();
        flyCleanerRobot.UseTool();

        Console.WriteLine("Робот на колесах с молотом.");
        rideHummerRobot.Move();
        rideHummerRobot.Position();
        rideHummerRobot.UseTool();

        Console.ReadLine();
    }
}