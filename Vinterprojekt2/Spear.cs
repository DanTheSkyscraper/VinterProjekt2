public class Spear : Weapon
{
    private Random Generator = new Random();

    //------------------------------

    public Spear()
    {
        weaponName = "Sword";
        weaponDamage = Generator.Next(2, 12);
    }

    public override int WeaponCriticalAttack()
    {
        Console.WriteLine("\n\nThe player chooses to do a charge attack!");
        return Generator.Next(2, 4) + Random.Shared.Next(weaponDamage);
    }
}
