namespace State;

public interface IState
{
    public void Handle(Context context);
}
