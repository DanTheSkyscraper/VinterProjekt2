public class Difficulty //This is a public class, and it allows access through the objects that are created of this class.
{
    public string difficultyName; //This is a public string with 'difficultyName' as the variable. This is used for the names of the three difficulties.

    //This Random Generator makes it so that the parts of the code below that use it are randomized. For this part, Random Generator randomizes the damage 
    private Random Generator = new Random();

    //----------------------

    //This code, the method 'ModifyEnemyHealth', has the integer paramater 'oldHealthValue', and the value 100 is assigned to it. This is then returned.
    //This is a virtual integer, which means that this can later be overriden in other classes.
    public virtual int ModifyEnemyHealth(int oldHealthValue) //Parameter. See line 29 in Entity.cs for explanation about parameters.
    {
        return oldHealthValue = 100;
    }

    //This code, the method 'ModifyDamage', has the integer paramater 'oldEnemyDamageAmount', and a Generator randomizing a value between 4-8 is assigned to it. This is then returned.
    //This is a virtual integer, which means that this can later be overriden in other classes.
    public virtual int ModifyDamage(int oldEnemyDamageAmount) //Parameter. See line 29 in Entity.cs for explanation about parameters.
    {
        return oldEnemyDamageAmount = Generator.Next(4, 9);
    }
}
