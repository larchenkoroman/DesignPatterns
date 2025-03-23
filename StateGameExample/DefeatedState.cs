namespace StateGameExample;

public class DefeatedState : ICharacterState
{
    private int _powerUpDuration = 10; //10 ticks
    public void HandleCollectPowerUp(Character character)
    {
    }

    public void HandleDamage(Character character, int amount)
    {
    }

    public void HandleUpdate(Character character)
    {
    }
}
