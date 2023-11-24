public class EnemyEntity : Entity
{
    private Random Generator = new Random();

    public override void SetName()
    {
        Console.WriteLine("\n\nthe name of your enemy is:");
        int i = Random.Shared.Next(names.Count);

        name = Console.ReadLine();
    }
}
