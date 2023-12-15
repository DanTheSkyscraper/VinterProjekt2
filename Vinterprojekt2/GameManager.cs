﻿public class GameManager 
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
        Console.WriteLine($"\nPlayer '{player.name}' Health: {player.health}");
        Console.WriteLine($"Player '{player.name}' Weapon: {player.weapon.weaponName}");

        if(enemy.GetAlive() == true)
        {
            Console.WriteLine($"\n\nEnemy '{enemy.name}' status: 'Alive'");
        }
        else
        {
            Console.WriteLine($"\n\nEnemy '{enemy.name}' status: 'Dead'");
        }
        Console.WriteLine($"\nPlayer '{enemy.name}' Health: {enemy.health}");
        Console.WriteLine($"Player '{enemy.name}' Weapon: {enemy.weapon.weaponName}");
    }

    
}
