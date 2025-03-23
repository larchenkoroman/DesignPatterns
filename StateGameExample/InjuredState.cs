namespace StateGameExample;

public class InjuredState : ICharacterState
{
    private int _powerUpDuration = 10; //10 ticks
    public void HandleCollectPowerUp(Character character)
    {
        character.ModifyHealth(50);
        character.SetState(new NormalState());
    }

    public void HandleDamage(Character character, int amount)
    {
        character.ModifyHealth(-(amount * 2));
        if(character.Health <= 0)
        {
            character.SetState(new DefeatedState());
        }
    }

    public void HandleUpdate(Character character)
    {
        character.ModifyHealth(2);
        if(character.Health >= 30)
        {
            character.SetState(new NormalState());
        }
    }
}
