public class PlayerChoices
{
    private Random Generator = new Random();

    //------------------------------------------------------

    public static string DifficultyChoice() //FIND OUT HOW TO APPLY TO ARV | CURRENT CONTEXT
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
    }
}
