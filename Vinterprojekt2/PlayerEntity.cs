public class PlayerEntity : Entity //PlayerEntity is a type of Entity (Inheritence). This makes it so that it, for example, has health and a name.
{

    private bool isAlive = true; //This code is later used to determine whether or not the PlayerEntity is alive or not.

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

    //What this code does is check whether or not the health of the player has reached less than or equal to 0. If that is the case, 'isAlive' for the player will be false.
    public void HealthStatusCheck()
    {
        if(health <= 0)
        {
            isAlive = false;
        }
    }

    
}
