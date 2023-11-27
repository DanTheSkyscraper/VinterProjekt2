public class PlayerDifficultyChoices
{
    private Random Generator = new Random();

    //------------------------------------------------------

    public static string DifficultyChoice() //FIND OUT HOW TO APPLY THIS TO ARV FOR WEAPON AND HP (Increase)
    {
        string difficultyChoice = "";
        
        while(difficultyChoice != "easy" && difficultyChoice != "medium" && difficultyChoice != "hard")
        {
            difficultyChoice = Console.ReadLine();

            if(difficultyChoice != "easy" && difficultyChoice != "medium" && difficultyChoice != "hard")
            {
                Console.WriteLine("\n\nPlease write only 'easy', 'medium' or 'hard'. Your choice should only be written in lowercase");
            }
        }

        return difficultyChoice;
    }
}
