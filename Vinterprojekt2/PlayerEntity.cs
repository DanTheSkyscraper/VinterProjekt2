public class PlayerEntity : Entity
{
    private Random Generator = new Random();

    public override void SetName()
    {
        Console.WriteLine("\n\nWrite the name of your character:");
        name = Console.ReadLine();
    }

    
}
