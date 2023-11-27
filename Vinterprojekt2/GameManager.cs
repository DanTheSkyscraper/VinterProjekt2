public class GameManager
{
    private PlayerEntity player = new();
    private EnemyEntity enemy = new();

    public GameManager()
    {
        player.SetName();
    }

    public void PrintStats()
    {
        if(player.GetAlive() == true)
        {
            Console.WriteLine($"\nPlayer '{player.name}' status: 'Alive'");
        }
        else
        {
            Console.WriteLine($"\nPlayer '{player.name}' status: 'Dead'");
        }

        if(enemy.GetAlive() == true)
        {
            Console.WriteLine($"\nEnemy '{enemy.name}' status: 'Alive'");
        }
        else
        {
            Console.WriteLine($"\nEnemy '{enemy.name}' status: 'Dead'");
        }
    }
}
