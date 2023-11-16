public class Weapons
{
    public string weaponName;

    public int weaponDamage;


    public virtual int weaponAttack()
    {
        return Random.Shared.Next(weaponDamage);
    }
}
