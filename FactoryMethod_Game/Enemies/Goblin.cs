namespace FactoryMethod_Game.Enemies;
public class Goblin : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Goblin attacs!");
    }

    public void Scream()
    {
        Console.WriteLine("This is Goblin!");
    }
}
