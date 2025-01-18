using FactoryMethod_Game.Enemies;

namespace FactoryMethod_Game.Levels;
public class HauntedHouseLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }
}
