using _Scripts.Abstraction.Commands;
using _Scripts.Abstraction.Commands.CommandsInterfaces;
using UnityEngine;

namespace _Scripts.Core.UnitCommands
{
    public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
    {
        public override void ExecuteSpecificCommand(IStopCommand command)
        {
            Debug.Log("Stop!");
        }
    }

}