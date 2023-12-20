public class PlayerFightChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static string FightChoice()
    {
        string fightAlternative = "";
        while(fightAlternative != "a" && fightAlternative != "b")
        {
            fightAlternative = Console.ReadLine();
            if(fightAlternative != "a" && fightAlternative != "b")
            {
                //This Console.WriteLine informs the player that they can only type 'a' or 'b'.
                Console.WriteLine("\n\nPlease type only 'a' or 'b'."); 
            }
        }
        return fightAlternative;
    }
}
