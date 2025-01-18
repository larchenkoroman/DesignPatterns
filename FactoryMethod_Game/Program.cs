using FactoryMethod_Game.Enemies;
using FactoryMethod_Game.Levels;

Level level1 = LevelFactory.CreateLevel(1);
Level level2 = LevelFactory.CreateLevel(2);

level1.EncounterEnemy();
level2.EncounterEnemy();