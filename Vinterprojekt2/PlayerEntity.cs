public class PlayerEntity : Entity
{
    private Random Generator = new Random(); //Ta bort om behövs. Gäller alla andra generators också.

    private bool IsAlive = true;

    //--------------------------------------------

    public override void SetName()
    {
        Console.WriteLine("\n\nWrite the name of your character:");
        name = Console.ReadLine();
    }

    public bool GetAlive()
    {
        return IsAlive;
    }

    public void HealthStatusCheck()
    {
        if(health <= 0)
        {
            IsAlive = false;
        }
    }

    
}
