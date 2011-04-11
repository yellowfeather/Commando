namespace Commando.Core
{
  public interface ICommand<out TResult> : IMessage where TResult : ICommandResult
  {
    void Execute();
    TResult Result { get; }
  }
}