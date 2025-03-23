using StateGameExample;

Character hero = new Character(); //notmal state
Console.WriteLine($"Initial health {hero.Health}, has PowerUp {hero.HasPowerUp}");
hero.TakeDamage(30);
Console.WriteLine($"After damage health {hero.Health}, has PowerUp {hero.HasPowerUp}");

hero.CollectPowerUp();
hero.TakeDamage(30);
Console.WriteLine($"After second damage health {hero.Health}, has PowerUp {hero.HasPowerUp}");

for (int i = 0; i < 12; i++)
{
    hero.Update();
}
Console.WriteLine($"After 12 ticks health {hero.Health}, has PowerUp {hero.HasPowerUp}");

hero.TakeDamage(70);
Console.WriteLine($"After third damage health {hero.Health}, has PowerUp {hero.HasPowerUp}");
