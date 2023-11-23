public class Axe : Weapon
{
    private Random Generator = new Random();

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



/*
Difficulty
  virtual int DamageModifier(int amount)

EasyDifficulty: Difficulty
  overridar DamageModifier

HardDifficulty: difficulty
  overridar DamageModifier




GameManager
  Difficulty diff 
  
  if (valt easy)
    diff = new EasyDifficulty()



  enemy.health -= diff.DamageModifier(player.weapon.GetDamage())
*/