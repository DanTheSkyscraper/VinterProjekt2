public class Sword : Weapons
{
    private Random Generator = new Random();

    //------------------------------

    public Sword()
    {
        weaponName = "Sword";
        weaponDamage = Generator.Next(5, 10);
    }

    public override int weaponAttack()
    {
        Console.WriteLine("\n\nThe player chooses to do a charge attack!");
        return Generator.Next(3, 6) + Random.Shared.Next(weaponDamage);
    }
}
