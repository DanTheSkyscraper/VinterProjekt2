public class EnemyEntity : Entity
{
    private Random Generator = new Random();

    private bool IsAlive = true;

    //-------------------------------------------

    public Weapon RandomEnemyWeapon()
    {
        int eWeapon = Random.Shared.Next(5);
        Weapon enemyWeapon;

        if(eWeapon == 1)
        {
            enemyWeapon = new Sword();
        }
        else if(eWeapon == 2)
        {
            enemyWeapon = new Axe();
        }
        else if(eWeapon == 3)
        {
            enemyWeapon = new Spear();
        }
        else
        {
            enemyWeapon = new Mace();
        }

        return enemyWeapon;
    }

    public override void SetName()
    {
        Console.WriteLine("\n\nNow, this is who you will be facing:");
        int i = Random.Shared.Next(names.Count);

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
