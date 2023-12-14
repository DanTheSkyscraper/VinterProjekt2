﻿public class Axe : Weapon
{
    private Random Generator = new Random(); //This Random Generator makes it so that the parts of the code below that use it are randomized. For this part, Random Generator randomizes the damage and Critical Damage dealt with this specific weapon.

    //------------------------------

    public Axe()
    {
      weaponName = "Axe";
      weaponDamage = Generator.Next(3, 8);
    }

    public override int WeaponCriticalAttack()
    {
      Console.WriteLine("\n\nThe player chooses to do a charge attack!");
      return Generator.Next(6, 8) + Random.Shared.Next(weaponDamage);
    }
}