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

        if(weaponChoice == "sword")
        {
            Console.WriteLine("\n\nYou chose the Sword");
            //weaponChoice = 
        }
        else if(weaponChoice == "axe")
        {
            Console.WriteLine("\n\nYou chose the Axe");
            //weaponChoice =
        }
        else if(weaponChoice == "spear")
        {
            Console.WriteLine("\n\nYou chose the Spear");
            //weaponChoice =
        }
        else
        {
            Console.WriteLine("\n\nYou chose the Mace");
            //weaponChoice =
        }


        return weaponChoice;
    }
}
