//The start of the game is here.
string restartGame = "y";
while(restartGame == "y")
{
    Console.WriteLine("Welcome to the final match of the 32nd Tournament of the international fighting championships! Here, you will compete against the final competitor, whose experience level depends on what difficulty you yourself choose to play on. Good luck!");

    PlayerEntity player = new();
    EnemyEntity enemy = new();
    Weapon weapon = new();
    GameManager gm = new();

    Console.WriteLine("What is your name?");
    player.SetName();

    Console.WriteLine("A good name! Now, this is who you will be facing.");
    enemy.SetName();

    Console.WriteLine("\n\nAs per tradition, you will both select your weapons.");
    Console.WriteLine("\n\nYou have four choices. Sword [a] / Axe [b] / Spear [c] / Mace [d]. Please answer in lowercase.");

    
    

    
    Console.WriteLine("\n\nIt seems you are both done. Which difficulty are you on?");

    string difficultyChoice = PlayerDifficultyChoices.DifficultyChoice();

    if(difficultyChoice == "easy")
    {
        Console.WriteLine("\n\nEasy difficulty huh? Alright then. Let the final match begin!");

        gm.PrintStats();


    }
    else if(difficultyChoice == "medium")
    {
        Console.WriteLine("\n\nMedium difficulty huh? Alright then. Let the final match begin!");

        gm.PrintStats();
    }
    else
    {
        Console.WriteLine("\n\nHard difficulty huh? Alright then. Let the final match begin!");

        gm.PrintStats();
    }

    Console.WriteLine("\n\n----------------------------");
    Console.WriteLine("\n\nThe fight is now concluded! Let us see who is the victor...");

    



    Console.WriteLine("\n\nDo you want to play again?");
    restartGame = Console.ReadLine();
}
Console.ReadLine();