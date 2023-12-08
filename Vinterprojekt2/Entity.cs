public class Entity
{
    public string name;

    public int health = 100;

    protected List<string> names = new List<string>() {"Karl", "Wayfarer", "Curier", "Mako", "Kusanagi"};

    public Axe axe;

    public Sword sword;

    public Spear spear;

    public Mace mace;

    public Weapon weapon;
    
    //-------------------------------------

    public Entity()
    {
        Weapon weapon = new(); //Unused?
    }

    public virtual void SetName()
    {

    }

    public void Attack(Entity target)
    {
        Console.WriteLine($"\n\n{name} attacks with {weapon.weaponName}");
        int weaponDamage = weapon.Attack();
        target.health -= weaponDamage;
        target.health = Math.Max(0, target.health);
        Console.WriteLine($"\n\n{name} dealth {weaponDamage} damage!");
    } 
}


