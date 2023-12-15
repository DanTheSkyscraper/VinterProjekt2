public class PlayerFightChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static string FightChoice()
    {
        string FightAlt = "";
        while(FightAlt != "a" && FightAlt != "b")
        {
            FightAlt = Console.ReadLine();
            if(FightAlt != "a" && FightAlt != "b")
            {
                //This Console.WriteLine informs the player that they can only type 'a' or 'b'.
                Console.WriteLine("\n\nPlease type only 'a' or 'b'."); 
            }
        }
        return FightAlt;
    }
}
