public class Weapon
{
    public string weaponName;

    public int weaponDamage;

    public virtual int Attack()
    {
        return Random.Shared.Next(weaponDamage);
    }

    public virtual int WeaponCriticalAttack()
    {
        return Random.Shared.Next(weaponDamage);
    }


}
