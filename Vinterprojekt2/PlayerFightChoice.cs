public class PlayerFightChoice
{
    public static string FightChoice()
    {
        string FightAlt = "";
        while(FightAlt != "a" && FightAlt != "b")
        {
            FightAlt = Console.ReadLine();
            if(FightAlt != "a" && FightAlt != "b")
            {
                Console.WriteLine("\n\nPlease type only 'a' or 'b'.");
            }
        }
        return FightAlt;
    }
}
