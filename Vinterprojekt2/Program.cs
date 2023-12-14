//The start of the game is here.
string restartGame = "y";
while (restartGame == "y")
{
    Console.WriteLine("Welcome to the final match of the 32nd Tournament of the international fighting championships! Here, you will compete against the final competitor, whose experience level depends on what difficulty you yourself choose to play on. Good luck!");

    PlayerEntity player = new();
    EnemyEntity enemy = new();
    GameManager gm = new();

    player.SetName();

    Console.WriteLine("A good name! Now, this is who you will be facing.");
    enemy.SetName();

    Console.WriteLine("\n\nAs per tradition, you will both select your weapons.");
    Console.WriteLine("\n\nYou have four choices. Sword [a] / Axe [b] / Spear [c] / Mace [d]. Please answer in lowercase.");

    //Player and enemy chooses weapons here. Add the code.
    player.weapon = PlayerWeaponChoice.WeaponChoice();
    //enemy.
    enemy.RandomEnemyWeapon();


    Console.WriteLine("\n\nIt seems you are both done. Which difficulty are you on?");

    Difficulty diff = PlayerDifficultyChoices.DifficultyChoice();

    /*
    Difficulty diff;
    if diffchoice == "easy"
       diff = new EasyDifficulty()
    else if (diffchoide == "medium")
        diff = new MediumDifficulty


    enemy.health = diff.ModifyEnemyHealth(enemy.Health)

    while (player health etc)
    {
        // Fighten som vanligt

        player.Attack(enemy, diff)
    }
    

    */


    enemy.health = diff.ModifyEnemyHealth(enemy.health);

    Console.WriteLine($"\n\n{diff.difficultyName} difficulty huh? Alright then. Let the final match begin!");
    while (player.health > 0 && enemy.health > 0)
    {
        Console.WriteLine("\n\n--------------------------");
        gm.PrintStats();

        Console.WriteLine("Time to attack!");
        Console.WriteLine("\n\nWhat type of attack do you choose?  ['a' = Normal Attack // 'b' = Charge Attack]");

        string FightAlt = PlayerFightChoice.FightChoice();

        if(FightAlt == "a") //If the player chooses alternativ 'a', this runs.
        {
            player.Attack(enemy, diff);
            enemy.Attack(player, diff);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();
        }
        else //If the player chooses alternativ 'b', this runs instead.
        {
            player.WeaponCriticalAttack(enemy);
            enemy.Attack(player, diff);

            player.HealthStatusCheck();
            enemy.HealthStatusCheck();
        }
    }
    // }
    // else if(difficultyChoice == "medium")
    // {
    //     diff = new MediumDifficulty();
    //     Console.WriteLine("\n\nMedium difficulty huh? Alright then. Let the final match begin!");
    //     while(player.health > 0 && enemy.health > 0)
    //     {
    //         Console.WriteLine("\n\n--------------------------");
    //         Console.WriteLine("Time to attack!");
    //         gm.PrintStats();


    //         player.Attack(enemy); //How to add manual attack for player.
    //         enemy.Attack(player, diff);

    //         player.HealthStatusCheck();
    //         enemy.HealthStatusCheck();

    //     }
    // }
    // else
    // {
    //     diff = new HardDifficulty();
    //     Console.WriteLine("\n\nHard difficulty huh? Alright then. Let the final match begin!");
    //     while(player.health > 0 && enemy.health > 0)
    //     {
    //         Console.WriteLine("\n\n--------------------------");
    //         Console.WriteLine("Time to attack!");
    //         gm.PrintStats();


    //         player.Attack(enemy); //How to add manual attack for player.
    //         enemy.Attack(player, diff);

    //         player.HealthStatusCheck();
    //         enemy.HealthStatusCheck();

    //     }
    // }
    Console.WriteLine("\n\n----------------------------");
    Console.WriteLine("\n\nThe fight is now concluded! Let us see who is the victor...");

    if (player.GetAlive() == true && enemy.GetAlive() == false)
    {
        Console.WriteLine($"\n\nYour opponent {enemy.name} has been defeated. You win the 32nd Tournament of the international fighting championships!");
    }
    else if (player.GetAlive() == false && enemy.GetAlive() == false)
    {
        Console.WriteLine($"\n\n{player.name} has been defeated. You win the 32nd Tournament of the international fighting championships!");
    }
    else
    {
        Console.WriteLine("\n\nBoth of you have been defeated. While there is no clear winner, it seems that it is a draw!");
    }

    Console.WriteLine("\n\nDo you want to play again?");
    restartGame = Console.ReadLine();
}
Console.ReadLine();