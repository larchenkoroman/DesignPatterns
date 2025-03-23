namespace StateGameExample;

public interface ICharacterState
{
    public void HandleDamage(Character character, int amount);
    public void HandleCollectPowerUp(Character character);
    public void HandleUpdate(Character character);

}
