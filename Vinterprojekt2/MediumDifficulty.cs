public class MediumDifficulty : Difficulty //MediumDifficulty is a type of Difficulty (Inheritence). This makes it so that it, for example, has a difficultyName, modified health value and a modified damage value for the enemy.
{
    private Random Generator = new Random(); //This Random Generator makes it so that the parts of the code below that use it are randomized. For this part, Random Generator randomizes the damage.

    //-------------------------------------

    public MediumDifficulty() //This is a constructor. This one sets the value for the variable 'difficultyName' to the string 'Medium'.
    {
        difficultyName = "Medium";
    }

    //This code, the method 'ModifyEnemyHealth', has the integer paramater 'oldHealthValue', and the value 100 is assigned to it. This is then returned.
    //This polymorfism makes it so that 'ModifyEnemyHealth(int oldHealthValue)' is overriden in the 'Difficulty.cs' class.
    public override int ModifyEnemyHealth(int oldHealthValue)
    {
        return oldHealthValue = 100;
    }

    //This code, the method 'DamageModifier', has the integer paramater 'oldEnemyDamageAmount', and a Generator randomizing a value between 4-8 is assigned to it. This is then returned.
    //This polymorfism makes it so that 'DamageModifier(int oldEnemyDamageAmount)' is overriden in the 'Difficulty.cs' class.
    public override int DamageModifier(int oldEnemyDamageAmount)
    {
        return oldEnemyDamageAmount = Generator.Next(4, 9);
    }
}
