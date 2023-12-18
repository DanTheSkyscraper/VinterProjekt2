public class Difficulty
{
    public string difficultyName;

    private Random Generator = new Random();

    //----------------------

    public virtual int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100;
    }

    public virtual int DamageModifier(int oldEnemyDamageAmount)
    {
        return oldEnemyDamageAmount = Generator.Next(4, 8);
    }
}
