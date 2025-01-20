using AbstractFactoryGame.CaveLevel;
using AbstractFactoryGame.Common;
using AbstractFactoryGame.HauntedHouseLevel;

LevelElementFactory factory;
   
factory = new CaveLevelElementFactory();
factory.SetupEnvironment();

Console.WriteLine();

factory = new HauntedHouseElementFactory();
factory.SetupEnvironment();