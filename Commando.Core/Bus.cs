using System;

namespace Commando.Core
{
  public class Bus : IBus
  {
    public void Send(ICommand command)
    {
      throw new NotImplementedException();
    }

    public void Publish(IEvent @event)
    {
      throw new NotImplementedException();
    }
  }
}