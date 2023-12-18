//The start of the game is here.
string restartGame = "y";
while (restartGame == "y") //This is a while loop. This one will make it so that the player can restart the game by pressing 'y'.
{
    Console.WriteLine("Welcome to the final match of the 32nd Tournament of the international fighting championships! Here, you will compete against the final competitor, whose experience level depends on what difficulty you yourself choose to play on. Good luck!");

    //The following three lines of code (line 10, 11, 12) create instances of their respective classes with assigned variables.
    //This makes it so that variables are created for the player, enemy and GameManager, which is later used for the rest of the code.

    PlayerEntity player = new(); //This instance of the class 'PlayerEntity' is assigned the 'player' variable.
    EnemyEntity enemy = new(); //This instance of the class 'EnemyEntity' is assigned the 'enemy' variable.
    GameManager gm = new(); //This instance of the class 'GameManager' is assigned the 'gm' variable.

    gm.player = player; //This ensures that 'player' in Program.cs and 'player' in GameManager.cs are the same variable.
    gm.enemy = enemy; //This ensures that 'enemy' in Program.cs and 'enemy' in GameManager.cs are the same variable.

    player.SetName(); //This is a method call for the 'SetName()' method on 'player'. See 'PlayerEntity.cs'.

    Console.WriteLine("A good name! Now, this is who you will be facing.");
    enemy.SetName(); //This is a method call for the 'SetName()' method on 'enemy'. See 'EnemyEntity.cs' and line 7 in 'Entity.cs'.

    Console.WriteLine(enemy.name);

    Console.WriteLine("\n\nAs per tradition, you will both select your weapons.");
    Console.WriteLine("\n\nYou have four choices. Sword [a] / Axe [b] / Spear [c] / Mace [d]. Please answer in lowercase."); //Here, the player is asked to choose one of four choices and to only answer in lower case.

    //This code makes it so that the player can choose a weapon, and it also ensures they can not type anything else but the 4 options shown above.
    //The code on line 25 makes it so that the enemy is given a randomly chosen weapon with the help of Random Generator and the code on line 9-29.
    player.weapon = PlayerWeaponChoice.WeaponChoice();
    enemy.RandomEnemyWeapon();

    //In this Console.WriteLine, the player is asked what difficulty they want to play on.
    Console.WriteLine("\n\nIt seems you are both done. Which difficulty are you on?");

    //This code makes it so that the variable 'diff' is created, and is assigned whatever the result is in the static method 'DifficultyChoice' from 'PlayerDifficultyChoices.cs'.
    //In other words, if the player types easy, the game will be on easy difficulty (EasyDifficulty.cs).
    Difficulty diff = PlayerDifficultyChoices.DifficultyChoice();

    //This code ensures that depending on which difficulty the player chooses, the enemy health will be changed to the health they have on that difficulty.
    enemy.health = diff.ModifyEnemyHealth(enemy.health); 

    Console.WriteLine($"\n\n{diff.difficultyName} difficulty huh? Alright then. Let the final match begin!");
    while (player.health > 0 && enemy.health > 0) //This while loop will run as long as neither the player or the enemy has reached 0 health. If either of them reach 0 health, the game is over.
    {
        Console.WriteLine("\n\n--------------------------");
        gm.PrintStats(); //gm.PrintStats(); makes it so that the status of the player and the enemy (Alive/Dead), their health and their weapons are displayed each round.

        Console.WriteLine("Time to attack!");
        Console.WriteLine("\n\nWhat type of attack do you choose?  ['a' = Normal Attack // 'b' = Charge Attack]"); //This Console.WriteLine makes it so that the player knows that they can choose which type of attack they want to do, either a normal attack 'a', or a charge attack 'b'.

        //This code is a method that allows the player to choose which type of attack they want to make.
        string FightAlt = PlayerFightChoice.FightChoice();

        if(FightAlt == "a") //If the player chooses alternativ 'a', this runs.
        {
            player.Attack(enemy, diff); //This code makes it so that the player attacks the enemy with a normal attack.
            enemy.Attack(player, diff); //This code makes it so that the enemy attacks the player with a normal attack.

            player.HealthStatusCheck(); //See line 19-25 in 'PlayerEntity.cs'.
            enemy.HealthStatusCheck(); //See line 44-51 in 'EnemyEntity.cs'.
        }
        else //If the player chooses alternativ 'b', this runs instead.
        {
            player.WeaponCriticalAttack(enemy); //This code makes it so that the player attacks the enemy with a charged attack.
            enemy.Attack(player, diff); //This code makes it so that the enemy attacks the player with a normal attack.

            player.HealthStatusCheck(); //See line 19-25 in 'PlayerEntity.cs'.
            enemy.HealthStatusCheck(); //See line 44-51 in 'EnemyEntity.cs'.
        }
    }
    
    Console.WriteLine("\n\n----------------------------"); //When the health of either the player or the enemy, or both of them, reaches 0, the code below starts.
    Console.WriteLine("\n\nThe fight is now concluded! Let us see who is the victor...");

    if (player.GetAlive() == true && enemy.GetAlive() == false) //This if statement makes it so that if the enemy reaches 0 health, the player wins.
    {
        Console.WriteLine($"\n\nYour opponent {enemy.name} has been defeated. You win the 32nd Tournament of the international fighting championships!");
    }
    else if (player.GetAlive() == false && enemy.GetAlive() == true) //This if statement makes it spo that if the player reaches 0 health, the enemy wins.
    {
        Console.WriteLine($"\n\n{player.name} has been defeated. {enemy.name} wins the 32nd Tournament of the international fighting championships!");
    }
    else //This code makes it so that if both the player and the enemy reach 0 health, it is a draw.
    {
        Console.WriteLine("\n\nBoth of you have been defeated. While there is no clear winner, it seems that it is a draw!");
    }

    //This is the end of the While loop. The player is asked if the want to play again.
    //If the player types 'y', the game restarts. If that isn't the case, the game stops.
    Console.WriteLine("\n\nDo you want to play again?");
    restartGame = Console.ReadLine();
}
Console.ReadLine();