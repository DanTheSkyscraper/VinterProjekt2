public class GameManager : Entity // Is this correct? See line 23, 24 and 34, 35.
{
    private PlayerEntity player = new();
    private EnemyEntity enemy = new();

    //-------------------------------------

    public GameManager()
    {
        player.SetName();
    }

    public void PrintStats()
    {
        if(player.GetAlive() == true)
        {
            Console.WriteLine($"\n\nPlayer '{player.name}' status: 'Alive'");
        }
        else
        {
            Console.WriteLine($"\n\nPlayer '{player.name}' status: 'Dead'");
        }
        Console.WriteLine($"\nPlayer '{player.name}' Health: {health}");
        Console.WriteLine($"Player '{player.name}' Weapon: {weapon.weaponName}");

        if(enemy.GetAlive() == true)
        {
            Console.WriteLine($"\n\nEnemy '{enemy.name}' status: 'Alive'");
        }
        else
        {
            Console.WriteLine($"\n\nEnemy '{enemy.name}' status: 'Dead'");
        }
        Console.WriteLine($"\nPlayer '{enemy.name}' Health: {health}");
        Console.WriteLine($"Player '{enemy.name}' Weapon: {weapon.weaponName}");
    }

    
}
