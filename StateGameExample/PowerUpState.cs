namespace StateGameExample;

public class PowerUpState : ICharacterState
{
    private int _powerUpDuration = 10; //10 ticks
    public void HandleCollectPowerUp(Character character)
    {
        _powerUpDuration = 10;
    }

    public void HandleDamage(Character character, int amount)
    {
        character.ModifyHealth(-(amount / 2));
        if (character.Health <= 0)
        {
            character.SetState(new DefeatedState());
        }
    }

    public void HandleUpdate(Character character)
    {
        _powerUpDuration--;
        if( _powerUpDuration <= 1)
        {
            character.SetPowerUp(false);
            character.SetState(new NormalState());
        }
    }
}
