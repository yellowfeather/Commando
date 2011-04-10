namespace Commando.Core
{
  public interface ICommand : IMessage
  {
    
  }

  public interface ICommandT<TResult> : ICommand where TResult : ICommandResult
  {
    TResult Result { get; }
  }
}