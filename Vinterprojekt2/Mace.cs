public class Mace : Weapon
{
    private Random Generator = new Random(); //This Random Generator makes it so that the parts of the code below that use it are randomized. For this part, Random Generator randomizes the damage and Critical Damage dealt with this specific weapon.

    //------------------------------

    public Mace()
    {
        weaponName = "Mace";
        weaponDamage = Generator.Next(4, 17);
    }

    public override int WeaponCriticalAttack()
    {
        Console.WriteLine("\n\nThe player chooses to do a charge attack!");
        return Generator.Next(5, 26) + Random.Shared.Next(weaponDamage);
    }
}
