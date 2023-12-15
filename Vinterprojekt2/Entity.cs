public class Entity //This is a public class, and it allows access through the objects that are created of this class.
{
    public string name; //This is a public string with 'name' as the variable. This is used for the names of the player and the enemy.

    public int health = 100; //This is a public integer with 'health' as the variable. This is used as the health for the player and the enemy. See more on enemy health in 'Difficulty.cs', 'EasyDifficulty.cs', 'MediumDifficulty.cs' and 'HardDifficulty.cs'.

    //This is a protected List. Protected works like Private does, but it can be used by classes that inherit it.
    //That means that this can be used by 'EnemyEntity.cs', where it is used in 'SetName()' to randomize a name for the enemy, as seen below.
    protected List<string> names = new List<string>() {"Karl", "Wayfarer", "Curier", "Mako", "Kusanagi"};

    public Weapon weapon;
    
    //-------------------------------------

    public Entity() //This is a constructor.
    {
        Weapon weapon = new();
    }
    

    //This is a public virtual void. Public means that this can be read and changed from the outside, such as from PlayerEntity.cs
    //Virtual means that this baseclass can be overwritten by the subclasses.
    public virtual void SetName()
    {

    }

    //This code is used for the fight between the player and the enemy.
    public void Attack(Entity target, Difficulty difficulty)
    {
        Console.WriteLine($"\n\n{name} attacks with {weapon.weaponName}");
        int weaponDamage = weapon.Attack();
        if(this is EnemyEntity) //This code makes it so that if it is the enemy (EnemyEntity) that is attacking, then it runs the code in the if statement.
        {
            weaponDamage = difficulty.DamageModifier(weaponDamage); //This code makes it so that the enemy deals different amounts of damage depending on what difficulty it is.
        }
        target.health -= weaponDamage; //This code subtracts the amount of damage either the player or the enemy receives with their health.
        target.health = Math.Max(0, target.health); //'Math.Max' is a Math class method used to return the larger of two specified numbers. In this code, that would be target.health, which means either the players or the enemies health.
        Console.WriteLine($"\n\n{name} dealt {weaponDamage} damage!");
    }

    //This code is used for the fight between the player and the enemy. This specific code is used when the player chooses to use the charge attack (WeaponCriticalAttack).
    public void WeaponCriticalAttack(Entity enemy)
    {
        Console.WriteLine($"\n\n{name} attacks with {weapon.weaponName}");
        int weaponDamage = weapon.WeaponCriticalAttack();
        enemy.health -= weaponDamage; //This code subtracts the amount of damage the enemy receives with their health.
        enemy.health = Math.Max(0, enemy.health); //'Math.Max' is a Math class method used to return the larger of two specified numbers. In this code, that would be target.health, which means either the players or the enemies health.
        Console.WriteLine($"\n\n{name} dealt {weaponDamage} damage!");
    }
}

//This code is missing enemy attack ^. How do I fix this?