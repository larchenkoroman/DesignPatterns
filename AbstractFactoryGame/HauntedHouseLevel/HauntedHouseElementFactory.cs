using AbstractFactoryGame.Common;

namespace AbstractFactoryGame.HauntedHouseLevel;
public class HauntedHouseElementFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }

    public override IPowerUp CreatePowerUp()
    {
        return new Orb();
    }

    public override IWeapon CreateWeapon()
    {
        return new Staff();
    }
}
