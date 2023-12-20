public class EnemyEntity : Entity //EnemyEntity is a type of Entity (Inheritence). This makes it so that it, for example, has health and a name.
{
    private Random Generator = new Random(); //This Random Generator makes it so that the parts of the code below that use it are randomized. For this part, Random Generator randomizes which weapon the enemy has.

    private bool isAlive = true; //This code is later used to determine whether or not the EnemyEntity is alive or not.

    //-------------------------------------------

    public void RandomEnemyWeapon() //This code randomizes what weapon the enemy will use, by randomly selecting a number between 1-4.
    {
        int eWeapon = Random.Shared.Next(5);

        if(eWeapon == 1) //If 'int eWeapon' is 1, the enemy gets the Sword.
        {
            weapon = new Sword();
        }
        else if(eWeapon == 2) //If 'int eWeapon' is 2, the enemy gets the Axe.
        {
            weapon = new Axe();
        }
        else if(eWeapon == 3) //If 'int eWeapon' is 3, the enemy gets the Spear.
        {
            weapon = new Spear();
        }
        else //If 'int eWeapon' is 4, the enemy gets the Mace.
        {
            weapon = new Mace(); 
        }
    }

    public override void SetName()
    {
        //In this code, the name of the enemy is randomized by making use of the protected List in 'Entity.cs'.
        int i = Random.Shared.Next(names.Count);
        name = names[i];
    }

    //This public bool returns the value of the 'isAlive' variable for the enemy.
    public bool GetAlive()
    {
        return isAlive;
    }

    //What this code does is check whether or not the health of the enemy has reached less than or equal to 0. If that is the case, 'isAlive' for the enemy will be false.
    public void HealthStatusCheck()
    {
        if(health <= 0)
        {
            isAlive = false;
        }
    }
}
