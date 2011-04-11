namespace Commando.Core.Tests
{
  public class TestCommand : CommandBase<TestCommandResult>
  {
    public string Data { get; set; }

    public override void Execute()
    {
      Result = new TestCommandResult(true);
    }
  }
}