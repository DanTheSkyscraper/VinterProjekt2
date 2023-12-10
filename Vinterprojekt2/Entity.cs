public class Entity
{
    public string name;

    public int health = 100;

    protected List<string> names = new List<string>() {"Karl", "Wayfarer", "Curier", "Mako", "Kusanagi"};

    public Weapon weapon;
    
    //-------------------------------------

    public Entity()
    {
        Weapon weapon = new();
    }
    

    //This is a public virtual void. Public means that this can be read and changed from the outside, such as from PlayerEntity.cs
    //Virtual means that this baseclass can be overwritten by the subclasses.
    public virtual void SetName()
    {

    }

    public void Attack(Entity target, Difficulty difficulty)
    {
        Console.WriteLine($"\n\n{name} attacks with {weapon.weaponName}");
        int weaponDamage = weapon.Attack();
        if(this is EnemyEntity)
        {
            weaponDamage = difficulty.DamageModifier(weaponDamage);
        }
        target.health -= weaponDamage;
        target.health = Math.Max(0, target.health); //'Math.Max' is a Math class method used to return the larger of two specified numbers. In this code, that would be target.health, which means either the players or the enemies health.
        Console.WriteLine($"\n\n{name} dealth {weaponDamage} damage!");
    } 
}

//Line 33: Ska det läggas till på line 34 if(ModifyEnemyHealth)?

