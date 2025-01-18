namespace FactoryMethod_Game.Enemies;
public class Ghost : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Ghost attacks!");
    }

    public void Scream()
    {
        Console.WriteLine("This is Ghost!");
    }
}
