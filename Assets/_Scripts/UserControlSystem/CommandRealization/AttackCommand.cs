using _Scripts.Abstraction;
using _Scripts.Abstraction.Commands.CommandsInterfaces;

namespace _Scripts.UserControlSystem.CommandRealization
{
    public class AttackCommand : IAttackCommand
    {
        public IAttackable Target { get; }

        public AttackCommand(IAttackable target)
        {
            Target = target;
        }
    }
}