public class GameManager //This is a public class, and it allows access through the objects that are created of this class.
{
    public PlayerEntity player;
    public EnemyEntity enemy;

    //-------------------------------------

    //This is a method called 'PrintStats()', and it makes it so that various stats about the player and the enemy is displayed.
    public void PrintStats()
    {
        if(player.GetAlive() == true) //This code makes it so that if the player is still alive, the Console.WriteLine will say 'Alive'.
        {
            Console.WriteLine($"\n\nPlayer '{player.name}' status: 'Alive'");
        }
        else //This code makes it so that if the player is dead, the Console.WriteLine will say 'Dead'.
        {
            Console.WriteLine($"\n\nPlayer '{player.name}' status: 'Dead'");
        }
        //These Console.WriteLines will show the amount of health and the weapon the player has.
        Console.WriteLine($"\nPlayer '{player.name}' Health: {player.health}");
        Console.WriteLine($"Player '{player.name}' Weapon: {player.weapon.weaponName}");

        if(enemy.GetAlive() == true) //This code makes it so that if the enemy is still alive, the Console.WriteLine will say 'Alive'.
        {
            Console.WriteLine($"\n\nEnemy '{enemy.name}' status: 'Alive'");
        }
        else //This code makes it so that if the enemy is dead, the Console.WriteLine will say 'Dead'.
        {
            Console.WriteLine($"\n\nEnemy '{enemy.name}' status: 'Dead'");
        }
        //These Console.WriteLines will show the amount of health and the weapon the enemy has.
        Console.WriteLine($"\nPlayer '{enemy.name}' Health: {enemy.health}");
        Console.WriteLine($"Player '{enemy.name}' Weapon: {enemy.weapon.weaponName}");
    }

    
}
