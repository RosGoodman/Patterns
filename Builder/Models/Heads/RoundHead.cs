
namespace Builder.Models.Heads;

internal class RoundHead : HeadModelAbstract
{
    internal override string Visor { get; set; }

    internal override void SpaceAnalysis()
    {
        Console.WriteLine("Анализирует пространство используя {0} визор.", Visor);
    }

    internal override void Turning()
    {
        Console.WriteLine("Вращает круглой гловой.");
    }
}
