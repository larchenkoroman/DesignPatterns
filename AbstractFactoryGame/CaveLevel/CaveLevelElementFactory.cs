using AbstractFactoryGame.Common;

namespace AbstractFactoryGame.CaveLevel;
public class CaveLevelElementFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }

    public override IPowerUp CreatePowerUp()
    {
        return new Crystal();
    }

    public override IWeapon CreateWeapon()
    {
        return new Axe();
    }
}
