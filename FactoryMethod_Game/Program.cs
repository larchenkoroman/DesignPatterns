using FactoryMethod_Game.Enemies;
using FactoryMethod_Game.Levels;

Level level = new CaveLevel();
//Level level = new HauntedHouseLevel();
IEnemy enemy = level.CreateEnemy();

Console.WriteLine(enemy.GetType().Name);