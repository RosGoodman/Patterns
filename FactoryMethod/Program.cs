using FactoryMethod.Products;

namespace FactoryMethod;

public class Program
{
    /*Фабричный метод — это порождающий паттерн проектирования, который определяет
    общий интерфейс для создания объектов в суперклассе, позволяя подклассам
    изменять тип создаваемых объектов.

    Когда надо применять паттерн
    
    Когда заранее неизвестно, объекты каких типов необходимо создавать.

    Когда система должна быть независимой от процесса создания новых объектов и 
    расширяемой: в нее можно легко вводить новые классы, объекты которых система 
    должна создавать.

    Когда создание новых объектов необходимо делегировать из базового класса классам 
    наследникам*/
    public static void Main(string[] args)
    {
        AbstractDeveloper airplansDev = new AirplaneDeveloper("КБ Сухого");
        Airplane SU27 = (Airplane)airplansDev.TransportCreate();
        Airplane SU35 = (Airplane)airplansDev.TransportCreate();

        AbstractDeveloper truckDev = new TruckDeveloper("Mercedes-Benz");
        Truck Actros = (Truck)truckDev.TransportCreate();
        Truck Atego = (Truck)truckDev.TransportCreate();

        AbstractDeveloper shipDev = new ShipDeveloper("NorthSea");
        Ship Titanic = (Ship)shipDev.TransportCreate();
        Ship Britanic = (Ship)shipDev.TransportCreate();

        Console.ReadLine();
    }
}