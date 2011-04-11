namespace Commando.Core.Tests
{
  public class TestCommandHandler : IMessageHandler<TestCommand>
  {
    public void Handle(TestCommand command)
    {
      command.Execute();
    }
  }
}