public class PlayerWeaponChoice
{
    public static string WeaponChoice()
    {
        string weaponChoice = "";

        while(weaponChoice != "sword" && weaponChoice != "axe" && weaponChoice != "spear" && weaponChoice != "mace")
        {
            weaponChoice = Console.ReadLine();

            if(weaponChoice != "sword" && weaponChoice != "axe" && weaponChoice != "spear" && weaponChoice != "mace")
            {
                Console.WriteLine("\n\nPlease write only 'sword', 'axe', 'spear' or 'mace'. Your choice should only be written in lowercase");
            }
        }


        return weaponChoice;
    }
}
