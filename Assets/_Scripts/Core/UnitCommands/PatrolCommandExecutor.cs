using _Scripts.Abstraction.Commands;
using _Scripts.Abstraction.Commands.CommandsInterfaces;
using UnityEngine;

namespace _Scripts.Core.UnitCommands
{
    public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            Debug.Log($"{name} start patrolling between point - {command.From} and point - {command.To} has begun");
        }
    }
}