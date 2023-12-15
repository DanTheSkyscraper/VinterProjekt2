public class HardDifficulty : Difficulty
{
    private Random Generator = new Random();

    //-------------------------------------

    public HardDifficulty()
    {
        difficultyName = "Hard";
    }

    public override int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100 + 10;
    }

    public override int DamageModifier(int oldEnemyDamageAmount)
    {
        return oldEnemyDamageAmount = Generator.Next(4, 8) + 2;
    }
}
