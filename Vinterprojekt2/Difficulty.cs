public class Difficulty
{
    public virtual int ModifyEnemyHealth(int oldValue)
    {
        return oldValue -= 10;
    }
}
