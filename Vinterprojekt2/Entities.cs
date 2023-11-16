using System.Security.Cryptography;

public class Entities
{
    //public string name;

    public int health = 100;

    List<string> Name = new List<string>() {"Karl", "Wayfarer", "Curier", "Mako", "Kusanagi"};

    private Random Generator = new Random();

    public Axe axe;

    public Sword sword;

    public Spear spear;

    public Mace mace;

    public Weapons weapon;

}
