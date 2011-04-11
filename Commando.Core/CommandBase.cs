namespace Commando.Core
{
  public abstract class CommandBase<TResult> : ICommand<TResult> where TResult : ICommandResult
  {
    public TResult Result { get; protected set; }
    public abstract void Execute();
  }
}