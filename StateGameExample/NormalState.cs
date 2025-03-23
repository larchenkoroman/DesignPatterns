namespace StateGameExample;

public class NormalState : ICharacterState
{
    public void HandleCollectPowerUp(Character character)
    {
        character.SetPowerUp(true);
        character.SetState(new PowerUpState());
    }

    public void HandleDamage(Character character, int amount)
    {
        character.ModifyHealth(-amount);
        if (character.Health <= 0)
        {
            character.SetState(new DefeatedState());
        }
        else if (character.Health < 30)
        {
            character.SetState(new InjuredState());
        }

    }

    public void HandleUpdate(Character character)
    {
        //
    }
}
