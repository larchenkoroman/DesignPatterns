namespace AbstractFactoryGame.Common;
public abstract class LevelElementFactory
{
    public abstract IEnemy CreateEnemy();
    public abstract IWeapon CreateWeapon();
    public abstract IPowerUp CreatePowerUp();
    public void SetupEnvironment()
    {
        var enemy = CreateEnemy();
        var weapon = CreateWeapon();
        var powerup = CreatePowerUp();

        Console.WriteLine(enemy.GetType().Name);
        Console.WriteLine(weapon.GetType().Name);
        Console.WriteLine(powerup.GetType().Name);
    }
}
