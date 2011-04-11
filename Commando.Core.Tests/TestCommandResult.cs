namespace Commando.Core.Tests
{
  public class TestCommandResult : ICommandResult
  {
    public TestCommandResult(bool success)
    {
      Success = success;
    }

    public bool Success { get; private set; }
  }
}