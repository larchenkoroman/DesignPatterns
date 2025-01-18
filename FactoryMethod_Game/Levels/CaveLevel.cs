using FactoryMethod_Game.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Game.Levels;
public class CaveLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }
}
