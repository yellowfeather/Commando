namespace Commando.Core
{
  public interface IBus
  {
    void Send<TMessage>(TMessage message) where TMessage : IMessage;
  }
}