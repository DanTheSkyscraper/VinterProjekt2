public class Sword : Weapon
{
    private Random Generator = new Random();

    //------------------------------

    public Sword()
    {
        weaponName = "Sword";
        weaponDamage = Generator.Next(5, 10);
    }

    public override int WeaponCriticalAttack()
    {
        Console.WriteLine("\n\nThe player chooses to do a charge attack!");
        return Generator.Next(1, 2) + Random.Shared.Next(weaponDamage);
    }
}
