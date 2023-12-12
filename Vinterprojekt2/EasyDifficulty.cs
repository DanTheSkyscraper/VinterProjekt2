public class EasyDifficulty : Difficulty
{
    private Random Generator = new Random();

    public EasyDifficulty()
    {
        difficultyName = "Easy";
    }

    public override int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100 - 10;
    }

    public override int DamageModifier(int oldEnemyDamageAmount)
    {
        return oldEnemyDamageAmount = Generator.Next(4, 8) - 2;
    }
}
