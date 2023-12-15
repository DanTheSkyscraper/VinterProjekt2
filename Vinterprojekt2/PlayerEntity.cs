public class PlayerEntity : Entity
{

    private bool isAlive = true;

    //--------------------------------------------

    public override void SetName()
    {
        Console.WriteLine("\n\nWrite the name of your character:"); //This code allows the player to write their name.
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
