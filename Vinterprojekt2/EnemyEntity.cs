public class EnemyEntity : Entity
{
    private Random Generator = new Random();

    private bool IsAlive = true;

    //-------------------------------------------

    

    public override void SetName()
    {
        Console.WriteLine("\n\nA good name! Now, this is who you will be facing:");
        int i = Random.Shared.Next(names.Count);

        name = Console.ReadLine();
    }

    public bool GetAlive()
    {
        return IsAlive;
    }

    public void HealthStatusCheck()
    {
        if(health <= 0)
        {
            IsAlive = false;
        }
    }
}
