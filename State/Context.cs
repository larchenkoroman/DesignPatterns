namespace State;

public class Context(IState initialState)
{
    private IState _state = initialState;
    public void SetState(IState state) => _state = state; 
    public void Request() => _state.Handle(this);
}
