namespace Commando.Core
{
  public interface IBus
  {
    void Send(ICommand command);
    void Publish(IEvent @event);
  }
}