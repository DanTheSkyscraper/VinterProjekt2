public class Mace : Weapon //Mace is a type of Weapon (Inheritence). This makes it so that it, for example, has damage and a weaponName.
{
    private Random Generator = new Random(); //This Random Generator makes it so that the parts of the code below that use it are randomized. For this part, Random Generator randomizes the damage and Critical Damage dealt with this specific weapon.

    //------------------------------

    public Mace() //This code randomizes the amount of damage the sword does (4-16 damage), as well as naming the Sword 'Mace' in a weaponName variable.
    {
        weaponName = "Mace";
        weaponDamage = Generator.Next(4, 17);
    }

    //This polymorfism makes it so that 'WeaponCriticalAttack()' is overriden in the 'Weapon.cs' class.
    //Each weapon does a unique amount of damage. For example, this override runs the code on line 18 for this specific weapon.
    public override int WeaponCriticalAttack()
    {
        Console.WriteLine("\n\nThe player chooses to do a charge attack!");
        return Generator.Next(5, 26) + Random.Shared.Next(weaponDamage);
    }
}
