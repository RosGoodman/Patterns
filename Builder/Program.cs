﻿using Builder.Models;

namespace Builder;

public class Program
{
    /*
    Строитель — это порождающий паттерн проектирования, который позволяет создавать 
    сложные объекты пошагово. Строитель даёт возможность использовать один и тот же 
    код строительства для получения разных представлений объектов.


    Когда использовать паттерн Строитель?

    1.  Когда процесс создания нового объекта не должен зависеть от того, из каких 
    частей этот объект состоит и как эти части связаны между собой

    2.  Когда необходимо обеспечить получение различных вариаций объекта в процессе его 
    создания
     */
    public static void Main(string[] args)
    {
        CreatorOfRobots creator = new CreatorOfRobots();
        RobotBuilder builder = new RobotBuilder();
        Robot robot = creator.Create(builder);

        robot.Chassis.Move();

        robot.LeftManipulator.Move();
        robot.LeftManipulator.MainAction();

        robot.RightManipulator.Move();
        robot.RightManipulator.MainAction();

        robot.Head.Turning();
        robot.Head.SpaceAnalysis();

        Console.ReadLine();
    }
}