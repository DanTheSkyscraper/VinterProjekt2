public class PlayerEntity : Entity
{
    private Random Generator = new Random(); //Ta bort om behövs. Gäller alla andra generators också.

    private bool isAlive = true;

    //--------------------------------------------

    public override void SetName()
    {
        Console.WriteLine("\n\nWrite the name of your character:");
        name = Console.ReadLine();
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void HealthStatusCheck()
    {
        if(health <= 0)
        {
            isAlive = false;
        }
    }

    
}
