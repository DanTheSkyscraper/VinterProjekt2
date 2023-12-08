//The start of the game is here.
string restartGame = "y";
while(restartGame == "y")
{
    Console.WriteLine("Welcome to the final match of the 32nd Tournament of the international fighting championships! Here, you will compete against the final competitor, whose experience level depends on what difficulty you yourself choose to play on. Good luck!");

    PlayerEntity player = new();
    EnemyEntity enemy = new();
    GameManager gm = new();

    Console.WriteLine("What is your name?");
    player.SetName();

    Console.WriteLine("A good name! Now, this is who you will be facing.");
    enemy.SetName();

    Console.WriteLine("\n\nAs per tradition, you will both select your weapons.");
    Console.WriteLine("\n\nYou have four choices. Sword [a] / Axe [b] / Spear [c] / Mace [d]. Please answer in lowercase.");

    string weaponChoice = PlayerWeaponChoice.WeaponChoice(); //How should I use the weaponChoice? It is unused.
    //Player and enemy chooses weapons here. Add the code.

    
    Console.WriteLine("\n\nIt seems you are both done. Which difficulty are you on?");

    string difficultyChoice = PlayerDifficultyChoices.DifficultyChoice();

    if(difficultyChoice == "easy")
    {
        Console.WriteLine("\n\nEasy difficulty huh? Alright then. Let the final match begin!");
        while(player.health > 0 && enemy.health > 0)
        {
            Console.WriteLine("\n\n--------------------------");
            Console.WriteLine("They are attacking each other again!");
            gm.PrintStats();


            player.Attack(enemy);
            enemy.Attack(player);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();

        }
    }
    else if(difficultyChoice == "medium")
    {
        Console.WriteLine("\n\nMedium difficulty huh? Alright then. Let the final match begin!");
        while(player.health > 0 && enemy.health > 0)
        {
            Console.WriteLine("\n\n--------------------------");
            Console.WriteLine("They are attacking each other again!");
            gm.PrintStats();


            player.Attack(enemy);
            enemy.Attack(player);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();

        }
    }
    else
    {
        Console.WriteLine("\n\nHard difficulty huh? Alright then. Let the final match begin!");
        while(player.health > 0 && enemy.health > 0)
        {
            Console.WriteLine("\n\n--------------------------");
            Console.WriteLine("They are attacking each other again!");
            gm.PrintStats();


            player.Attack(enemy);
            enemy.Attack(player);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();

        }
    }
    Console.WriteLine("\n\n----------------------------");
    Console.WriteLine("\n\nThe fight is now concluded! Let us see who is the victor...");

    if(player.GetAlive() == true && enemy.GetAlive() == false)
    {

    }



    Console.WriteLine("\n\nDo you want to play again?");
    restartGame = Console.ReadLine();
}
Console.ReadLine();