public class Weapon //This is a public class, and it allows access through the objects that are created of this class.
{
    public string weaponName; //This is a public string with 'weaponName' as the variable. This is used for the name of the weapon.

    public int weaponDamage; //This is a public string with 'weaponDamage' as the variable. This is used for the damage of the weapons.

    //-----------------------------------

    //This code is a method named 'Attack', and it is used to generate a random int value for the variable 'weaponDamage'. This is returned.
    public int Attack()
    {
        return Random.Shared.Next(weaponDamage);
    }
    
    //This is a public virtual int. Public means that this can be read and changed from the outside, such as from all the weapon classes.
    //Virtual means that this baseclass can be overwritten by the subclasses.
    public virtual int WeaponCriticalAttack()
    {
        return Random.Shared.Next(weaponDamage);
    }

}