public class MediumDifficulty : Difficulty
{
    private Random Generator = new Random();

    public override int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100;
    }

    public override int DamageModifier(int oldEnemyDamageAmount) //Change to specific weapontype damage
    {
        return oldEnemyDamageAmount = Generator.Next(4, 8);
    }
}
