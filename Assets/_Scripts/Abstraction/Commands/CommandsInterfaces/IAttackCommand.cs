namespace _Scripts.Abstraction.Commands.CommandsInterfaces
{
    public interface IAttackCommand: ICommand
    {
        public IAttackable Target { get; }

    }
}