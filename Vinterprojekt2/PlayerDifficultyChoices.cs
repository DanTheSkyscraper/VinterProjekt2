public class PlayerDifficultyChoices //This is a public class, and it allows access through the objects that are created of this class.
{
    public static Difficulty DifficultyChoice()
    {
        string difficultyChoice = "";
        
        while(difficultyChoice != "easy" && difficultyChoice != "medium" && difficultyChoice != "hard")
        {
            difficultyChoice = Console.ReadLine();

            if(difficultyChoice != "easy" && difficultyChoice != "medium" && difficultyChoice != "hard")
            {
                //This Console.WriteLine informs the player that they can only write 'easy', 'medium' and 'hard', and that their answer should be in lowercase.
                Console.WriteLine("\n\nPlease write only 'easy', 'medium' or 'hard'. Your choice should only be written in lowercase"); 
            }
        } //The while-loop will restart if the player does not write the following: 'easy', 'medium' or 'hard'.

        return new Difficulty(); 
    }
}
