namespace _Scripts.Abstraction.Commands
{
    public interface ICommandExecutor
    {
        void ExecuteCommand(object command);
    }
}