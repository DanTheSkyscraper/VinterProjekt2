public class EnemyEntity : Entity //EnemyEntity är en sorts entity
{
    private Random Generator = new Random(); //This Random Generator makes it so that the parts of the code below that use it are randomized. For this part, Random Generator randomizes which weapon the enemy has.

    private bool isAlive = true; //This code is later used to determine whether or not the EnemyEntity is alive or not.

    //-------------------------------------------

    public void RandomEnemyWeapon()
    {
        int eWeapon = Random.Shared.Next(5);

        if(eWeapon == 1)
        {
            weapon = new Sword();
        }
        else if(eWeapon == 2)
        {
            weapon = new Axe();
        }
        else if(eWeapon == 3)
        {
            weapon = new Spear();
        }
        else
        {
            weapon = new Mace();
        }
    }

    public override void SetName()
    {
        Console.WriteLine("\n\nNow, this is who you will be facing:");
        int i = Random.Shared.Next(names.Count);

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
