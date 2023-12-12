public class Difficulty
{
    public string difficultyName;

    private Random Generator = new Random();

    //----------------------

    public virtual int ModifyEnemyHealth(int oldHealthValue) //Kan jag ändra till vanling hälsa 'public int health' i Entity?
    {
        return oldHealthValue = 100;
    }

    public virtual int DamageModifier(int oldEnemyDamageAmount) //Kan jag ändra till vanling damage?
    {
        return oldEnemyDamageAmount = Generator.Next(4, 8);
    }
}
