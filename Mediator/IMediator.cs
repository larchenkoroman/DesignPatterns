namespace Mediator;

public interface IMediator
{
    void Notify(Colleague sender, string @event);
}
