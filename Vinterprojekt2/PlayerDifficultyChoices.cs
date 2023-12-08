public class PlayerDifficultyChoices
{

    //------------------------------------------------------

    public static string DifficultyChoice()
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
