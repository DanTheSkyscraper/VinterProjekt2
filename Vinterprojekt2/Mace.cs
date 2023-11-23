public class Mace : Weapon
{
    private Random Generator = new Random();

    //------------------------------

    public Mace()
    {
        weaponName = "Mace";
        weaponDamage = Generator.Next(1, 16);
    }

    public override int WeaponCriticalAttack()
    {
        Console.WriteLine("\n\nThe player chooses to do a charge attack!");
        return Generator.Next(5, 25) + Random.Shared.Next(weaponDamage);
    }
}
