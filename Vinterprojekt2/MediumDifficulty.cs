public class MediumDifficulty : Difficulty
{
    private Random Generator = new Random();

    //-------------------------------------

    public MediumDifficulty()
    {
        difficultyName = "Medium";
    }

    public override int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100;
    }

    public override int DamageModifier(int oldEnemyDamageAmount)
    {
        return oldEnemyDamageAmount = Generator.Next(4, 8);
    }
}
