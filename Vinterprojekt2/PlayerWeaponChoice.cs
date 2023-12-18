public class PlayerWeaponChoice //This is a public class, and it allows access through the objects that are created of this class.
{
    public static Weapon WeaponChoice()
    {
        string weaponChoice = "";

        while(weaponChoice != "a" && weaponChoice != "b" && weaponChoice != "c" && weaponChoice != "d")
        {
            weaponChoice = Console.ReadLine();

            if(weaponChoice != "a" && weaponChoice != "b" && weaponChoice != "c" && weaponChoice != "d")
            {
                //This Console.WriteLine informs the player that they can only write 'sword', 'axe', 'spear' and 'mace', and that their answer should be in lowercase.
                Console.WriteLine("\n\nPlease type only 'a', 'b', 'c' or 'd'. Your choice should only be written in lowercase");
            }
        } //The while-loop will restart if the player does not write the following: 'sword', 'axe', 'spear' or 'mace'.

        //The code below makes it so that depending on what the player writes, they are given a specific weapon.
        //For example, if the player writes 'Sword', they are given the Sword.
        if(weaponChoice == "a")
        {
            Console.WriteLine("\n\nYou chose the Sword");
            return new Sword();
        }
        else if(weaponChoice == "b")
        {
            Console.WriteLine("\n\nYou chose the Axe");
            return new Axe();
        }
        else if(weaponChoice == "c")
        {
            Console.WriteLine("\n\nYou chose the Spear");
            return new Spear();
        }
        else
        {
            Console.WriteLine("\n\nYou chose the Mace");
            return new Mace();
        }
        
    }

    
}
