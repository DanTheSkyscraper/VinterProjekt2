﻿public class PlayerWeaponChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static Weapon WeaponChoice()
    {
        string weaponChoice = "";

        while(weaponChoice != "sword" && weaponChoice != "axe" && weaponChoice != "spear" && weaponChoice != "mace")
        {
            weaponChoice = Console.ReadLine();

            if(weaponChoice != "sword" && weaponChoice != "axe" && weaponChoice != "spear" && weaponChoice != "mace")
            {
                //This Console.WriteLine informs the player that they can only write 'sword', 'axe', 'spear' and 'mace', and that their answer should be in lowercase.
                Console.WriteLine("\n\nPlease write only 'sword', 'axe', 'spear' or 'mace'. Your choice should only be written in lowercase");
            }
        }

        if(weaponChoice == "sword")
        {
            Console.WriteLine("\n\nYou chose the Sword");
            return new Sword();
        }
        else if(weaponChoice == "axe")
        {
            Console.WriteLine("\n\nYou chose the Axe");
            return new Axe();
        }
        else if(weaponChoice == "spear")
        {
            Console.WriteLine("\n\nYou chose the Spear");
            return new Spear();
        }
        else
        {
            Console.WriteLine("\n\nYou chose the Mace");
            return new Mace();
        }
        return new Weapon();
        // return weaponChoice; //This will restart the while-loop if the player does not write the following: 'sword', 'axe', 'spear' or 'mace'.
    }

    
}
