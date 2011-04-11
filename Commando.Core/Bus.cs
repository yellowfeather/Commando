using Microsoft.Practices.ServiceLocation;

namespace Commando.Core
{
  public class Bus : IBus
  {
    private readonly IServiceLocator _serviceLocator;

    public Bus(IServiceLocator serviceLocator)
    {
      _serviceLocator = serviceLocator;
    }

    public void Send<TMessage>(TMessage message) where TMessage : IMessage
    {
      var handlers = _serviceLocator.GetAllInstances<IMessageHandler<TMessage>>();
      foreach (var handler in handlers) {
        handler.Handle(message);
      }
    }
  }
}