using FactoryMethod_Game.Enemies;

namespace FactoryMethod_Game.Levels;
public abstract class Level
{
    public abstract IEnemy CreateEnemy();
}
